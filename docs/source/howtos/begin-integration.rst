How to begin integration
========================

Hi, so you want to write some integration? Choose one of supported scenarios: Full internet, Bluetooth or local network, follow provided steps and have fun.

.. _get-client-id:

Integration via Cloud API
-------------------------

You bought a Tedee Lock and you want to write some automation? You want to create a plugin to existing Smart Home system to integrate it with 
Tedee Lock via internet? Your company provide smart home platform and want to integrate with Tedee Lock via internet? 
You are in good place, our Open REST API allows you do everything what you need. 

You will need:

* Tedee Lock added to your Tedee account
* Tedee Bridge connected to the Internet and paired with the lock

Follow these tutorials:

* :doc:`How to authenticate <authenticate>`
* :doc:`Get and sync locks <get-and-sync-locks>`
* :doc:`Operate locks <operate-locks>`
* :doc:`How to manage device shares <share-device>`
* :doc:`Update locks settings <update-lock-settings>`

Integration via Bluetooth
-------------------------

If you already own bridge/device then you can connect it to Tedee Lock via Bluetooth. 
Your device must have internet connection to refresh access certificate used to communicate with Tedee Lock.

You will need:

* Tedee Lock added to your Tedee account
* Your own bridge/device with internet connection

Follow these tutorials:

* :doc:`How to authenticate <authenticate>`
* :doc:`How to prepare your device to connect to Tedee Lock via Bluetooth <connect-device-via-ble>`
* `How to connect your device to Tedee Lock via Bluetooth <https://tedee-tedee-lock-ble-api-doc.readthedocs-hosted.com/en/latest/howtos/begin-integration.html>`_

Examples:

* `PTLS connection from iOS app <https://github.com/tedee-com/tedee-example-ble-ios>`_
* `PTLS connection from Android app <https://github.com/tedee-com/tedee-example-ble-android>`_

Integration via Bridge API
--------------------------

If you want to integrate with Tedee Lock via a local network, you can use Bridge API.
Bridge must have an internet connection to obtain and periodically refresh access certificate for paired devices.

You will need:

* Tedee Lock added to your Tedee account
* Tedee Bridge connected to the Internet and paired with the lock

Follow these tutorials:

* `How to authenticate <https://docs.tedee.com/bridge-api#tag/Authenticate>`_
* `Get and sync locks <https://docs.tedee.com/bridge-api#tag/Get-and-sync-locks>`_
* `Operate locks <https://docs.tedee.com/bridge-api#tag/Operate-locks>`_

Documentation:

* `Bridge API documentation <https://docs.tedee.com/bridge-api>`_

More information
----------------

If you need more information about integration please check following links:

* You can user our logo but first read the :doc:`logo guidance <../logo-guidance>`
* Check existing :doc:`integration examples <example-integrations>`
* Use `community forum <https://tedee.freshdesk.com/en/support/discussions>`_ if you need help