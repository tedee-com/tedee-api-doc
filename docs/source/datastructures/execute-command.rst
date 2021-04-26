Execute command response
------------------------

Response from requests:

* :doc:`Close command <../endpoints/lock/close>`
* :doc:`Open command<../endpoints/lock/open>`
* :doc:`Pull spring command <../endpoints/lock/pull-spring>`

+------------------------+------------+------------------------------------------------------------------------+
| Name                   | Type       | Description                                                            |
+========================+============+========================================================================+
| operationId            | string     | epoch time in miliseconds. Used for correlating whole process          |
+------------------------+------------+------------------------------------------------------------------------+
| lastStateChangedDate   | datetime   | date and time of last Lock state change                                |
+------------------------+------------+------------------------------------------------------------------------+