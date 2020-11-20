How to get and sync locks
=========================

.. include:: ../includes/how-to-header.txt

Tedee's API allows you to get information about all of your locks.
There are four endpoints to sync list of locks. 
First you need to use ``my/lock`` endpoint  to get list of locks with specific data as well as their settings and sharing details.
Then you should use one of three endpoints for retrieving locks statuses periodically


Get the list of locks
---------------------

To get the list of locks with details you will have to call the endpoint below. 
This endpoint should only be called to get the list of locks if necessary. Don't use this endpoint to refresh lock status frequently.

``GET |apiUrl|/api/|apiVersion|/my/lock``

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


Refresh locks statuses
----------------------

To get locks statuses you will have to call one of the endpoints below. 
These endpoints should be used to refresh locks statuses periodically.

.. warning::

    You shouldn't run these endpoints more than once every 10 seconds.


**1) Endpoint to sync all your locks**

``GET |apiUrl|/api/|apiVersion|/my/lock/sync``

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**2) Endpoint to sync list of locks by ids provided in query**

``GET |apiUrl|/api/|apiVersion|/my/lock/sync/filtered``

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/sync/filtered?id=<<deviceId>>&id=<<deviceId>>" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"



**3) Endpoint to sync single lock by id**

``GET |apiUrl|/api/|apiVersion|/my/lock/sync/<<deviceId>>``

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/sync/<<deviceId>>" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


The response from these endpoints contains the following information for each lock:

* **id** - id of lock
* **isConnected** - whether the lock is connected to the bridge
* **state** - the current lock status
* **isCharging** -  whether the lock is currently charging
* **batteryLevel** - battery level of the lock
