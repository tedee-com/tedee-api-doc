Lock your lock
=========================

Endpoint that sends lock command to your lock by provided id.

``POST |apiUrl|/api/|apiVersion|/my/lock/close``

**Body**

+------------------------+-----------+--------------------------------------------------+
| Name                   | Type      | Description                                      |
+========================+===========+==================================================+
| deviceId               | number    | id of lock                                       |
+------------------------+-----------+--------------------------------------------------+

.. code-block:: sh
    :caption: curl

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/close" -H "accept: application/json" -H "Authorization: Bearer <<access token>>" -d "{\"deviceId\":<<id>>}"


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

**Example response**

* HTTP status code - ``200``
* Response body:

    .. code-block:: js

        {
            "result": {
                "operationId": "1577833200000"
            },
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }