Sync single lock
=========================

Endpoint that sync single lock by id.

``GET |apiUrl|/api/|apiVersion|/my/lock/<<deviceId>>/sync``

**Parameters**

+------------------------+-----------+---------------------+
| Name                   | Type      | Description         |
+========================+===========+=====================+
| DeviceId               | number    | id of lock to sync  |
+------------------------+-----------+---------------------+

Swagger Documentation : `Click <|apiUrl|/swagger/index.html#/Lock/GetSingleLockForSync>`_.

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/<<deviceId>>/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Data structure:** :doc:`Lock <../../datastructures/lock-sync>`

**Example response**

* HTTP status code - ``200``
* Response body:

.. code-block:: js

    {
        "result":  "result":  
        {
            "id": 1,
            "isConnected": true,
            "lockProperties": {
                "state": 3,
                "isCharging": false,
                "batteryLevel": 54
            }
        }
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }