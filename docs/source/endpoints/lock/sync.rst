Sync
=========================

Sync all users locks states.

.. warning::

    You shouldn't run this endpoint more than once every 10 seconds.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/lock/sync

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

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

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
                    "batteryLevel": 54
                }
            }
        ],
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
