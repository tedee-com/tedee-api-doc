Get all
=======

Get all users in an organization.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/user?Filters.Text={text}&Filters.UserTypes={userType}&Filters.IncludePendingUsers={includePending}

**URI Parameters**

+-----------------------------+--------------------+--------------------------------------------------------------+
| Name                        | Type               | Description                                                  |
+=============================+====================+==============================================================+
| organizationId              | number             | id of organization                                           |
+-----------------------------+--------------------+--------------------------------------------------------------+
| Filters.Text                | string (optional)  | Search by display name or email                              |
+-----------------------------+--------------------+--------------------------------------------------------------+
| Filters.UserTypes           | number (optional)  | Filter by user type (0 Admin, 1 Other, 2 Owner)              |
+-----------------------------+--------------------+--------------------------------------------------------------+
| Filters.IncludePendingUsers | bool (optional)    | Include invited users that are still pending                 |
+-----------------------------+--------------------+--------------------------------------------------------------+

Scopes
------

+------------------------+--------------------------------------------------------------+
| Name                   | Description                                                  |
+========================+==============================================================+
| Organization.Read      | Grants user possibility to read organization data            |
+------------------------+--------------------------------------------------------------+
| Organization.ReadWrite | Grants user possibility to read and write organization data  |
+------------------------+--------------------------------------------------------------+

Examples
--------

Get all users from organization with id 1
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"
