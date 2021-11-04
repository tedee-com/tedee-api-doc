Get all
=========================

Show mobile devices registered on user account.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/mobile


Responses 
-------------

+--------+-----------------------------------------------------------------------+----------------------+
| Name   | Type                                                                  | Description          |
+========+=======================================================================+======================+
| 200 OK | :doc:`Registered mobiles <../../datastructures/registered-mobile>` [] | successful operation |
+--------+-----------------------------------------------------------------------+----------------------+

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

    curl -X GET "|apiUrl|/api/|apiVersion|/my/mobile" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": [
                {
                "id": "7f8da1c1-18fb-4d79-8c19-5add0e7b92b2",
                "userIdentity": "00000000-0000-0000-0000-000000000001",
                "name": "iPhone Device",
                "operatingSystem": 0
                },
                {
                "id": "ed9b5e77-5c1e-4d2d-8435-1f2a352f6165",
                "userIdentity": "00000000-0000-0000-0000-000000000001",
                "name": "Android Device",
                "operatingSystem": 1
                },
                {
                "id": "35de00bc-a889-4e3d-8fd4-79114e7afa90",
                "userIdentity": "00000000-0000-0000-0000-000000000001",
                "name": "Integration Device",
                "operatingSystem": 3
                }
            ]
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }