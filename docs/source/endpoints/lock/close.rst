Close
=========================

Endpoint that sends close command to your lock by provided id.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/lock/close

Request Body
-------------

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

Simple close request
^^^^^^^^^^^^^^^^^^^^

Sample Request
""""""""""""""

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/close" -H "accept: application/json" -H "Authorization: Bearer <<access token>>" -d "<<request body>>"

Sample Request Body
""""""""""""""""""""
.. code-block:: js

    {
        "deviceId": 1
    }

Sample Response
""""""""""""""""""""
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