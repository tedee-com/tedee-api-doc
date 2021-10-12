Add
=========================

Add new mobile device or any other device to user account.
Adding new device (mobile or any other device) is required to make a secure connection with Tedee Lock. As a prequisite certificate should be generated. 

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
            "publicKey": "BL4lFWWQ0SCxYr5aLWaCUA/88XsWkVJdxihYIN0kL9VKhE9jAx8+INXVG/vsen/VEj9YltNMtb1I+qDTUdVqo8c="
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