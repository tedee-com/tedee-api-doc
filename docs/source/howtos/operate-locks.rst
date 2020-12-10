How to operate your locks
=========================

In this section let's focus on how to operate tedee locks. To operate lock via API you need to be owner of the device or have active share with remoteAccessDisabled flag set on false (see :doc:`Share Details <../datastructures/share-details>`). 
What you need is id of your lock.

.. note::
    You should calibrate your lock before using these endpoints. If you didn't calibrate your lock these endpoints will return successful response but nothing will happen.

After you send command to execute given operation you can check status of your lock using :doc:`sync endopints <get-and-sync-locks>`.

Lock your tedee lock
----------------------
To lock your door use endpoint :doc:`Lock your lock <../endpoints/lock/lock>`. This endpoint will return operationId. This is for correlating whole process of lock command - mobile app receives push notification with this operationId and result of executed command.


Unlock your tedee lock
----------------------
To unlock your door use this endpoint :doc:`Unlock your lock <../endpoints/lock/unlock>`. This endpoint will return operationId. This is for correlating whole process of unlock command - mobile app receives push notification with this operationId and result of executed command.


Pull spring in your tedee lock
------------------------------
To perform pull spring use this endpoint :doc:`Pull spring <../endpoints/lock/pull-spring>`. This endpoint will return operationId. This is for correlating whole process of pull spring command - mobile app receives push notification with this operationId and result of executed command.

.. note::
    Additional you should calibrate pull spring in your lock before using this endpoint. If you didn't calibrate pull spring this endpoint will return successful response but nothing will happen.