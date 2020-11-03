How to get and sync locks
=========================

.. include:: ../includes/how-to-header.txt

Tedee's API allows you to get information about all of your locks.
There are two endpoints to sync list of locks. 
The first endpoint allows you to get a list of locks with specific data as well as their settings and sharing details. 
The second endpoint should be used to retrieving locks statuses periodically.


**1) Get the list of locks with details**

To get the list of locks with details you will have to call the endpoint below. 
This endpoint should only be called to get the list of locks if necessary. Don't use this endpoint to refresh lock status frequently.

``GET |apiUrl|/api/|apiVersion|/my/lock``

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**2) Refresh locks statuses**

To get locks statuses you will have to call the endpoint below. 
This endpoint should be used to refresh locks statuses periodically.

``GET |apiUrl|/api/|apiVersion|/my/lock/sync``

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

.. warning::

    You shouldn't run this endpoint more than once every 10 seconds.
