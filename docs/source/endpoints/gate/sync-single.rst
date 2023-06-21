Sync single
=========================

Sync gate with given id with BleBox.

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

    GET |apiUrl|/api/|apiVersion|/my/gate/{id}/sync

**URI Parameters**

+------------------------+-----------+---------------------+
| Name                   | Type      | Description         |
+========================+===========+=====================+
| id                     | number    | id of gate to sync  |
+------------------------+-----------+---------------------+


Responses 
-------------

+------------------------+------------------------------------------------------+--------------------------+
| Name                   | Type                                                 | Description              |
+========================+======================================================+==========================+
| 200 OK                 | :doc:`Gate <../../datastructures/gate>` []           | successful operation     |
+------------------------+------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Sync user gate
^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate/123/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
    "result": {
        "externalId": "12356hjg",
        "externalName": "Test",
        "externalType": "gateBox",
        "impulseLength": 15200,
        "icon": 1,
        "userSettings": null,
        "location": null,
        "isPresentInExternal": true,
        "id": 123,
        "organizationId": 883,
        "serialNumber": "12345-12345",
        "name": "Test",
        "userIdentity": "12345678-1234-1234-1234-123456789",
        "type": 5,
        "created": "2023-06-12T12:36:53.4496653",
        "revision": 2,
        "deviceRevision": 1,
        "targetDeviceRevision": 1,
        "timeZone": "Europe/Warsaw",
        "isConnected": true,
        "accessLevel": 2,
        "shareDetails": null,
        "softwareVersions": [
            {
                "softwareType": 0,
                "version": "0.1044",
                "updateAvailable": false
            }
        ]
    },
    "success": true,
    "errorMessages": [],
    "statusCode": 200
    }
