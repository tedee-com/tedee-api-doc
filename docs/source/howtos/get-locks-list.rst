How to get and sync locks list
==============================

.. include:: ../includes/how-to-header.txt[p-

Tedee's api API allows you to get information about all of your devices.
It includes device specific data as well as it's settings and share details.

To get the list of the devices you will have to call the endpoint below:

``|apiUrl|/api/|apiVersion|/my/device/details``

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/device/details" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

.. note::

    You can find a code sample for this action in documenation `repository <https://github.com/tedee-com/tedee-api-doc/blob/master/samples/cs/Tedee.Api.CodeSamples/Actions/S02GetDevicesList.cs>`_.
