Sync all
=========================

Sync all user gates with BleBox.

.. note::
    Synchronization is a one-way process. Tedee will not update BleBox data.

Synchronization is a process of updating gates data in Tedee system with data from BleBox system.

.. note::
    You must use the BleBox (wBox app) directly to update impulse length or gate firmware.

.. note::
    Gates that are present in Tedee and are not present in BleBox will be marked as unlinked (isPresentInExternal field). When the unlinked gate will be re-added to BleBox again, it will synchronize with Tedee again. 

The important thing is to understand states gate can have:

    1. **connected** - The gate is connected to BleBox. The open operations can be performed (IsConnected is true, and IsPresentInExternal is true).
    
    2. **disconnected** - The gate is disconnected from the network connection but still exists in BleBox. The open operation can fail if the connection is not re-established in the meantime (IsConnected is false, and IsPresentInExternal is true).
    
    3. **unlinked** - Gate is not present in the user BleBox account but still exists in Tedee. (IsPresentInExternal is false).

If you want to get familiar with the whole flow how to manage and operate gates, please refer to our tutorial: :doc:`How to manage and operate gates <../../howtos/manage-and-operate-gates>`.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/gate/sync

Responses 
-------------

+------------------------+--------------------------+
| Name                   | Description              |
+========================+==========================+
| 204 No Content         | successful operation     |
+------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Sync user gates
^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }