Get single
====================

Returns the gate with the specified id.

If you want to get familiar with the whole flow how to manage and operate gates, please refer to our tutorial: :doc:`How to manage and operate gates <../../howtos/manage-and-operate-gates>`.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/gate/{id}

**URI Parameters**

+------------------------+--------------------+---------------------------------+
| Name                   | Type               | Description                     |
+========================+====================+=================================+
| id                     | number             | id of the gate                  |
+------------------------+--------------------+---------------------------------+
| includeUserSettings    | boolean (optional) | should userSettings be included |
+------------------------+--------------------+---------------------------------+

Responses 
-------------

+------------------------+-------------------------------------------------------+--------------------------+
| Name                   | Type                                                  | Description              |
+========================+=======================================================+==========================+
| 200 OK                 | :doc:`Gate <../../datastructures/gate>`               | successful operation     |
+------------------------+-------------------------------------------------------+--------------------------+

Scopes

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.Read            | Grants user possibility to read data connected with devices             |
+------------------------+-------------------------------------------------------------------------+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Get single gate
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate/123" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
        "result": {
            "externalId": "2",
            "externalName": "Backend doorbox 2",
            "externalType": "gateBox",
            "impulseLength": 5000,
            "icon": 1,
            "userSettings": null,
            "location": null,
            "isPresentInExternal": true,
            "id": 30586,
            "organizationId": 901,
            "serialNumber": "23210501-125413",
            "name": "Backend doorbox 2",
            "userIdentity": "12345678-1234-1234-1234-1234567890",
            "type": 5,
            "created": "2023-05-24T16:10:34.2354605",
            "revision": 1,
            "deviceRevision": 1,
            "targetDeviceRevision": 1,
            "timeZone": "Europe/Warsaw",
            "isConnected": false,
            "accessLevel": 0,
            "shareDetails": {
            "id": 123,
            "userId": 9541,
            "deviceId": 30586,
            "userIdentity": "12345678-1234-1234-1234-1234567890",
            "accessLevel": 0,
            "accessType": 0,
            "userEmail": "test.test@test.test",
            "isPending": false,
            "userDisplayName": "Test",
            "repeatEvent": {
                "id": 382010,
                "weekDays": null,
                "startDate": null,
                "endDate": null,
                "dayStartTime": null,
                "dayEndTime": null
            },
            "remoteAccessDisabled": true
            },
            "softwareVersions": []
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
        }