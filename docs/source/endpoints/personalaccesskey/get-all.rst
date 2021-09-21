Get all
=========================

Get a list of all currently logged user personal access keys.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/personalaccesskey

Responses 
-------------

+------------------------+--------------------------------------------------------+--------------------------+
| Name                   | Type                                                   | Description              |
+========================+========================================================+==========================+
| 200 OK                 | :doc:`Lock <../../datastructures/personalaccesskey>` []| successful operation     |
+------------------------+--------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Account.Read           | Grants user possibility to read data connected with account             |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Get all personal access keys of currently logged user 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/personalaccesskey" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": [
            {
                "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                "name": "SomeExampleName",
                "prefix": "gdQAs5",
                "scopes": [
                    "Device.Read",
                    "Devie.Write",
                ],
                "validTo": "2021-09-10T12:45:48.871Z"
            }
        ]
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
