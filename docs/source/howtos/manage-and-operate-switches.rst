How to manage and operate switches
==================================

In this tutorial, we will go through switch management. We will show you how to manage switches and how to operate them.

.. note::

    The switch is a Tedee device that connects directly to the Tedee cloud over Wi-Fi. It is added to the Tedee account with the Tedee mobile app. No external integration is needed.

Get user switches
---------------------

To get list of user switches use :doc:`Get all <../endpoints/switch/get-all>` endpoint:

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/switch" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

As a result, you will get a list of switches you have access to. The response contains the current connection status (``isConnected``), the icon, the device settings and the firmware versions of each switch.

Get single switch
---------------------

To get single switch by Tedee id use :doc:`Get single <../endpoints/switch/get-single>` endpoint:

**Sample request for switch with id = 123**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/switch/123" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

As a result you will get single switch with same details as described above.

Update switch
---------------------

To change the name, icon, device settings or your user settings use :doc:`Update <../endpoints/switch/update>` endpoint:

**Sample request for switch with id = 123**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/switch/123" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "revision": 3,
            "deviceSettings": {
                "output1": {
                    "impulseLength": 5
                }
            }
        }

The ``revision`` must match the current revision of the switch. Device settings are sent to the switch over the cloud.

Open switch
----------------------
To open the switch use :doc:`Open switch <../endpoints/switch/open>` endpoint:

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/switch/123/operation/open" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

After running this endpoint, the switch triggers the output selected in ``openActionOutput`` for the impulse length configured for that output.

.. note::
    To complete the operation successfully, you must meet several conditions:

    - switch must be connected to the network (otherwise ``423 Locked`` is returned)
    - you need to have active access to the switch in the Tedee system with remote access enabled

The opening is recorded in the device activity log as ``SwitchOpenedRemote`` (see :doc:`Event type <../enums/event-type>`).

Delete switch
---------------------

To delete switch use :doc:`Delete switch <../endpoints/switch/delete>` endpoint:

**Sample request for switch with id = 123**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/switch/123" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

After running this endpoint, the switch will disappear from your Tedee account.
