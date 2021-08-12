Pull spring 
=========================

Send command to pull spring the device by provided id.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/lock/{id}/operation/pull

**URI Parameters**

+------------------------+-----------+--------------------------------------------------+
| Name                   | Type      | Description                                      |
+========================+===========+==================================================+
| id                     | number    | id of lock                                       |
+------------------------+-----------+--------------------------------------------------+

Responses 
-------------

+------------------------+-----------------------------------------------------------------------+-----------------------------------------------------------+
| Name                   | Type                                                                  | Description                                               |
+========================+=======================================================================+===========================================================+
| 202 Accepted           | :doc:`Execute command response <../../datastructures/execute-command>`| successful operation                                      |
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

Pull spring
^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/1/operation/pull" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" 

**Sample response**

HTTP status code: ``202``

.. code-block:: js

    {
        "result": {
            "operationId": "1577833200000",
            "lastStateChangedDate": "2021-04-26T05:53:57.423Z"
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 202
    }
