Lock properties
-----------------

+------------------------+----------------------------------------------+---------------------------------------------------------+
| Name                   | Type                                         | Description                                             |
+========================+==============================================+=========================================================+
| batteryLevel           | number                                       | current battery level                                   |
+------------------------+----------------------------------------------+---------------------------------------------------------+
| isCharging             | boolean                                      | is lock currently charging                              |
+------------------------+----------------------------------------------+---------------------------------------------------------+
| state                  | :doc:`Lock state <../enums/lock-state>`      | current state of the lock                               |
+------------------------+----------------------------------------------+---------------------------------------------------------+
| stateChangeResult      | number                                       | result of last state change (0 - success, > 0 - error)  |
+------------------------+----------------------------------------------+---------------------------------------------------------+
| lastStateChangedDate   | datetime                                     | date and time of last state change                      |
+------------------------+----------------------------------------------+---------------------------------------------------------+