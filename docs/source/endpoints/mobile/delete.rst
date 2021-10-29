Delete
=========================

Remove mobile device from user account.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/my/mobile/{id}

**URI Parameters**

+------+--------+---------------------------+
| Name | Type   | Description               |
+======+========+===========================+
| id   | UUID   | mobile device identifier  |
+------+--------+---------------------------+

Responses 
-------------

+----------------+----------------------+
| Name           | Description          |
+================+======================+
| 204 No Content | successful operation |
+----------------+----------------------+

Scopes
-------------

+------------------+------------------------------------------------------------+
| Name             | Description                                                |
+==================+============================================================+
| Mobile.ReadWrite | Grants the ability to manage user mobile or other devices. |
+------------------+------------------------------------------------------------+

Examples
-------------

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/mobile/7f8da1c1-18fb-4d79-8c19-5add0e7b92b2" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }