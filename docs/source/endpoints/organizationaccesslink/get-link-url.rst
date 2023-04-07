Get organization access link URL
================================

Show organization access link URL.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/accesslink/{accessLinkId}/url

**URI Parameters**

+----------------+--------+------------------------+
| Name           | Type   | Description            |
+================+========+========================+
| organizationId | number | id of the organization |
+----------------+--------+------------------------+
| accessLinkId   | UUID   | id of the access link  |
+----------------+--------+------------------------+

Responses 
-------------

+---------------+--------+------------------------------------+
| Name          | Type   | Description                        |
+===============+========+====================================+
| 200 OK        | string | successful operation               |
+---------------+--------+------------------------------------+
| 404 Not Found |        | organization access link not found |
+---------------+--------+------------------------------------+

Scopes
-------------

+-----------------------+--------------------------------------------------------------+
| Name                  | Description                                                  |
+=======================+==============================================================+
| AccessLink.Read      | Grants user possibility to view organization access links.   |
+-----------------------+--------------------------------------------------------------+
| AccessLink.ReadWrite | Grants user possibility to manage organization access links. |
+-----------------------+--------------------------------------------------------------+

Examples
-------------

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/accesslink/10df36b5-a06e-4bec-9398-786b0231453a/url" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "url": "https://api.tedee.com/link/0bbDshXmsgjRdDmU2zwYjR1-iQZOcHJL7TuL9NoXOXgC1iF2zVKVKCquVqbEldmkDSspWJKRlH4JcPk.QMzs4Q__"
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }