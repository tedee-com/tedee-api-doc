Get single
=========================

Get mobile device by provided id.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/mobile/{id}

**URI Parameters**

+------+--------+---------------------------+
| Name | Type   | Description               |
+======+========+===========================+
| id   | UUID   | mobile device identifier  |
+------+--------+---------------------------+

Responses 
-------------

+---------------+-------------------------------------------------------------------+-------------------------+
| Name          | Type                                                              | Description             |
+===============+===================================================================+=========================+
| 200 OK        | :doc:`Registered mobile <../../datastructures/registered-mobile>` | successful operation    |
+---------------+-------------------------------------------------------------------+-------------------------+
| 404 Not Found |                                                                   | mobile device not found |
+---------------+-------------------------------------------------------------------+-------------------------+

Scopes
-------------

+------------------+-----------------------------------------------------+
| Name             | Description                                         |
+==================+=====================================================+
| Mobile.Read      | Grants the ability to view user registered mobiles. |
+------------------+-----------------------------------------------------+
| Mobile.ReadWrite | Grants the ability to manage user mobiles.          |
+------------------+-----------------------------------------------------+

Examples
-------------

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/mobile/7f8da1c1-18fb-4d79-8c19-5add0e7b92b2" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "id": "7f8da1c1-18fb-4d79-8c19-5add0e7b92b2",
                "userIdentity": "00000000-0000-0000-0000-000000000001",
                "name": "iPhone Device",
                "operatingSystem": 0
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }