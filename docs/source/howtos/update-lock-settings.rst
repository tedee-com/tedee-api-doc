How to update lock settings
===========================

In this section let's focus on how to update tedee lock settings. 
If you want to update lock settings, the first thing you need to know is that there are two kinds of lock settings:

* **device settings** - settings on the device side. That means changing settings will affect all device users that have access to that lock
* **user settings** - each user has his/her own settings and they are responsible for auto unlock feature

To update device settings firstly use endpoint :doc:`Get single lock <../endpoints/lock/get-single>`:

**Sample request**

This request will get data for lock with id = 123

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/123" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
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
                    "buttonUnlockEnabled": false,
                    "isAsync": false,
                    "openDoorAlertEnabled": false,
                    "openDoorAlertThreshold": 300,
                    "autoLockAfterDoorClosedEnabled": false,
                    "doorStateEventLoggingEnabled": false
                },
                "userSettings": {
                    "autoUnlockEnabled": true,
                    "autoUnlockConfirmEnabled": true,
                    "autoUnlockRangeIn": 300,
                    "autoUnlockRangeOut": 400,
                    "autoUnlockTimeout": 20,
                    "location": {
                        "latitude": 52.24070739746092,
                        "longitude": 21.086990356445305
                },
                "lockProperties": {
                    "state": 6,
                    "doorState": 3,
                    "isCharging": false,
                    "batteryLevel": 18,
                    "stateChangeResult": 0,
                    "lastStateChangedDate": "2021-04-26T06:02:04.197Z"
                },
                "id": 123,
                "connectedToId": 2,
                "serialNumber": "111111-11111",
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

After successfully retrieving the revision of the current lock settings, you can use endpoint :doc:`Update lock <../endpoints/lock/update>` to update the lock.

Update device settings
----------------------

Firstly let's focus on updating device settings. To do that you need to specify which settings from :doc:`Device settings <../datastructures/device-settings>` you want to update.

**Sample request**

Example shows how to update settings that enable auto lock feature and set delay to 10 seconds for the device with id = 1. Also we update name of the lock.

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "revision": 2,
            "name": "Front door lock",
            "deviceSettings": {
                "autoLockEnabled": true,
                "autoLockDelay": 10
            }
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

The targetDeviceRevision value is responsible for checking if device settings are up to date. 
Process of the updating device settings is described below:

1. Device receives settings with targetDeviceRevision. 
2. If targetDeviceRevision is greater than revision on the device, device will update its settings. 
3. Device sends confirmation about successful settings update.

.. note::
    It is possible that revision and targetDeviceRevision values are not equal. 
    It means that there have been more updates not related to device settings than to the device settings themselves.

All parameters in this endpoint (except id and revision) are optional. 
This means that specifying a given parameter will update its value. If a given parameter is not specified, its value will not change.

Only the owner or admin can update device settings and name. Guest can only modify lock user settings and location.

Update lock user settings
--------------------------

Let's focus now how to update lock user settings for the lock. Each user can have different set of settings.
You need to specify which settings from :doc:`Lock user settings <../datastructures/lock-user-settings>` you want to update.

**Sample request**

Sample request will update auto unlock settings with location for the device with id = 1.

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "revision": 2,
            "userSettings": {
                    "autoUnlockEnabled": true,
                    "autoUnlockConfirmEnabled": true,
                    "autoUnlockRangeIn": 300,
                    "autoUnlockRangeOut": 400,
                    "autoUnlockTimeout": 20,
                    "location": {
                        "latitude": 52.24070739746092,
                        "longitude": 21.086990356445305
            }
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