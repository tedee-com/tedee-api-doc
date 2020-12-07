Lock - List
=========================

Endpoint that returns list of all currently logged user locks.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/lock

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

Get list of locks
^^^^^^^^^^^^^^^^^
Sample Request
""""""""""""""""""""

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

Sample Response
""""""""""""""""""""
HTTP status code: ``200``

.. code-block:: js

    {
        "result": [
            {
                "bridgeId": 2,
                "deviceSettings": {
                    "autoLockEnabled": true,
                    "autoLockDelay": 10,
                    "autoLockImplicitEnabled": false,
                    "autoLockImplicitDelay": 0,
                    "pullSpringEnabled": true,
                    "pullSpringDuration": 10,
                    "autoPullSpringEnabled": false,
                    "postponedLockEnabled": false,
                    "postponedLockDelay": 0,
                    "buttonLockEnabled": false,
                    "buttonUnlockEnabled": false
                },
                "autoUnlockEnabled": false,
                "autoUnlockConfirmEnabled": false,
                "autoUnlockRangeIn": false,
                "autoUnlockRangeOut": false,
                "autoUnlockTimeout": false,
                "location": false,
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
        ]
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
