How to get and sync locks
=========================

For the purpose of this tutorial, let's assume that you possess one or more locks, and it is essential to retrieve their data initially and subsequently synchronize their states at regular intervals.

Get user locks
---------------------

The first step in managing your locks is to retrieve the complete list of locks assigned to your account.
To do this, use the :doc:`Get all locks <../endpoints/lock/get-all>` endpoint.
This endpoint will return detailed information for each lock associated with the currently logged-in user's account, providing a comprehensive overview of all your locks and their current statuses.

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


Sync user locks
-----------------------

After receiving the locks, you should switch to using the :doc:`Sync locks <../endpoints/lock/sync>` endpoint to periodically update the status of the locks and keep your application data current.

.. note::
    If your integration employs OAuth authentication, and you possess a client ID issued for your application by Tedee, we highly advise utilizing webhooks as opposed to recurrently sending requests to the Tedee API for device refresh.
    This approach not only optimizes the performance of your application but also ensures a more efficient use of resources.
    
    More information: :doc:`Webhooks overview <../webhooks/overview>`.
    
The :doc:`Sync locks <../endpoints/lock/sync>` and :doc:`Sync single <../endpoints/lock/sync-single>` endpoints are used in different scenarios.
The :doc:`Sync locks <../endpoints/lock/sync>` endpoint is designed to refresh the current state of all locks assigned to the user, updating the battery level, connection state, and lock position of each lock to reflect their current statuses.
Conversely, the :doc:`Sync single <../endpoints/lock/sync-single>` endpoint targets a specific lock, updating only its current state.

Which endpoint should I use?
^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Use the :doc:`Sync locks <../endpoints/lock/sync>` endpoint when you need to update the status of all locks associated with the user's account. This is especially useful when the user initially logs into the application or after a significant period of inactivity, to ensure that the application data is current and accurate.

Use the :doc:`Sync single <../endpoints/lock/sync-single>` endpoint when you need to update the status of a specific lock, perhaps after a user action on that particular lock. This endpoint is more efficient in scenarios where only one lock's status needs updating, as it minimizes data transfer and processing time.

.. warning::
    Please note that if you receive a webhook notification indicating a change in the status of a lock, there is no need to use the 'Sync' endpoints as the update data will be included in the webhook notification.    

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
                },
                "revision": 1
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
                },
                "revision": 1
            }
        ],
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }

.. warning::

    You shouldn't run sync endpoint more than once every 10 seconds.

.. note::
    Avoid hardcoding the lock ID because it changes every time a user adds a lock to their account.
    If it is absolutely necessary to hardcode an identifier, use the device Serial Number as it remains unchanged and unique to each lock.