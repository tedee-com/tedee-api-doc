How to operate your locks
=========================

In this section let's focus on how to operate tedee locks. To operate lock via API you need to be owner of the device or have active share with remoteAccessDisabled flag set on false (see :doc:`Share Details <../datastructures/share-details>`). 
What you need is id of your lock.

.. note::
    You should calibrate your lock before using these endpoints. If you didn't calibrate your lock these endpoints will return successful response but nothing will happen.

You can perform following actions on lock:
* unlock
* locks
* pull

Each action can be performed only in specific lock states. Here is Lock state diagram:

.. diagram

Make sure lock and bridge are connected.


Lock tedee lock
----------------------
To lock the device first make sure it is in unlocked or semi-locked state then send lock command.

Lock request
""""""""""""""

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/close" -H "accept: application/json" -H "Authorization: Bearer <<access token>>" -d "<<request body>>"

**Sample Request Body**

.. code-block:: js

    {
        "deviceId": 1
    }

In response you will receive operationId. The locking operation usually takes up to 3 seconds.


Unlock tedee lock
----------------------
To unlock the device first make sure it is in locked or semi-locked state then send unlock command.

Unlock request
""""""""""""""""""""

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/open" -H "accept: application/json" -H "Authorization: Bearer <<access token>>" -d "<<request body>>"

**Sample Request Body**

.. code-block:: js

    {
        "deviceId": 1
    }

In response you will receive operationId. The unlocking operation usually takes up to 3 seconds. When lock has auto pull spring enabled then unlocking lock will perform pull operation.


Pull spring in tedee lock
------------------------------

To perform pull spring use this endpoint :doc:`Pull spring <../endpoints/lock/pull-spring>`.

Pull request
"""""""""""""

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/pull-spring" -H "accept: application/json" -H "Authorization: Bearer <<access token>>" -d "<<request body>>"


**Sample Request Body**

.. code-block:: js

    {
        "deviceId": 1
    }

In response you will receive operationId. The duration of pull spring is configured by user.

.. note::
    Additionally you should calibrate pull spring in your lock before using this endpoint. If you didn't calibrate pull spring this endpoint will return successful response but nothing will happen.

Checking operation progress
---------------------------

Returned operationId is for correlating whole process of pull spring command - mobile app receives push notification with this operationId and result of executed command.
The lock/unlock/pull actions will take few seconds so you must somehow check the progress. To do that simply call the :doc:`Sync single endpoint <../endpoints/lock/sync-single>` repeatedly until operation complete.

Sample sync singe request
"""""""""""""""""""""""""

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/<<id>>/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

