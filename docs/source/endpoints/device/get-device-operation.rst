Get device operation
====================================

Get operation status by it's id

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/device/operation/{operationId}

Responses 
-------------

+------------------------+-------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                              | Description              |
+========================+===================================================================+==========================+
| 200 OK                 | :doc:`Device Operation <../../datastructures/device-operation>`   | successful operation     |
+------------------------+-------------------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.Read            | Grants user possibility to read data connected with devices             |
+------------------------+-------------------------------------------------------------------------+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Get operation status by id
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/device/operation/1619078520230" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "deviceId" : 1,
            "operationId" : "1619078520230",
            "result" : 0,
            "status" : "COMPLETED"
            "type" : 1
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
