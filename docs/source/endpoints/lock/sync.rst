Sync locks
=========================

Endpoint that sync all users locks states

.. warning::

    You shouldn't run this endpoint more than once every 10 seconds.


``GET |apiUrl|/api/|apiVersion|/my/lock/sync``

Swagger Documentation : `Click <|apiUrl|/swagger/index.html#/Lock/GetLocksForSync>`_.

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Data structure:** :doc:`Lock sync <../../datastructures/lock-sync>`

**Example response**

* HTTP status code - ``200``
* Response body:

.. code-block:: js

    {
        "result":  "result":  
        [
            {
                "id": 1,
                "isConnected": true,
                "lockProperties": {
                    "state": 3,
                    "isCharging": false,
                    "batteryLevel": 54
                }
            }
        ],
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }