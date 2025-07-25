Get all
====================

Returns the gates of the currently logged-on user.

If you want to get familiar with the whole flow how to manage and operate gates, please refer to our tutorial: :doc:`How to manage and operate gates <../../howtos/manage-and-operate-gates>`.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/gate

**URI Parameters**

+------------------------+--------------------+----------------------------------------+   
| Name                   | Type               | Description                            |
+========================+====================+========================================+
| filters.name           | string (optional)  | filtering by gate name                 |
+------------------------+--------------------+----------------------------------------+
| filters.isConnected    | boolean (optional) | filtering by current connection status |
+------------------------+--------------------+----------------------------------------+
| includeUserSettings    | boolean (optional) | should userSettings be included        |
+------------------------+--------------------+----------------------------------------+
| itemsPerPage           | integer (optional) | count of items on page                 |
+------------------------+--------------------+----------------------------------------+
| page                   | integer (optional) | number of page                         |
+------------------------+--------------------+----------------------------------------+

Responses 
-------------

+------------------------+--------------------------------------------------+--------------------------+
| Name                   | Type                                             | Description              |
+========================+==================================================+==========================+
| 200 OK                 | :doc:`Gate List<../../datastructures/gate-list>` | successful operation     |
+------------------------+--------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.Read            | Grants user possibility to read data connected with devices             |
+------------------------+-------------------------------------------------------------------------+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Get all gates of currently logged user 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
        "result":{
            "page":1,
            "itemsPerPage":2147483647,
            "gates":[
                {
                    "externalId":"2",
                    "externalName":"Backend doorbox 2",
                    "externalType":"gateBox",
                    "impulseLength":5000,
                    "icon":1,
                    "userSettings":null,
                    "location":null,
                    "isPresentInExternal":true,
                    "id":30586,
                    "organizationId":901,
                    "serialNumber":"23210501-125413",
                    "name":"Backend doorbox 2",
                    "userIdentity":"12345678-1234-1234-1234-1234567890",
                    "type":5,
                    "created":"2023-05-24T16:10:34.2354605",
                    "revision":1,
                    "deviceRevision":1,
                    "targetDeviceRevision":1,
                    "timeZone":"Europe/Warsaw",
                    "isConnected":false,
                    "accessLevel":0,
                    "accessDetails":
                    {
                        "accessLevel":0,
                        "remoteAccessDisabled":true,
                        "weekDays":null,
                        "startDate":null,
                        "endDate":null,
                        "dayStartTime":null,
                        "dayEndTime":null
                    },
                    "softwareVersions":[       
                    ]
                }   
            ]
        },
        "success":true,
        "errorMessages":[
        ],
        "statusCode":200
        }