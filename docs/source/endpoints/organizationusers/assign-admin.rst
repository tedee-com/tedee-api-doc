Assign admin role
=================

Assign admin role to an organization user.

.. code-block:: sh

    PUT |apiUrl|/api/|apiVersion|/organization/{organizationId}/assignadmin

**URI Parameters**

+------------------------+--------------------+-----------------------------+
| Name                   | Type               | Description                 |
+========================+====================+=============================+
| organizationId         | number             | id of organization          |
+------------------------+--------------------+-----------------------------+

**Body Parameters**

+------------------------+--------------------+-----------------------------+
| Name                   | Type               | Description                 |
+========================+====================+=============================+
| organizationUserId     | number             | id of organization user     |
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

Assign admin role to organization user 123 in organization 1
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

.. code-block:: sh

    curl -X PUT "|apiUrl|/api/|apiVersion|/organization/1/assignadmin" \
      -H "accept: application/json" \
      -H "Content-Type: application/json" \
      -H "Authorization: Bearer <<access token>>" \
      -d "{\"organizationUserId\":123}"
