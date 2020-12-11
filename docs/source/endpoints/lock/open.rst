Open
=========================

Send command to open lock by provided id.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/lock/open
    
**Body Parameters**

+------------------------+----------------------+--------------------------------------------------+
| Name                   | Type                 | Description                                      |
+========================+======================+==================================================+
| deviceId               | number               | id of lock                                       |
+------------------------+----------------------+--------------------------------------------------+
| openParameter          | number (optional)    | behaviour of unlocking door.                     | 
|                        |                      | Available options: 0 - None, 1 - Auto, 2 - Force |
+------------------------+----------------------+--------------------------------------------------+

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

Open lock without optional parameter
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/open" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

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


Open lock with Force option
^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/open" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

    {
        "deviceId": 1,
        "openParameter": 2
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
