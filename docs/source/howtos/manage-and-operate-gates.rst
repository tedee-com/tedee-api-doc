How to manage and operate gates
================================

In this tutorial, we will go through gate management. We will show you how to get and delete gates.

.. note::

    To have gate, you need to have your Tedee account linked to BleBox and have smart relay module in wBox application.


Get user gates
---------------------

To get list of user gates use :doc:`Get all <../endpoints/gate/get-all>` endpoint:

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

As a result you will get a list of gates user have access to. You can find the gate you want to delete.
In result gates you will see properties as gate connection status, firmware and impulse time. Changing impulse time need to be done in wBox.

.. note::

       Gate connection status can be one of the following:
       
       1. **connected** - IsConnected is true and isPresentInExternal is true - Gate is connected to BleBox and actions like unlock can be performed
       
       2. **disconnected** - IsConnected is false and isPresentInExternal is true - Gate is not connected to BleBox, but still exist in BleBox
       
       3. **unlinked** - IsConnected is false and isPresentInExternal is false - Gate is not present in BleBox

Get user gate by id
---------------------

To get single get by id use :doc:`Get single <../endpoints/gate/get-single>` endpoint:

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate/1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

As a result you will get gate.

Delete gate by id
---------------------

To delete gate use :doc:`Get single <../endpoints/gate/delete>` endpoint:

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/gate/1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

As a result you will delete gate.

.. warning::

    The gate will be added again as new device during next sync, if you haven't deleted it from your BleBox account. If you want to delete gate permanently you have to delete it from your BleBox account first.
