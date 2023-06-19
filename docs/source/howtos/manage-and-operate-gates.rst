How to manage and operate gates
================================

In this tutorial, we will go through gate management. We will show you how to manage gates and how to operate them.

.. note::

    You need to remember that the gate is an external device. To add gates to your Tedee account, you first need to set up an integration to BleBox using the Tedee mobile app. Once you are linked with BleBox, your BleBox devices should be synced with the Tedee account.


Get user gates
---------------------

To get list of user gates use :doc:`Get all <../endpoints/gate/get-all>` endpoint:

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

As a result, you will get a list of gates you have synchronized between Tedee and BleBox accounts. You will see the last sync state between Tedee and BleBox systems using the GET endpoint. In the following paragraphs, we will present how to sync the gates state to the latest one.

The GET endpoint can check the current gate connection status, firmware, and impulse length, which is the gate opening signal duration.

.. note::
    You must use the BleBox (wBox app) directly to update impulse length or gate firmware.

The important thing is to understand states gate can have:

    1. **connected** - The gate is connected to BleBox. The open operations can be performed (IsConnected is true, and IsPresentInExternal is true).
    
    2. **disconnected** - The gate is disconnected from the network connection but still exists in BleBox. The open operation can fail if the connection is not re-established in the meantime (IsConnected is false, and IsPresentInExternal is true).
    
    3. **unlinked** - Gate is not present in the user BleBox account but still exists in Tedee. (IsPresentInExternal is false).

Get gate by id
---------------------

To get single gate by id use :doc:`Get single <../endpoints/gate/get-single>` endpoint:

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate/1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

As a result you will with same details as described above.

Delete gate 
---------------------

To delete gate use :doc:`Get single <../endpoints/gate/delete>` endpoint:

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/gate/1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

After running this endpoint, the gate will disappear from your Tedee account.

.. warning::

    The gate will be added as a new device during the next synchronization between the Tedee and Blebox systems. If you want to delete the gate permanently, you must delete it from your BleBox account first.

Unlock gate
----------------------
To unlock the gate use :doc:`unlock command <../endpoints/gate/unlock>` endpoint:

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/gate/1/operation/unlock" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"
    
After running this endpoint, the gate will be unlocked for an impulse length time.
You can check the value of impulse length in the :doc:`Get single <../endpoints/gate/get-single>` endpoint.
    
.. note::
    To complete the operation successfully, you must meet several conditions:
    
    - gate must be connected to the network
    - gate must be present in the BleBox account
    - integration with BleBox must be active
    - you need to have access to the gate in the Tedee system