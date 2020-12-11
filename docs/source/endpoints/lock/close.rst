Close
=========================

Send command to close lock by provided id.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/lock/close

**Body Parameters**

+------------------------+-----------+--------------------------------------------------+
| Name                   | Type      | Description                                      |
+========================+===========+==================================================+
| deviceId               | number    | id of lock                                       |
+------------------------+-----------+--------------------------------------------------+

Responses 
-------------

+------------------------+-----------------------------------------------------------------------+-----------------------------------------------------------+
| Name                   | Type                                                                  | Description                                               |
+========================+=======================================================================+===========================================================+
| 200 OK                 | :doc:`Execute command response <../../datastructures/execute-command>`| successful operation                                      |
+------------------------+-----------------------------------------------------------------------+-----------------------------------------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Lock.Operate           | Grants user possibility to operate locks                                |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Close lock
^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/close" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

    {
        "deviceId": 1
    }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "operationId": "1577833200000"
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
