Unlock mode
----------------

This enum describes possible modes for unlocking lock

+-----------+---------------------------------------+
| Number    | Name                                  |
+===========+=======================================+
| 0         | Default behaviour of unlocking lock   |
+-----------+---------------------------------------+
| 2         | Force unlock                          |
+-----------+---------------------------------------+
| 3         | Without auto pull spring              |
+-----------+---------------------------------------+
| 4         | Unlock or pull spring                 |
+-----------+---------------------------------------+

.. note::
    Force unlock value (number 2) has find usage only when lock is in Unknown state. It is responsible for making lock to go to Unlocked state no matter what. It is force or emergency way to unlock the door.
    Everybody that has access to lock can use this enum value.

.. note::
    Without auto pull spring value (number 3) allows to unlock the lock without pulling the spring (when lock has auto pull spring enabled).

.. note::
    Unlock or pull spring value (number 4) allows to perform two operations depends on current lock state. 
    When lock is in Locked state, it allows to unlock the lock (with pulling the spring when lock has auto pull spring enabled).
    When lock is in Unlocked state, it allows to perform pull spring.
