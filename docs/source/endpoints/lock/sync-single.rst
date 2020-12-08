Sync single lock
=========================

Endpoint that sync single lock by id.

``GET |apiUrl|/api/|apiVersion|/my/lock/<<id>>/sync``

**Parameters**

+------------------------+-----------+---------------------+
| Name                   | Type      | Description         |
+========================+===========+=====================+
| id                     | number    | id of lock to sync  |
+------------------------+-----------+---------------------+

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/<<id>>/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

Responses 
-------------

+------------------------+---------------------------------------------------+--------------------------+
| Name                   | Type                                              | Description              |
+========================+===================================================+==========================+
| 200 OK                 | :doc:`Lock sync <../../datastructures/lock-sync>` | successful operation     |
+------------------------+---------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.Read            | Grants user possibility to read data connected with devices             |
+------------------------+-------------------------------------------------------------------------+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

**Example response**

* HTTP status code - ``200``
* Response body:

.. code-block:: js

    {
        "result":  
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