How to use state from your door sensor
======================================

If you have a lock paired with a door sensor, you can use the door state in several scenarios. 
In this tutorial, we will walk through the scenarios of checking the state of the door, receiving the current door state when it changes, automatically locking the lock after the door is closed, and receiving an alert if the door has been open too long.

.. note::
    You should pair your lock with a door sensor before using the following features.

You can use the door sensor for the following actions:

* :ref:`Check the door state <check-door-state>`
* :ref:`Receive the current door state when it changes <receive-door-state>`
* :ref:`Automatically lock the lock after the door is closed <auto-lock-after-door-closed>`
* :ref:`Receive an alert if the door has been open too long <door-open-too-long-alert>`

.. _check-door-state:

Check the door state
--------------------

You can check the state of the door at any time using the Tedee API. 
The door state is always returned together with the state of the lock that is paired with the door sensor. 
All endpoints that return the lock state also return the door state in the :doc:`doorState <../enums/door-state>` property.

You can use the following endpoints to check the current state of the door for a specific lock:

* :doc:`Sync single lock <../endpoints/lock/sync-single>`
* :doc:`Get single lock <../endpoints/lock/get-single>`

**Sample request for lock with id = 123**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/123/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "id": 123,
            "isConnected": true,
            "lockProperties": {
                "state": 6,
                "doorState": 3,
                "isCharging": false,
                "batteryLevel": 54,
                "stateChangeResult": 0,
                "lastStateChangedDate": "2021-04-26T06:02:04.197Z"
            },
            "revision": 1
        }
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }

The state of the door is returned in the :doc:`doorState <../enums/door-state>` property in the :doc:`lockProperties <../datastructures/lock-properties>` object.

.. _receive-door-state:

Receive the current door state when it changes
----------------------------------------------
From an integration perspective, it is crucial to keep device information up to date. 
:doc:`Webhook <../webhooks/overview>` notifications solve this problem by automatically sending updates when changes happen. This eliminates the need to periodically send requests to the Tedee API to refresh devices. 
We use webhook notifications to send information about door status changes. 

When the state of the door changes (for example, when the door is opened or closed), the :doc:`Lock status changed <../webhooks/lock-status-changed>` webhook will be send. 
The current state of the door is send in the :doc:`doorState <../enums/door-state>` property in this webhook. 
Since this is the same webhook that is sent when the lock status changes, it also contains the current state of the lock that is paired with the door sensor.

**Sample webhook after door state changed**

.. code-block:: js

    {   
        "event": "lock-status-changed",
        "timestamp": "2024-12-15T14:15:30.244Z",
        "userIdentity": "<user-identity>",
        "data": {
            "deviceId": 12345,
            "deviceType": 2,
            "doorState": 3,
            "eventTime": "2024-12-15T14:15:29.122Z",
            "state": 6
        }
    }

.. _auto-lock-after-door-closed:

Automatically lock the lock after the door is closed
----------------------------------------------------
You can configure the lock to automatically lock after the door is closed. 
To enable this option, you need to set the **autoLockAfterDoorClosedEnabled** :doc:`device setting <../datastructures/device-settings>` to **true** in the :doc:`Update lock <../endpoints/lock/update>` endpoint. 

If this option is enabled, the lock will be automatically locked when the door state changes to closed.

.. _door-open-too-long-alert:

Receive an alert if the door has been open too long
---------------------------------------------------
You can configure the lock to send notifications to Tedee mobile apps if the door is left open for longer than a specified period of time. 
This notification is sent to all  administrators of the lock that is paired with the door sensor. 

To enable this option, you need to set the **openDoorAlertEnabled** :doc:`device setting <../datastructures/device-settings>` to **true** in the :doc:`Update lock <../endpoints/lock/update>` endpoint. 
The time after which notification about door opened too long will be sent is specified in the **openDoorAlertThreshold** setting.
