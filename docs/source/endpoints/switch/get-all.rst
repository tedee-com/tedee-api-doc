Get all
====================

Returns the switches of the currently logged-on user.

If you want to get familiar with the whole flow how to manage and operate switches, please refer to our tutorial: :doc:`How to manage and operate switches <../../howtos/manage-and-operate-switches>`.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/switch

**URI Parameters**

+---------------------+--------------------+---------------------------------+
| Name                | Type               | Description                     |
+=====================+====================+=================================+
| filters.name        | string (optional)  | filtering by switch name        |
+---------------------+--------------------+---------------------------------+
| includeUserSettings | boolean (optional) | should userSettings be included |
+---------------------+--------------------+---------------------------------+
| itemsPerPage        | integer (optional) | count of items on page          |
+---------------------+--------------------+---------------------------------+
| page                | integer (optional) | number of page                  |
+---------------------+--------------------+---------------------------------+

Responses
-------------

+--------+------------------------------------------------------+----------------------+
| Name   | Type                                                 | Description          |
+========+======================================================+======================+
| 200 OK | :doc:`Switch List<../../datastructures/switch-list>` | successful operation |
+--------+------------------------------------------------------+----------------------+

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

Get all switches of currently logged user
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/switch" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "page": 1,
            "itemsPerPage": 2147483647,
            "switches": [
                {
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
                    "userSettings": null,
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
                }
            ]
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
