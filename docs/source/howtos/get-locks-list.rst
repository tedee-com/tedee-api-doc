How to get and sync locks list
==============================

.. include:: ../includes/how-to-header.txt

Tedee's API allows you to get information about all of your locks.
The first endpoint allows you to get a list of locks with specific data as well as their settings and sharing details. 
The second endpoint should be used to retrieving locks statuses cyclically.

1) To get the list of locks with details you will have to call the endpoint below:

``GET |apiUrl|/api/|apiVersion|/my/lock``

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

.. note::

    You can find a code sample for this action in documenation `repository <https://github.com/tedee-com/tedee-api-doc/blob/master/samples/cs/Tedee.Api.CodeSamples/Actions/S02GetDevicesList.cs>`_.

2) To get the list of locks with details you will have to call the endpoint below:

``GET |apiUrl|/api/|apiVersion|/my/lock``

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

.. note::

    You can find a code sample for this action in documenation `repository <https://github.com/tedee-com/tedee-api-doc/blob/master/samples/cs/Tedee.Api.CodeSamples/Actions/S02GetDevicesList.cs>`_.
