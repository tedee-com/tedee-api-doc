Unlock
=========================

Send command to unlock the device by provided id.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/lock/{id}/operation/unlock?mode={mode}
    
**URI Parameters**

+------------------------+---------------------------------------------------------+-----------------------------+
| Name                   | Type                                                    | Description                 |
+========================+=========================================================+=============================+
| id                     | number                                                  | id of lock                  |
+------------------------+---------------------------------------------------------+-----------------------------+
| mode                   | :doc:`Unlock mode <../../enums/unlock-mode>` (optional) | behaviour of unlocking door | 
+------------------------+---------------------------------------------------------+-----------------------------+

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

Unlock without optional parameter
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/1/operation/unlock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" 

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


Unlock with Force mode
^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/1/operation/unlock?mode=2" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" 

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


Unlock without auto pull spring
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/1/operation/unlock?mode=3" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" 

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


Unlock or pull spring
^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/1/operation/unlock?mode=4" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" 

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
