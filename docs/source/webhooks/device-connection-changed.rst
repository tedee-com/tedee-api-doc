Device connection changed
====================================

Webhook triggers when device connection state is changed (e.g. after lock is switched on/off, bridge is plugged/unplugged from power source, bridge lost WiFi signal).
This webhook is triggered for lock and bridge devices.

Body 
-------------

+------------------------+------------------------------------------------+-----------------------------------------------------------+
| Name                   | Type                                           | Description                                               |
+========================+================================================+===========================================================+
| data                   | :ref:`Data <data-device-connection-changed>`   | detailed information about what changed                   |
+------------------------+------------------------------------------------+-----------------------------------------------------------+
| event                  | string                                         | event name: "device-connection-changed"                   |
+------------------------+------------------------------------------------+-----------------------------------------------------------+
| timestamp              | datetime                                       | exact time when the webhook was sent to the receiver      |
+------------------------+------------------------------------------------+-----------------------------------------------------------+
| userIdentity           | string                                         | receiver of the webhook (user identity)                   |
+------------------------+------------------------------------------------+-----------------------------------------------------------+

.. _data-device-connection-changed:

Data
-------------

+------------------------+--------------------------------------------+------------------------------------------------+
| Name                   | Type                                       | Description                                    |
+========================+============================================+================================================+
| deviceId               | number                                     | id of the device                               |
+------------------------+--------------------------------------------+------------------------------------------------+
| deviceType             | :doc:`Device type <../enums/device-type>`  | device type                                    |
+------------------------+--------------------------------------------+------------------------------------------------+
| eventTime              | datetime                                   | exact time when the connection change occurred |
+------------------------+--------------------------------------------+------------------------------------------------+
| isConnected            | boolean                                    | current connection state of the device         |
+------------------------+--------------------------------------------+------------------------------------------------+

Examples
-------------

**Sample webhook after device connection changed**

.. code-block:: js

    {   
        "event": "device-connection-changed",
        "timestamp": "2022-11-09T14:15:30.244Z",
        "userIdentity": "<user-identity>",
        "data": {
            "deviceId": 12345,
            "deviceType": 2,
            "eventTime": "2022-11-09T14:15:28.327Z",
            "isConnected": true
        }
    }
