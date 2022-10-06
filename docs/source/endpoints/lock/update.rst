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
| deviceSettings            | :doc:`Device settings <../../datastructures/device-settings>` (optional)  | device settings to be updated                      |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| name                      | string (optional)                                                         | lock name                                          |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| userSettings              | :doc:`User settings <../../datastructures/user-settings>` (optional)      | settings of current user for that device           |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| timeZone                  | datetime                                                                  | timezone of lock                                   |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
All parameters in this endpoint (except id and revision) are optional. 
This means that specifying a given parameter will update its value. If a given parameter is not specified, its value will not change.

Only the owner or admin can update device settings and name. Guest can only modify user settings.

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

To better understand the idea of updating lock we prepared following examples:

* `Update name of the lock <update.html#update-name>`_
* `Update single device setting <update.html#update-device-setting>`_
* `Update single user setting <update.html#update-user-setting>`_
* `Update location for auto unlock feature <update.html#update-location>`_

.. _update-name:

Update name of the lock
^^^^^^^^^^^^^^^^^^^^^^^^

Example shows how to update name of the lock with id = 1. Only owner or admin can update name of the device.

**Sample Request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "revision": 1,
            "name": "New Name"
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "id": 1,
                "revision": 2,
                "targetDeviceRevision": 1
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }

.. _update-device-setting:

Update single device setting
^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Example shows how to update single device setting (as presented below it is auto lock delay) of the lock with id = 1. Only owner or admin can update name of the device.

**Sample Request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "revision": 1,
            "deviceSettings": {
                "autoLockDelay": 10
            }
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

.. note::
    Take a look at response of that request. TargetDeviceRevision changed as well as revision. 
    It is because changing any device setting will change actual settings on the device.

.. _update-user-setting:

Update single user setting
^^^^^^^^^^^^^^^^^^^^^^^^^^

Example shows how to update single user setting (as presented below it is auto unlock) of the lock with id = 1. This action can be performed by any user with active share to that device.

**Sample Request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "revision": 1,
            "userSettings":{
                "autoUnlockEnabled": true
            }
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "id": 1,
                "revision": 2,
                "targetDeviceRevision": 1
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }

.. _update-location:

Update location for auto unlock feature
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Example shows how to change location of the lock with id = 1. This action can be performed by any user with active share to that device.

.. note::
    Changing location has sense only if user has enabled auto unlock feature.

**Sample Request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "revision": 1,
            "userSettings": {
                "location": {
                    "latitude": 52.24070739746092,
                    "longitude": 21.086990356445305
                }
            }
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "id": 1,
                "revision": 2,
                "targetDeviceRevision": 1
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }