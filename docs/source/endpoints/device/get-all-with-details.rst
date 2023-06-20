Get all with details
====================================

Get a list of all currently logged user devices with details such as devices specific data as well as their settings and share details.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/device/details

Responses 
-------------

+------------------------+-----------------------------------------------+--------------------------+
| Name                   | Type                                          | Description              |
+========================+===============================================+==========================+
| 200 OK                 | :doc:`Lock <../../datastructures/lock>` []    | successful operation     |
+                        +-----------------------------------------------+                          +
|                        | :doc:`Bridge <../../datastructures/bridge>` []|                          |
+------------------------+-----------------------------------------------+--------------------------+

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

Get all devices with details of currently logged user 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/device/details" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "bridges": [
            {
                "beaconMajor": 10,
                "beaconMinor": 10,
                "wasConfigured": true,
                "isUpdating": false,
                "timeZone": "Europe/Warsaw",
                "id": 2,
                "serialNumber": "111111-111112",
                "name": "Bridge 1",
                "userIdentity": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
                "type": 1,
                "created": "2020-01-01T00:00:00",
                "revision": 1,
                "deviceRevision": 1,
                "targetDeviceRevision": 1,
                "isConnected": true,
                "accessLevel": 2,
                "shareDetails": null,
                "softwareVersions": [
                {
                    "softwareType": 0,
                    "version": "1.0.1",
                    "updateAvailable": true
                },
                {
                    "softwareType": 1,
                    "version": "2.0.0",
                    "updateAvailable": true
                }
                ]
            }
            ],
            "locks": [
            {
                "deviceSettings": {
                    "autoLockEnabled": true,
                    "autoLockDelay": 10,
                    "autoLockImplicitEnabled": true,
                    "autoLockImplicitDelay": 10,
                    "pullSpringEnabled": true,
                    "pullSpringDuration": 10,
                    "autoPullSpringEnabled": true,
                    "postponedLockEnabled": true,
                    "postponedLockDelay": 10,
                    "buttonLockEnabled": true,
                    "buttonUnlockEnabled": true
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
                "beaconMajor": 10,
                "beaconMinor": 10,
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
            ]
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
