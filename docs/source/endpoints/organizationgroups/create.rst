Create
=========================

Add a new user group to an organization.
This endpoint creates a new user group within the specified organization.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/organization/{organizationId}/user-groups

**URI Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| organizationId         | number            | id of organization                     |
+------------------------+-------------------+----------------------------------------+

**Body Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| name                   | string            | name of the user group                 |
+------------------------+-------------------+----------------------------------------+

Responses 
-------------

+------------------------+----------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                                 | Description              |
+========================+======================================================================+==========================+
| 200 OK                 | UUID of created group                                                | successful operation     |
+------------------------+----------------------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| Organization.ReadWrite | Grants user possibility to read and write organization data                   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Create a new group
^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/organization/1/user-groups" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "name": "Security Team"
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "id": "c6e7f8a9-0b1c-2d3e-4f5a-6b7c8d9e0f1a"
            },
            "errorMessages": [],
            "statusCode": 200,
            "success": true
        }