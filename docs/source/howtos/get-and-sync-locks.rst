How to get and sync locks
=========================

For this tutorial let's consider that you have one or more locks and you need to get their data and then sync their states periodically.


Sync multiple locks
----------------------

Get user locks
""""""""""""""

First thing that you need to do is to use endpoint :doc:`Get all locks <../endpoints/lock/get-all>`. This endpoint will return full data of all currently logged user locks.

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


Sync user locks
"""""""""""""""

Then after you have succesfully downloaded locks data you can use endpoint :doc:`Sync locks <../endpoints/lock/sync>` to get only current state 
of user locks.

In that way you can save full data locally and only refresh fields that can often change also you will save yourself time for getting unnecessary data from api.

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

.. warning::

    You shouldn't run sync endpoint more than once every 10 seconds.


Sync single lock
-----------------------------
In this case let's consider that you want only to sync single lock that you already have full data.

Instead of calling :doc:`Sync locks <../endpoints/lock/sync>` you can call dedicated endpoint for syncing single lock by id :doc:`Sync single lock <../endpoints/lock/sync-single>`.
It's faster and allows you to call it every one second when lock is unlocking or locking.

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/1/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"