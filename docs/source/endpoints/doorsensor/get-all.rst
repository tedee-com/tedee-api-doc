Get all
====================

Returns the door sensors of the currently logged-on user.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/doorsensor

**URI Parameters**

+------------------------+--------------------+----------------------------------------+   
| Name                   | Type               | Description                            |
+========================+====================+========================================+
| filters.name           | string (optional)  | filtering by door sensor name          |
+------------------------+--------------------+----------------------------------------+
| includeUserSettings    | boolean (optional) | should userSettings be included        |
+------------------------+--------------------+----------------------------------------+
| itemsPerPage           | integer (optional) | count of items on page                 |
+------------------------+--------------------+----------------------------------------+
| page                   | integer (optional) | number of page                         |
+------------------------+--------------------+----------------------------------------+

Responses 
-------------

+------------------------+------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                             | Description              |
+========================+==================================================================+==========================+
| 200 OK                 | :doc:`Door sensor list <../../datastructures/door-sensor-list>`  | successful operation     |
+------------------------+------------------------------------------------------------------+--------------------------+

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

Get all door sensors of currently logged user 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/doorsensor?includeUserSettings=true" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "page": 1,
            "itemsPerPage": 2147483647,
            "doorSensors": [
                {
                    "userSettings": {
                        "favorite": true
                    },
                    "connectedToLockId": 456,
                    "deviceState": {
                        "batteryLevel": 74,
                        "batteryLevelModifiedTime": "2024-12-10T08:24:15"
                    },
                    "id": 123,
                    "organizationId": 1,
                    "serialNumber": "12345-67890",
                    "name": "Door sensor Test",
                    "userIdentity": "1234567890",
                    "type": 8,
                    "created": "2024-12-01T16:10:34",
                    "revision": 1,
                    "deviceRevision": 1,
                    "targetDeviceRevision": 1,
                    "timeZone": "Europe/Warsaw",
                    "isConnected": null,
                    "accessLevel": 2,
                    "accessDetails": null,
                    "softwareVersions": [
                        {
                            "softwareType": 0,
                            "version": "1.0",
                            "updateAvailable": false
                        }
                    ]
                }   
            ]
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }