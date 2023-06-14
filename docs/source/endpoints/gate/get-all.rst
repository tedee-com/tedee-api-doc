Get all
====================

Get a list of all currently logged user gates

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/gate

**URI Parameters**

+------------------------+--------------------+---------------------------------+   
| Name                   | Type               | Description                     |
+========================+====================+=================================+
| Filters.Name           | string (optional)  | name to filter                  |
+------------------------+--------------------+---------------------------------+
| Filters.IsConnected    | boolean (optional) | connection to filter            |
+------------------------+--------------------+---------------------------------+
| includeUserSettings    | boolean (optional) | should userSettings be included |
+------------------------+--------------------+---------------------------------+
| ItemsPerPage           | integer (optional) | count of items on page          |
+------------------------+--------------------+---------------------------------+
| Page                   | integer (optional) | number of page                  |
+------------------------+--------------------+---------------------------------+

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
                    "externalId":"4a3fdaac87aa",
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
                    "macAddress":null,
                    "name":"Backend doorbox 2",
                    "userIdentity":"1e2fb063-8110-49e5-a9cf-8bcc63696bcf",
                    "type":5,
                    "created":"2023-05-24T16:10:34.2354605",
                    "revision":1,
                    "deviceRevision":1,
                    "targetDeviceRevision":1,
                    "timeZone":"Europe/Warsaw",
                    "isConnected":false,
                    "accessLevel":0,
                    "shareDetails":
                    {
                        "id":346363,
                        "userId":9541,
                        "deviceId":30586,
                        "userIdentity":"12c77a1f-6448-44ff-864c-a420a4674aa9",
                        "accessLevel":0,
                        "accessType":0,
                        "userEmail":"marcin.kocinski@tedee.com",
                        "isPending":false,
                        "userDisplayName":"Marcin Koc",
                        "repeatEvent":
                        {
                            "id":382010,
                            "weekDays":null,
                            "startDate":null,
                            "endDate":null,
                            "dayStartTime":null,
                            "dayEndTime":null

                        },
                        "remoteAccessDisabled":true
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