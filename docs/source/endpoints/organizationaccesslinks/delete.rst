Delete organization access link
===============================

Deletes the organization access link.

.. code-block:: sh

    PUT |apiUrl|/api/|apiVersion|/organization/{organizationId}/accessLink/{accessLinkId}

**URI Parameters**

+--------------+--------+-----------------------+
| Name         | Type   | Description           |
+==============+========+=======================+
| id           | number | id of the lock        |
+--------------+--------+-----------------------+
| accessLinkId | UUID   | id of the access link |
+--------------+--------+-----------------------+

Responses 
-------------

+----------------+-----------------------+
| Name           | Description           |
+================+=======================+
| 204 No Content | successful operation  |
+----------------+-----------------------+
| 404 Not Found  | access link not found |
+----------------+-----------------------+

Scopes
-------------

+-----------------------+-------------------------------------------------------------+
| Name                  | Description                                                 |
+=======================+=============================================================+
| AccessLinks.ReadWrite | Grants user possibility to manage organization access links |
+-----------------------+-------------------------------------------------------------+

Examples
-------------

Delete organization access link
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/organization/1/accesslink/10df36b5-a06e-4bec-9398-786b0231453a" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {   
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }