Get single
=========================

Get details of a specific user group.
This endpoint returns detailed information about a single user group, optionally including its members.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/user-groups/{groupId}?includeMembers={includeMembers}

**URI Parameters**

+------------------------+--------------------+-----------------------------------------+
| Name                   | Type               | Description                             |
+========================+====================+=========================================+
| groupId                | UUID               | id of user group                        |
+------------------------+--------------------+-----------------------------------------+
| includeMembers         | boolean (optional) | Include group members (default: false)  |
+------------------------+--------------------+-----------------------------------------+
| organizationId         | number             | id of organization                      |
+------------------------+--------------------+-----------------------------------------+

Responses 
-------------

+------------------------+--------------------------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                                                 | Description              |
+========================+======================================================================================+==========================+
| 200 OK                 | :doc:`Organization group details <../../datastructures/organization-group-details>`  | successful operation     |
+------------------------+--------------------------------------------------------------------------------------+--------------------------+

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
                "id": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
                "members": null,
                "name": "Engineering Team"
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
                "id": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
                "members": [
                    {
                        "displayName": "John Doe",
                        "email": "john.doe@company.com",
                        "organizationUserId": 11
                    },
                    {
                        "displayName": "Jane Smith",
                        "email": "jane.smith@company.com",
                        "organizationUserId": 12
                    }
                ],
                "name": "Engineering Team"
            },
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }