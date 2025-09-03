Add members
=========================

Add users to an organization user group.
This endpoint allows you to add one or more organization users to an existing user group.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/organization/{organizationId}/user-groups/{groupId}/members

**URI Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| groupId                | UUID              | id of user group                       |
+------------------------+-------------------+----------------------------------------+
| organizationId         | number            | id of organization                     |
+------------------------+-------------------+----------------------------------------+

**Body Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| organizationUserIds    | array of numbers  | List of organization user IDs to add   |
+------------------------+-------------------+----------------------------------------+

Responses 
-------------

+------------------------+--------------------------+
| Name                   | Description              |
+========================+==========================+
| 204 No Content         | successful operation     |
+------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| Organization.ReadWrite | Grants user possibility to read and write organization data                  |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Add single member
^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a/members" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "organizationUserIds": [14]
        }

**Sample response**

HTTP status code: ``204``

No content returned


Add multiple members
^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a/members" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "organizationUserIds": [14, 15, 16]
        }

**Sample response**

HTTP status code: ``204``

No content returned

.. note::
   Users must be members of the organization before they can be added to a group. If a user is already a member of the group, they will be skipped.