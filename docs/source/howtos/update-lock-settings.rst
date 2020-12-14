How to update lock settings
===========================

If you want to update lock settings, the first thing you need to do is use endpoint :doc:`Get single lock <../endpoints/lock/get-single>`:

**Sample request for lock with Id = 1**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "bridgeId": 2,
                "deviceSettings": {
                    "autoLockEnabled": true,
                    "autoLockDelay": 10,
                    "autoLockImplicitEnabled": false,
                    "autoLockImplicitDelay": 10,
                    "pullSpringEnabled": true,
                    "pullSpringDuration": 10,
                    "autoPullSpringEnabled": false,
                    "postponedLockEnabled": false,
                    "postponedLockDelay": 10,
                    "buttonLockEnabled": false,
                    "buttonUnlockEnabled": false
                },
                "autoUnlockEnabled": false,
                "autoUnlockConfirmEnabled": false,
                "autoUnlockRangeIn": 300,
                "autoUnlockRangeOut": 400,
                "autoUnlockTimeout": 20,
                "location": null,
                "lockProperties": {
                    "state": 3,
                    "isCharging": false,
                    "batteryLevel": 18
                },
                "id": 1,
                "connectedToId": 2,
                "serialNumber": "111111-11111",
                "macAddress": "00:0A:95:9D:68:16",
                "name": "Room 6",
                "userIdentity": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
                "type": 2,
                "created": "2020-01-01T00:00:00",
                "revision": 2,
                "deviceRevision": 2,
                "targetDeviceRevision": 2,
                "isConnected": true,
                "accessLevel": 2,
                "shareDetails": null,
                "softwareVersions": [
                    {
                        "softwareType": 0,
                        "version": "1.0.0",
                        "updateAvailable": true
                    }
                ]
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }


Above endpoint returns data for the selected lock. The data includes the **revision** attribute. 
This is the version of the current lock settings and you must provide this value in the next update request.

After successfully retrieving the revision of the current lock settings, you can use endpoint :doc:`Update lock <../endpoints/lock/update>` to update the lock:

**Sample request to update autoLock and autoUnlock settings**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "revision": 2,
            "deviceSettings": {
                "autoLockEnabled": true,
                "autoLockDelay": 10
            },
            "autoUnlockEnabled": true,
            "autoUnlockConfirmEnabled": true,
            "autoUnlockRangeIn": 100,
            "autoUnlockRangeOut": 100,
            "autoUnlockTimeout": 30
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "id": 1,
                "revision": 3,
                "targetDeviceRevision": 3
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }

The revision value in the update request must be the same as the current value in the system, otherwise the request will be refused with 409 (Conflict) error.
If update will success you will receive the new revison value.

All parameters in this endpoint (except id and revision) are optional. 
This means that specifying a given parameter will update its value. If a given parameter is not specified, its value will not change.

Only the owner or admin can update device settings and name. Guest can only modify auto-unlock settings and location.
