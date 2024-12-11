Door sensor state
-------------------------

+--------------------------+----------------------------------------------+---------------------------------------------------+
| Name                     | Type                                         | Description                                       |
+==========================+==============================================+===================================================+
| batteryLevel             | number                                       | door sensor battery level in the range of 0-100   |
+--------------------------+----------------------------------------------+---------------------------------------------------+
| batteryLevelModifiedTime | datetime                                     | date of last battery level change                 |
+--------------------------+----------------------------------------------+---------------------------------------------------+

.. note::
    The **batteryLevel** and **batteryLevelModifiedTime** properties are returned only if the date of the last battery level change is not older than 30 days. 