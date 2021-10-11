Add
=========================

Add new mobile device or any other device to user account.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/mobile

**Body Parameters**

+--------------------+---------------------------------------------------------+----------------------------------------------------------------+
| Name               | Type                                                    | Description                                                    |
+====================+=========================================================+================================================================+
| name               | string                                                  | name of the resource                                           |
+--------------------+---------------+-----------------------------------------+----------------------------------------------------------------+
| operatingSystem    | :doc:`Operating system <../../enums/operating-system>`  | represents operating system                                    |
+--------------------+---------------+-----------------------------------------+----------------------------------------------------------------+
| publicKey          | string                                                  | generated public key                                           |
+--------------------+---------------------------------------------------------+----------------------------------------------------------------+

Responses 
-------------

+------------------------+------------------------------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                                                     | Description              |
+========================+==========================================================================================+==========================+
| 201 Created            | :doc:`Mobile identifier <../../datastructures/mobile-identifier>`                        | successful operation     |
+------------------------+------------------------------------------------------------------------------------------+--------------------------+

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

    curl -X POST "|apiUrl|/api/|apiVersion|/my/mobile" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "name": "integrationDevice",
            "operatingSystem": 2,
            "publicKey": "-----BEGIN PUBLIC KEY-----
                MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCqGKukO1De7zhZj6+H0qtjTkVxwTCpvKe4eCZ0
                FPqri0cb2JZfXJ/DgYSF6vUpwmJG8wVQZKjeGcjDOL5UlsuusFncCzWBQ7RKNUSesmQRMSGkVb1/
                3j+skZ6UtW+5u09lHNsj6tQ51s1SPrCBkedbNf0Tp0GbMJDyR4e9T04ZZwIDAQAB
                -----END PUBLIC KEY-----"
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "result": {
                "id": 123,
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }