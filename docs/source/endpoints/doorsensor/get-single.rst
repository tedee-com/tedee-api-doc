Get single
====================

Returns the door sensor with the specified id.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/doorsensor/{id}

**URI Parameters**

+------------------------+--------------------+---------------------------------+
| Name                   | Type               | Description                     |
+========================+====================+=================================+
| id                     | number             | id of the door sensor           |
+------------------------+--------------------+---------------------------------+
| includeUserSettings    | boolean (optional) | should userSettings be included |
+------------------------+--------------------+---------------------------------+

Responses 
-------------

+------------------------+-------------------------------------------------------+--------------------------+
| Name                   | Type                                                  | Description              |
+========================+=======================================================+==========================+
| 200 OK                 | :doc:`Door sensor <../../datastructures/door-sensor>` | successful operation     |
+------------------------+-------------------------------------------------------+--------------------------+

Scopes

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.Read            | Grants user possibility to read data connected with devices             |
+------------------------+-------------------------------------------------------------------------+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Get single door sensor
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request for door sensor with id = 123**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/doorsensor/123?includeUserSettings=true" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
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
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }