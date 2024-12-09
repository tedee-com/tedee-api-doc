Lock status changed
====================================

Webhook triggers when device status changes (e.g. lock was locked/unlocked). 
This webhook is triggered only for lock device.
Webhooks are not sent for intermediate states: locking, unlocking, pulling.

Body 
-------------

+------------------------+---------------------------------------------+-----------------------------------------------------------+
| Name                   | Type                                        | Description                                               |
+========================+=============================================+===========================================================+
| data                   | :ref:`Data <data-lock-status-changed>`      | detailed information about what changed                   |
+------------------------+---------------------------------------------+-----------------------------------------------------------+
| event                  | string                                      | event name: "lock-status-changed"                         |
+------------------------+---------------------------------------------+-----------------------------------------------------------+
| timestamp              | datetime                                    | exact time when the webhook was sent to the receiver      |
+------------------------+---------------------------------------------+-----------------------------------------------------------+
| userIdentity           | string                                      | receiver of the webhook (user identity)                   |
+------------------------+---------------------------------------------+-----------------------------------------------------------+

.. _data-lock-status-changed:

Data
-------------

+------------------------+--------------------------------------------+------------------------------------------------+
| Name                   | Type                                       | Description                                    |
+========================+============================================+================================================+
| deviceId               | number                                     | id of the lock device                          |
+------------------------+--------------------------------------------+------------------------------------------------+
| deviceType             | :doc:`Device type <../enums/device-type>`  | device type                                    |
+------------------------+--------------------------------------------+------------------------------------------------+
| doorState              | :doc:`Door state <../enums/door-state>`    | current state of the door sensor device        |
+------------------------+--------------------------------------------+------------------------------------------------+
| eventTime              | datetime                                   | exact time when the state change occurred      |
+------------------------+--------------------------------------------+------------------------------------------------+
| state                  | :doc:`Lock state <../enums/lock-state>`    | current state of the lock device               |
+------------------------+--------------------------------------------+------------------------------------------------+

Examples
-------------

**Sample webhook after lock status changed**

.. code-block:: js

    {   
        "event": "lock-status-changed",
        "timestamp": "2022-11-09T14:15:30.244Z",
        "userIdentity": "<user-identity>",
        "data": {
            "deviceId": 12345,
            "deviceType": 2,
            "doorState": 3,
            "eventTime": "2022-11-09T14:15:28.327Z",
            "state": 6
        }
    }

.. note::
    To get doorState values different than 0, lock must be paired with door sensor. 