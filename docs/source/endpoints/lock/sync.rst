Sync
=========================

Sync all users locks states.

.. warning::

    You shouldn't run this endpoint more than once every 20 seconds.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/lock/sync?id={lockId1}&id={lockId2}

**URI Parameters**

+------------------------+---------------------+----------------------------------------+
| Name                   | Type                | Description                            |
+========================+=====================+========================================+
| id                     | int[] (optional)    | array with lock ids                    |
+------------------------+---------------------+----------------------------------------+

Responses 
-------------

+------------------------+------------------------------------------------------+--------------------------+
| Name                   | Type                                                 | Description              |
+========================+======================================================+==========================+
| 200 OK                 | :doc:`Lock sync <../../datastructures/lock-sync>` [] | successful operation     |
+------------------------+------------------------------------------------------+--------------------------+

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

Sync all users locks
^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response for lock connected to bridge**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": [
            {
                "id": 1,
                "isConnected": true,
                "lockProperties": {
                    "state": 3,
                    "isCharging": false,
                    "batteryLevel": 54,
                    "stateChangeResult": 0,
                    "lastStateChangedDate": "2021-04-26T06:02:04.197Z"
                }
            }
        ],
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }


**Sample response for lock disconnected from bridge**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": [
            {
                "id": 1,
                "isConnected": false,
                "lockProperties": null
            }
        ],
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
