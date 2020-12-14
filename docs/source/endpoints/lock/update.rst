Update
=========================

Update lock.

.. code-block:: sh

    PATCH |apiUrl|/api/|apiVersion|/my/lock

**Body Parameters**

+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| Name                      | Type                                                                      | Description                                        |
+===========================+===========================================================================+====================================================+
| id                        | number                                                                    | id of lock                                         |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| revision                  | number                                                                    | current lock information and settings in database  |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| autoUnlockEnabled         | boolean (optional)                                                        | if auto unlock is enabled                          |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| autoUnlockConfirmEnabled  | boolean (optional)                                                        | if auto unlock confirmation is enabled             |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| autoUnlockRangeIn         | number (optional)                                                         | value of the in zone                               |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| autoUnlockRangeOut        | number (optional)                                                         | value of the out zone                              |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| autoUnlockTimeout         | number (optional)                                                         | value of auto unlock timeout                       |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| deviceSettings            | :doc:`Device settings <../../datastructures/device-settings>` (optional)  | device settings object                             |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| location                  | :doc:`Location <../../datastructures/location>` (optional)                | location object                                    |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| name                      | string (optional)                                                         | lock name                                          |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+

Responses 
-------------

+------------------------+-----------------------------------------------------------+----------------------------------------------------+
| Name                   | Type                                                      | Description                                        |
+========================+===========================================================+====================================================+
| 200 OK                 | :doc:`Lock updated <../../datastructures/lock-updated>`   | successful operation                               |
+------------------------+-----------------------------------------------------------+----------------------------------------------------+
| 409 Conflict           |                                                           | revision in request is different than in database  |
+------------------------+-----------------------------------------------------------+----------------------------------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Update lock
^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "revision": 1,
            "name": "Test",
            "location": {
                "latitude": 1,
                "longitude": 1
            },
            "deviceSettings": {
                "autoLockEnabled": true,
                "autoLockDelay": 10,
                "autoLockImplicitEnabled": true,
                "autoLockImplicitDelay": 10,
                "pullSpringEnabled": true,
                "pullSpringDuration": 10,
                "autoPullSpringEnabled": true,
                "postponedLockEnabled": true,
                "postponedLockDelay": 10,
                "buttonLockEnabled": true,
                "buttonUnlockEnabled": true
            },
            "autoUnlockEnabled": true,
            "autoUnlockConfirmEnabled": true,
            "autoUnlockRangeIn": 100,
            "autoUnlockRangeOut": 100,
            "autoUnlockTimeout": 30
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "id": 1,
                "revision": 2,
                "targetDeviceRevision": 2
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }
