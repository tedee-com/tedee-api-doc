Remove user
===========

Remove user from organization.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/organization/{organizationId}/user/byorganizationuserid/{organizationUserId}

**URI Parameters**

+------------------------+--------------------+-----------------------------+
| Name                   | Type               | Description                 |
+========================+====================+=============================+
| organizationId         | number             | id of organization          |
+------------------------+--------------------+-----------------------------+
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

Remove organization user 123 from organization 1
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/organization/1/user/byorganizationuserid/123" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"
