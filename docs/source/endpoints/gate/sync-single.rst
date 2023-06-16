Sync single
=========================

Sync gate with given id with BleBox.

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

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate/1/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


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
        "id": 31628,
        "organizationId": 883,
        "serialNumber": "12345-12345",
        "macAddress": null,
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
