Switch device settings
----------------------

+------------------+--------------------------------------------------------+-------------------------------------+
| Name             | Type                                                   | Description                         |
+==================+========================================================+=====================================+
| mode             | :doc:`Switch mode <../enums/switch-mode>`              | operating mode of the switch        |
+------------------+--------------------------------------------------------+-------------------------------------+
| openActionOutput | :doc:`Switch output <../enums/switch-output>`          | output triggered by the open action |
+------------------+--------------------------------------------------------+-------------------------------------+
| output1          | :doc:`Switch output settings <switch-device-settings>` | settings of the first output        |
+------------------+--------------------------------------------------------+-------------------------------------+
| output2          | :doc:`Switch output settings <switch-device-settings>` | settings of the second output       |
+------------------+--------------------------------------------------------+-------------------------------------+

.. note::
    Only a switch in ``DryContact`` mode can be paired with a lock, and a switch paired with a lock cannot be changed to ``Gate`` mode.
    A switch in ``DryContact`` mode cannot be added to an access link or opened through one.

Switch output settings
----------------------

+---------------+--------+--------------------------------------------------------------------+
| Name          | Type   | Description                                                        |
+===============+========+====================================================================+
| impulseLength | number | duration of the impulse triggered on the output, in seconds (1-30) |
+---------------+--------+--------------------------------------------------------------------+
