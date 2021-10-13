Show mobiles
=========================

Show registered mobile devices in Tedee Cloud.

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
                "id": 123,
                "userIdentity": "00000000-0000-0000-0000-000000000001",
                "name": "iPhone Device",
                "operatingSystem": 0
                },
                {
                "id": 456,
                "userIdentity": "00000000-0000-0000-0000-000000000002",
                "name": "Android Device",
                "operatingSystem": 1
                },
                {
                "id": 789,
                "userIdentity": "00000000-0000-0000-0000-000000000003",
                "name": "Integration Device",
                "operatingSystem": 3
                }
            ]
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }