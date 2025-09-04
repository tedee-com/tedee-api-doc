Get all
=========================

Get all user groups in an organization.
This endpoint returns a paginated list of user groups that belong to the specified organization.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/user-groups?page={page}&itemsPerPage={itemsPerPage}&filters.text={text}

**URI Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| organizationId         | number            | id of organization                     |
+------------------------+-------------------+----------------------------------------+
| filters.text           | string (optional) | Filter groups by name                  |
+------------------------+-------------------+----------------------------------------+
| itemsPerPage           | number (optional) | Items per page (max: 100, min: 1)      |
+------------------------+-------------------+----------------------------------------+
| page                   | number (optional) | Page number (min: 1)                   |
+------------------------+-------------------+----------------------------------------+

Responses 
-------------

+------------------------+------------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                                   | Description              |
+========================+========================================================================+==========================+
| 200 OK                 | :doc:`Organization group <../../datastructures/organization-group>` [] | successful operation     |
+------------------------+------------------------------------------------------------------------+--------------------------+

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

Get all groups
^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user-groups" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": [
                {
                    "id": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
                    "name": "Engineering Team"
                },
                {
                    "id": "b5d6e7f8-8c9d-2e3f-4a5b-6c7d8e9f0b1c",
                    "name": "Maintenance Team"
                }
            ],
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }

Get groups with filter
^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user-groups?filters.text=Engineering&page=1&itemsPerPage=10" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": [
                {
                    "id": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
                    "name": "Engineering Team"
                }
            ],
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }