Get access
=========================

Get device accesses for an organization user group.
This endpoint returns a paginated list of all device accesses that have been granted to the specified user group.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/user-groups/{groupId}/access?page={page}&itemsPerPage={itemsPerPage}&filters.text={text}

**URI Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| filters.text           | string (optional) | Filter by device name                  |
+------------------------+-------------------+----------------------------------------+
| groupId                | UUID              | id of user group                       |
+------------------------+-------------------+----------------------------------------+
| itemsPerPage           | number (optional) | Items per page (max: 100, min: 1)      |
+------------------------+-------------------+----------------------------------------+
| organizationId         | number            | id of organization                     |
+------------------------+-------------------+----------------------------------------+
| page                   | number (optional) | Page number (min: 1)                   |
+------------------------+-------------------+----------------------------------------+

Responses 
-------------

+------------------------+----------------------------------------------------------------+--------------------------+
| Name                   | Type                                                           | Description              |
+========================+================================================================+==========================+
| 200 OK                 | Group device accesses response                                | successful operation     |
+------------------------+----------------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| Organization.ReadWrite | Grants user possibility to read and write organization data                  |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Get all group accesses
^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a/access" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "items": [
                    {
                        "accessId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                        "accessLevel": 1,
                        "deviceId": 123,
                        "deviceName": "Main Entrance",
                        "deviceType": 0
                    },
                    {
                        "accessId": "4ab96f75-6828-5673-c4gd-3d074g77bgb7",
                        "accessLevel": 0,
                        "deviceId": 124,
                        "deviceName": "Conference Room",
                        "deviceType": 0
                    },
                    {
                        "accessId": "5bc07g86-7939-6784-d5he-4e185h88chc8",
                        "accessLevel": 0,
                        "deviceId": 125,
                        "deviceName": "Storage Room",
                        "deviceType": 1
                    }
                ],
                "totalCount": 3
            },
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }

Filter accesses by device name
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a/access?filters.text=Main" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "items": [
                    {
                        "accessId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                        "accessLevel": 1,
                        "deviceId": 123,
                        "deviceName": "Main Entrance",
                        "deviceType": 0
                    }
                ],
                "totalCount": 1
            },
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }

.. note::
   This endpoint shows all devices that the group has access to. To grant or revoke device access for a group, use the device access endpoints with principalType: 1.