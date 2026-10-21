Get single
====================

Returns the switch with the specified id.

If you want to get familiar with the whole flow how to manage and operate switches, please refer to our tutorial: :doc:`How to manage and operate switches <../../howtos/manage-and-operate-switches>`.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/switch/{id}

**URI Parameters**

+---------------------+--------------------+---------------------------------+
| Name                | Type               | Description                     |
+=====================+====================+=================================+
| id                  | number             | id of the switch                |
+---------------------+--------------------+---------------------------------+
| includeUserSettings | boolean (optional) | should userSettings be included |
+---------------------+--------------------+---------------------------------+

Responses
-------------

+---------------+---------------------------------------------+----------------------------------------------+
| Name          | Type                                        | Description                                  |
+===============+=============================================+==============================================+
| 200 OK        | :doc:`Switch <../../datastructures/switch>` | successful operation                         |
+---------------+---------------------------------------------+----------------------------------------------+
| 404 Not Found |                                             | switch not found or user has no access to it |
+---------------+---------------------------------------------+----------------------------------------------+

Scopes
-------------

+------------------+-----------------------------------------------------------------------+
| Name             | Description                                                           |
+==================+=======================================================================+
| Device.Read      | Grants user possibility to read data connected with devices           |
+------------------+-----------------------------------------------------------------------+
| Device.ReadWrite | Grants user possibility to read and write data connected with devices |
+------------------+-----------------------------------------------------------------------+

Examples
-------------

Get single switch
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request for switch with id = 123**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/switch/123?includeUserSettings=true" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
        "icon": 1,
        "deviceSettings": {
            "mode": 1,
            "openActionOutput": 1,
            "output1": {
                "impulseLength": 5
            },
            "output2": {
                "impulseLength": 1
            }
        },
        "deviceState": {
            "isUpdating": false
        },
        "userSettings": {
            "favorite": true,
            "autoUnlockEnabled": false,
            "autoUnlockConfirmEnabled": false,
            "autoUnlockRangeIn": 100,
            "autoUnlockRangeOut": 300,
            "autoUnlockTimeout": 5,
            "autoUnlockCheckWiFi": false,
            "autoUnlockCancelOtherAutoUnlock": false,
            "autoUnlockCheckDeviceMovements": false,
            "wiFiName": null,
            "location": null,
            "autoUnlockBleSignalStrength": null,
            "notifications": null
        },
        "connectedToLockId": null,
        "id": 123,
        "organizationId": 901,
        "serialNumber": "26050101-000123",
        "name": "Front gate",
        "userIdentity": "12345678-1234-1234-1234-1234567890",
        "type": 14,
        "created": "2026-05-04T10:15:32.1234567",
        "revision": 3,
        "deviceRevision": 3,
        "targetDeviceRevision": 3,
        "timeZone": "Europe/Warsaw",
        "isConnected": true,
        "accessDetails": {
            "accessLevel": 2,
            "remoteAccessDisabled": false,
            "weekDays": null,
            "startDate": null,
            "endDate": null,
            "dayStartTime": null,
            "dayEndTime": null
        },
        "softwareVersions": [
            {
                "softwareType": 0,
                "version": "1.0.0",
                "updateAvailable": false
            }
        ]
    },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
