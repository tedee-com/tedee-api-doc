Repeat event
-----------------

.. note::
    Dates sent to Tedee API must be in the UTC timezone. The client must convert the date to UTC before sending it to the API.

+--------------+----------+------------------------------------------------------+
| Name         | Type     | Description                                          |
+==============+==========+======================================================+
| dayEndTime   | datetime | end time when user has access to the device          |
+--------------+----------+------------------------------------------------------+
| dayStartTime | datetime | start time when user has access to the device        |
+--------------+----------+------------------------------------------------------+
| endDate      | datetime | end date when user has access to the device          |
+--------------+----------+------------------------------------------------------+
| id           | number   | id of repeat event                                   |
+--------------+----------+------------------------------------------------------+
| startDate    | datetime | start date when user has access to the device in UTC |
+--------------+----------+------------------------------------------------------+
| weekDays     | number   | week days when user has access to the device in UTC  |
+--------------+----------+------------------------------------------------------+