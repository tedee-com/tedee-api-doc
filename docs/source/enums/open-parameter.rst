Open parameter
----------------

This enum describes possible open parameters for unlocking lock

+-----------+---------------------------------------+
| Number    | Name                                  |
+===========+=======================================+
| 0         | Default behaviour of unlocking lock   |
+-----------+---------------------------------------+
| 2         | Force unlock                          |
+-----------+---------------------------------------+

.. note::
    Force unlock value (number 2) has find usage only when lock is in Unknown state. It is responsible for making lock to go to Unlocked state no matter what. It is force or emergency way to unlock the door.
    Everybody that has access to lock can use this enum value.