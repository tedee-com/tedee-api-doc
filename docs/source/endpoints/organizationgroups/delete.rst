Delete
=========================

Delete an organization user group.
This endpoint permanently removes a user group from the organization. All device accesses granted to this group will be removed.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/organization/{organizationId}/user-groups/{groupId}

**URI Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| groupId                | UUID              | id of user group to delete             |
+------------------------+-------------------+----------------------------------------+
| organizationId         | number            | id of organization                     |
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

Delete a group
^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/organization/1/user-groups/a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``204``

No content returned

.. note::
   Deleting a user group will remove all device accesses that were granted to this group. Make sure to review group accesses before deletion.