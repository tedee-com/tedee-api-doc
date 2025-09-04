Get all
=========================

Get all access details for a specific device.
This endpoint can be used by all users that have access to the device, but users with access level "Guest" and those users whose access is not active
will get in response only information about owner of device and own access details. Owner and administrators with active access will get all users and user groups access details.
Results can be filtered by principal ID, text search, and principal type (User or UserGroup).

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/device/{deviceId}/access?Filters.PrincipalId={principalId}&Filters.Text={text}&Filters.PrincipalType={principalType}

**URI Parameters**

+------------------------+-------------------+----------------------------------------+
| Name                   | Type              | Description                            |
+========================+===================+========================================+
| deviceId               | number            | id of device                           |
+------------------------+-------------------+----------------------------------------+
| Filters.PrincipalId    | UUID (optional)   | User or UserGroup ID                   |
+------------------------+-------------------+----------------------------------------+
| Filters.PrincipalType  | number (optional) | 0 = User, 1 = UserGroup                |
+------------------------+-------------------+----------------------------------------+
| Filters.Text           | string (optional) | Text to search (email, name, etc.)     |
+------------------------+-------------------+----------------------------------------+

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
                    "accessLevel": 1,
                    "dayEndTime": "2020-12-31T08:10:57.781Z",
                    "dayStartTime": "2020-12-14T08:09:57.781Z",
                    "deviceId": 1,
                    "endDate": null,
                    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                    "isPending": false,
                    "organizationUserId": 11,
                    "principalId": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
                    "principalName": "John Doe",
                    "principalType": 0,
                    "remoteAccessDisabled": true,
                    "startDate": null,
                    "userEmail": "john.doe@email.com",
                    "weekDays": 10
                },
                {
                    "accessLevel": 0,
                    "dayEndTime": "2020-12-31T08:10:57.781Z",
                    "dayStartTime": "2020-12-14T08:09:57.781Z",
                    "deviceId": 1,
                    "endDate": null,
                    "id": "4ab96f75-6828-5673-c4gd-3d074g77bgb7",
                    "isPending": false,
                    "organizationUserId": 12,
                    "principalId": "bcc1fdc9-13ee-43b3-a13e-eaba2eaf7333",
                    "principalName": "John Kowalsky",
                    "principalType": 0,
                    "remoteAccessDisabled": false,
                    "startDate": null,
                    "userEmail": "john.kowalsky@email.com",
                    "weekDays": 10
                },
                {
                    "accessLevel": 0,
                    "dayEndTime": null,
                    "dayStartTime": null,
                    "deviceId": 1,
                    "endDate": null,
                    "id": "5bc07g86-7939-6784-d5he-4e185h88chc8",
                    "isPending": false,
                    "organizationUserId": 0,
                    "principalId": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
                    "principalName": "Engineering Team",
                    "principalType": 1,
                    "remoteAccessDisabled": false,
                    "startDate": null,
                    "userEmail": null,
                    "weekDays": null
                }
            ],
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }
