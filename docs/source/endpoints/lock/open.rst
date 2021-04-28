Open
=========================

Send command to open lock by provided id.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/lock/open
    
**Body Parameters**

+------------------------+---------------------------------------------------+-----------------------------+
| Name                   | Type                                              | Description                 |
+========================+===================================================+=============================+
| deviceId               | number                                            | id of lock                  |
+------------------------+---------------------------------------------------+-----------------------------+
| openParameter          | :doc:`Open parameter <../../enums/open-parameter>`| behaviour of unlocking door | 
+------------------------+---------------------------------------------------+-----------------------------+

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
