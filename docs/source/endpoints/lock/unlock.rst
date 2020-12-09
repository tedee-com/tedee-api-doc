Unlock your lock
=========================

Endpoint that sends command to unlock your lock by provided id.

``POST |apiUrl|/api/|apiVersion|/my/lock/open``

**Body**

+------------------------+-----------+--------------------------------------------------+
| Name                   | Type      | Description                                      |
+========================+===========+==================================================+
| deviceId               | number    | id of lock                                       |
+------------------------+-----------+--------------------------------------------------+
| openParameter          | number    | Optional. Represents behaviour of unlocking door.| 
|                        |           | Available options: 0 - None, 1 - Auto, 2 - Force |
+------------------------+-----------+--------------------------------------------------+

.. code-block:: sh
    :caption: curl

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/open" -H "accept: application/json" -H "Authorization: Bearer <<access token>>" -d "{\"deviceId\":<<id>>,\"openParameter\":<<parameter>>}"


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