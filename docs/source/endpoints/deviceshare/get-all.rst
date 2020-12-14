Get all
=========================

Get all shares for device by provided id.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/deviceshare?deviceId={id}

**URI Parameters**

+------------------------+-----------+---------------------+
| Name                   | Type      | Description         |
+========================+===========+=====================+
| deviceId               | number    | id of device        |
+------------------------+-----------+---------------------+

Responses 
-------------

+------------------------+--------------------------------------------------------+--------------------------+
| Name                   | Type                                                   | Description              |
+========================+========================================================+==========================+
| 200 OK                 | :doc:`Share <../../datastructures/share-details>` []   | successful operation     |
+------------------------+--------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| DeviceShare.Read       | Grants user possibility to read data connected with device shares             |
+------------------------+-------------------------------------------------------------------------------+
| DeviceShare.ReadWrite  | Grants user possibility to read and write data connected with device shares   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Get shares
^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/deviceShare?deviceId=1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": [
                {
                    "id": 15,
                    "userId": 11,
                    "deviceId": 1,
                    "organizationUserId": 12,
                    "userIdentity": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
                    "accessLevel": 1,
                    "accessType": 0,
                    "userEmail": "john.doe@email.com",
                    "isPending": false,
                    "userDisplayName": "John Doe",
                    "repeatEvent": {
                        "id": 1,
                        "weekDays": 10,
                        "dayStartTime": "2020-12-14T08:09:57.781Z",
                        "dayEndTime": "2020-12-31T08:10:57.781Z",
                        "startDate": null,
                        "endDate": null
                    },
                    "remoteAccessDisabled": true
                }
            ]
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }
