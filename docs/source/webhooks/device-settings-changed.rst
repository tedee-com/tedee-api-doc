Device settings changed
====================================

Webhook triggers when device settings are changed. Field "Revision" describes the latest settings version. 
As the settings which is changed the most frequently, "Name" setting is sent too.
This webhook is triggered for all devices (lock/bridge/keypad).

Body 
-------------

+------------------------+------------------------------------------------+-----------------------------------------------------------+
| Name                   | Type                                           | Description                                               |
+========================+================================================+===========================================================+
| data                   | :ref:`Data <data-device-settings-changed>`     | detailed information about what changed                   |
+------------------------+------------------------------------------------+-----------------------------------------------------------+
| event                  | string                                         | event name: "device-settings-changed"                     |
+------------------------+------------------------------------------------+-----------------------------------------------------------+
| timestamp              | datetime                                       | exact time when the webhook was sent to the receiver      |
+------------------------+------------------------------------------------+-----------------------------------------------------------+
| userIdentity           | string                                         | receiver of the webhook (user identity)                   |
+------------------------+------------------------------------------------+-----------------------------------------------------------+

.. _data-device-settings-changed:

Data
-------------

+------------------------+--------------------------------------------+--------------------------------------------------+
| Name                   | Type                                       | Description                                      |
+========================+============================================+==================================================+
| deviceId               | number                                     | id of the device                                 |
+------------------------+--------------------------------------------+--------------------------------------------------+
| deviceType             | :doc:`Device type <../enums/device-type>`  | device type                                      |
+------------------------+--------------------------------------------+--------------------------------------------------+
| eventTime              | datetime                                   | exact time when the device settings are changed  |
+------------------------+--------------------------------------------+--------------------------------------------------+
| name                   | string                                     | current device name                              |
+------------------------+--------------------------------------------+--------------------------------------------------+
| revision               | number                                     | current device settings version                  |
+------------------------+--------------------------------------------+--------------------------------------------------+

Examples
-------------

**Sample webhook after device settings changed**

.. code-block:: js

    {   
        "event": "device-settings-changed",
        "timestamp": "2022-11-09T14:15:30.244Z",
        "userIdentity": "<user-identity>",
        "data": {
            "deviceId": 12345,
            "deviceType": 2,
            "eventTime": "2022-11-09T14:15:28.327Z",
            "name": "Home",
            "revision": 12
        }
    }
