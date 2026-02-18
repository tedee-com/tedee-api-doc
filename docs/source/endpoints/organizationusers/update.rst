Update profile
==============

Update profile details of an organization user.

.. code-block:: sh

    PUT |apiUrl|/api/|apiVersion|/organization/{organizationId}/user/byorganizationuserid/{organizationUserId}

**URI Parameters**

+------------------------+--------------------+-----------------------------+
| Name                   | Type               | Description                 |
+========================+====================+=============================+
| organizationId         | number             | id of organization          |
+------------------------+--------------------+-----------------------------+
| organizationUserId     | number             | id of organization user     |
+------------------------+--------------------+-----------------------------+

**Body Parameters**

+------------------------+--------------------+-----------------------------+
| Name                   | Type               | Description                 |
+========================+====================+=============================+
| displayName            | string             | New user display name       |
+------------------------+--------------------+-----------------------------+

Responses 
-------------

+------------------------+------------------------------------------------------------------------+----------------------------------------+
| Name                   | Type                                                                   | Description                            |
+========================+========================================================================+========================================+
| 200 OK                 | object                                                                 | successful operation                   |
+------------------------+------------------------------------------------------------------------+----------------------------------------+

Scopes
------

+------------------------+--------------------------------------------------------------+
| Name                   | Description                                                  |
+========================+==============================================================+
| Organization.ReadWrite | Grants user possibility to read and write organization data  |
+------------------------+--------------------------------------------------------------+

Examples
--------

Update display name for organization user 123 in organization 1
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

.. code-block:: sh

    curl -X PUT "|apiUrl|/api/|apiVersion|/organization/1/user/byorganizationuserid/123" \
      -H "accept: application/json" \
      -H "Content-Type: application/json" \
      -H "Authorization: Bearer <<access token>>" \
      -d "{\"displayName\":\"John A. Doe\"}"
