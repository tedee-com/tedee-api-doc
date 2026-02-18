Get profile
===========

Get profile details of an organization user.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/user/{organizationUserId}

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
| 200 OK                 | OrganizationUserProfile                                                | successful operation                   |
+------------------------+------------------------------------------------------------------------+----------------------------------------+

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

Get profile for organization user 123 in organization 1
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user/123" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"
