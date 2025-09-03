Get single
=========================

Get details of a specific user group.
This endpoint returns detailed information about a single user group, optionally including its members.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/user-groups/{groupId}?includeMembers={includeMembers}

**URI Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| groupId                | UUID              | id of user group                       |
+------------------------+-------------------+----------------------------------------+
| includeMembers         | boolean (optional)| Include group members (default: false) |
+------------------------+-------------------+----------------------------------------+
| organizationId         | number            | id of organization                     |
+------------------------+-------------------+----------------------------------------+

Responses 
-------------

+------------------------+----------------------------------------------------------------+--------------------------+
| Name                   | Type                                                           | Description              |
+========================+================================================================+==========================+
| 200 OK                 | Organization user group details                                | successful operation     |
+------------------------+----------------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| Organization.ReadWrite | Grants user possibility to read and write organization data                   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Get group details
^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "createdDate": "2025-01-01T10:00:00.000Z",
                "id": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
                "members": null,
                "membersCount": 5,
                "name": "Engineering Team",
                "organizationId": 1
            },
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }

Get group with members
^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a?includeMembers=true" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "createdDate": "2025-01-01T10:00:00.000Z",
                "id": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
                "members": [
                    {
                        "email": "john.doe@company.com",
                        "name": "John Doe",
                        "organizationUserId": 11
                    },
                    {
                        "email": "jane.smith@company.com",
                        "name": "Jane Smith",
                        "organizationUserId": 12
                    }
                ],
                "membersCount": 2,
                "name": "Engineering Team",
                "organizationId": 1
            },
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }