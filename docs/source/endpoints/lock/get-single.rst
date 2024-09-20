Get single
=========================

Get lock by provided id.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/lock/{id}

**URI Parameters**

+------------------------+--------------------+---------------------------------+
| Name                   | Type               | Description                     |
+========================+====================+=================================+
| id                     | number             | id of lock                      |
+------------------------+--------------------+---------------------------------+
| includeUserSettings    | boolean (optional) | should userSettings be included |
+------------------------+--------------------+---------------------------------+

Responses 
-------------

+------------------------+-------------------------------------------+--------------------------+
| Name                   | Type                                      | Description              |
+========================+===========================================+==========================+
| 200 OK                 | :doc:`Lock <../../datastructures/lock>`   | successful operation     |
+------------------------+-------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.Read            | Grants user possibility to read data connected with devices             |
+------------------------+-------------------------------------------------------------------------+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Get single lock
^^^^^^^^^^^^^^^

**Sample request for lock with id = 123**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/123" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response for lock paired with bridge**

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
                    "buttonUnlockEnabled": false
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
                    "state": 3,
                    "isCharging": false,
                    "batteryLevel": 18,
                    "stateChangeResult": 0,
                    "lastStateChangedDate": "2021-04-26T06:02:04.197Z"
                },
                "beaconMajor": 56,
                "beaconMinor": 57,
                "timeZone": "Europe/Warsaw",
                "id": 1,
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


**Sample response for lock not paired with bridge**

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
                    "buttonUnlockEnabled": false
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
                "lockProperties": null,
                "beaconMajor": null,
                "beaconMinor": null,
                "id": 1,
                "connectedToId": null,
                "serialNumber": "111111-11111",
                "name": "Room 6",
                "userIdentity": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
                "type": 2,
                "created": "2020-01-01T00:00:00",
                "revision": 2,
                "deviceRevision": 2,
                "targetDeviceRevision": 2,
                "isConnected": null,
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
