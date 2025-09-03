Remove members
=========================

Remove users from an organization user group.
This endpoint allows you to remove one or more users from an existing user group.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/organization/{organizationId}/user-groups/{groupId}/members

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
| organizationUserIds    | array of numbers  | List of organization user IDs to remove|
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

Remove single member
^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a/members" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "organizationUserIds": [12]
        }

**Sample response**

HTTP status code: ``204``

No content returned


Remove multiple members
^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a/members" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "organizationUserIds": [11, 12, 13]
        }

**Sample response**

HTTP status code: ``204``

No content returned

.. note::
   Removing users from a group does not remove their individual device accesses. Only accesses granted through the group membership are affected.