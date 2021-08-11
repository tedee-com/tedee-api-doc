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
| 3         | Without pull spring                   |
+-----------+---------------------------------------+

.. note::
    Force unlock value (number 2) has find usage only when lock is in Unknown state. It is responsible for making lock to go to Unlocked state no matter what. It is force or emergency way to unlock the door.
    Everybody that has access to lock can use this enum value.

.. note::
    Without pull spring value (number 3) allows to unlock the lock without pulling the spring when auto pull is enabled.