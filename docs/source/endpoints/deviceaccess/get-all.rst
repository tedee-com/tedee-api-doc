Get all
=========================

Get all access details for a specific device.
This endpoint can be used by all users that have access to the device, but users with access level "Guest" and those users whose access is not active
will get in response only information about owner of device and own access details. Owner and administrators with active access will get all users access details.
Results can be filtered by id and/or email of user.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/device/{deviceId}/access?Filters.UserIdentity={userId}&Filters.Email={email}

**URI Parameters**

+----------------------+-------------------+---------------------+
| Name                 | Type              | Description         |
+======================+===================+=====================+
| deviceId             | number            | id of device        |
+----------------------+-------------------+---------------------+
| Filters.UserIdentity | string (optional) | id of user          |
+----------------------+-------------------+---------------------+
| Filters.Email        | string (optional) | email of user       |
+----------------------+-------------------+---------------------+

Responses 
-------------

+------------------------+----------------------------------------------------------------+--------------------------+
| Name                   | Type                                                           | Description              |
+========================+================================================================+==========================+
| 200 OK                 | :doc:`Access details <../../datastructures/access-details>` [] | successful operation     |
+------------------------+----------------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| DeviceShare.Read       | Grants user possibility to read data connected with device access             |
+------------------------+-------------------------------------------------------------------------------+
| DeviceShare.ReadWrite  | Grants user possibility to read and write data connected with device access   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Get accesses
^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/device/1/access" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": [
                {
                    "id": 15,
                    "userId": 11,
                    "deviceId": 1,
                    "userIdentity": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
                    "accessLevel": 1,
                    "accessType": 0,
                    "userEmail": "john.doe@email.com",
                    "isPending": false,
                    "userDisplayName": "John Doe",
                    "weekDays": 10,
                    "dayStartTime": "2020-12-14T08:09:57.781Z",
                    "dayEndTime": "2020-12-31T08:10:57.781Z",
                    "startDate": null,
                    "endDate": null,
                    "remoteAccessDisabled": true
                },
                                {
                    "id": 16,
                    "userId": 12,
                    "deviceId": 1,
                    "userIdentity": "bcc1fdc9-13ee-43b3-a13e-eaba2eaf7333",
                    "accessLevel": 0,
                    "accessType": 1,
                    "userEmail": "john.kowalsky@email.com",
                    "isPending": false,
                    "userDisplayName": "John Doe",
                    "id": 1,
                    "weekDays": 10,
                    "dayStartTime": "2020-12-14T08:09:57.781Z",
                    "dayEndTime": "2020-12-31T08:10:57.781Z",
                    "startDate": null,
                    "endDate": null,
                    "remoteAccessDisabled": false
                }
            ]
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }
