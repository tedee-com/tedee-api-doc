Get members
=========================

Get members of an organization user group.
This endpoint returns a paginated list of users who are members of the specified group.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/user-groups/{groupId}/members?page={page}&itemsPerPage={itemsPerPage}&filters.text={text}

**URI Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| filters.text           | string (optional) | Filter by name or email                |
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

+------------------------+---------------------------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                                                  | Description              |
+========================+=======================================================================================+==========================+
| 200 OK                 | :doc:`Organization group member <../../datastructures/organization-group-member>` []  | successful operation     |
+------------------------+---------------------------------------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| Organization.Read      | Grants user possibility to read organization data                             |
+------------------------+-------------------------------------------------------------------------------+
| Organization.ReadWrite | Grants user possibility to read and write organization data                   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Get all group members
^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a/members" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "items": [
                    {
                        "displayName": "John Doe",
                        "email": "john.doe@company.com",
                        "organizationUserId": 11
                    },
                    {
                        "displayName": "Jane Smith",
                        "email": "jane.smith@company.com",
                        "organizationUserId": 12
                    },
                    {
                        "displayName": "Bob Wilson",
                        "email": "bob.wilson@company.com",
                        "organizationUserId": 13
                    }
                ],
                "totalCount": 3
            },
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }

Search for specific members
^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a/members?filters.text=john" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "items": [
                    {
                        "displayName": "John Doe",
                        "email": "john.doe@company.com",
                        "organizationUserId": 11
                    }
                ],
                "totalCount": 1
            },
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }