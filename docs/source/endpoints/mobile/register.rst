Register
=========================

Register mobile device to user account endpoint. User is required to register all devices which wants to establish 
connection with Tedee devices. When registering a key pair is generated on the user's access device.
The auth pair key is necessary to establish secure PTLS session (Secure Bluetooth Communication) with Tedee device.

.. note::
    Auth pair key generation is user responsibility.

.. warning::
    Remember to keep private auth pair ECDSA private key only in mobile device.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/mobile

**Body Parameters**

+-----------------+--------------------------------------------------------+--------------------------------------+
| Name            | Type                                                   | Description                          |
+=================+========================================================+======================================+
| name            | string                                                 | name of the resource                 |
+-----------------+--------------------------------------------------------+--------------------------------------+
| operatingSystem | :doc:`Operating system <../../enums/operating-system>` | represents operating system          |
+-----------------+--------------------------------------------------------+--------------------------------------+
| publicKey       | string                                                 | generated auth pair ECDSA public key |
+-----------------+--------------------------------------------------------+--------------------------------------+

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
            "operatingSystem": 3,
            "publicKey": "BL4lFWWQ0SCxYr5aLWaCUA/88XsWkVJdxihYIN0kL9VKhE9jAx8+INXVG/vsen/VEj9YltNMtb1I+qDTUdVqo8c="
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "result": {
                "id": "7f8da1c1-18fb-4d79-8c19-5add0e7b92b2",
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }