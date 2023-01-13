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

Then after you have succesfully downloaded locks data you can use endpoint :doc:`Sync locks <../endpoints/lock/sync>` to periodically refresh current state 
of user locks like battery level, connection state, and lock position.

.. note::
    If your integration uses OAuth authentication (you have a client id issued for your application by Tedee), 
    we strongly recommend using webhooks instead of periodically sending requests to the Tedee API to refresh devices.
    More information: :doc:`Webhooks overview <../webhooks/overview>`.

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
                    "batteryLevel": 54,
                    "stateChangeResult": 0,
                    "lastStateChangedDate": "2021-04-26T06:02:04.197Z"
                }
            },            
            {
                "id": 2,
                "isConnected": true,
                "lockProperties": {
                    "state": 2,
                    "isCharging": true,
                    "batteryLevel": 80,
                    "stateChangeResult": 0,
                    "lastStateChangedDate": "2021-04-26T06:02:04.197Z"
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