How to get and sync locks
=========================

For this tutorial let's consider that you have one or more locks and you need to get their data and then sync their states periodically.

Get user locks
---------------------

First thing that you need to do is to use endpoint :doc:`Get all locks <../endpoints/lock/get-all>`. This endpoint will return full data of all currently logged user locks.

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


Sync user locks
-----------------------

Then after you have succesfully downloaded locks data you can use endpoint :doc:`Sync locks <../endpoints/lock/sync>` to periodicalu refresh current state 
of user locks like battery level, connection state, and lock position.

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

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
            },            
            {
                "id": 2,
                "isConnected": true,
                "lockProperties": {
                    "state": 2,
                    "isCharging": true,
                    "batteryLevel": 80
                }
            }
        ],
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }

.. warning::

    You shouldn't run sync endpoint more than once every 10 seconds.

.. note::
    Do not hardcode lock Id. It will change everytime user add the lock to account.
    If you must hardcode then use device Serial Number which will not change.