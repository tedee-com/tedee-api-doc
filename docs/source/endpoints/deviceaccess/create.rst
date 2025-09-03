Create
=========================

Grants access to the device for a user or user group.
This endpoint can be used by owner or administrator of the device.

.. note::
    Each principal (user or group) can have only one active access to the device at the time.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/device/{deviceId}/access

**Body Parameters**

+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| Name                      | Type                                                                      | Description                                          |
+===========================+===========================================================================+======================================================+
| accessLevel               | :doc:`Access level <../../enums/access-level>`                            | represents user access level                         |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| dayEndTime                | string                                                                    | end time of the day when user can access the device  |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| dayStartTime              | string                                                                    | start time of the day when user can access the device|
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| endDate                   | string                                                                    | end date of period when user can access the device   |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| remoteAccessDisabled      | boolean                                                                   | represents if remote access is disabled              |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| startDate                 | string                                                                    | start date of period when user can access the device |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| principalId               | UUID                                                                      | principal (user or group) UID to grant access        |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| principalType             | number                                                                    | 0 = User, 1 = UserGroup                              |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| userEmail                 | string                                                                    | (alternative) user email to grant access             |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| weekDays                  | string                                                                    | allowed week days when user can access the device    |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+


Responses 
-------------

+------------------------+----------------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                                       | Description              |
+========================+============================================================================+==========================+
| 201 Created            | :doc:`Device Access Success <../../datastructures/device-access-success>`    | successful operation   |
+------------------------+----------------------------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| DeviceShare.ReadWrite  | Grants user possibility to read and write data connected with device access   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Grant permanent administrator access to user
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "principalId": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
            "principalType": 0,
            "accessLevel": 1,
            "weekDays": null,
            "dayStartTime": null,
            "dayEndTime": null,
            "startDate": null,
            "endDate": null,
            "remoteAccessDisabled" : false
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "result": {
                "id": 1,
                "sharedUserDisplayName": "John Doe"
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }


Grant guest access to user group
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "principalId": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
            "principalType": 1,
            "accessLevel": 0,
            "weekDays": null,
            "dayStartTime": null,
            "dayEndTime": null,
            "startDate": null,
            "endDate": null,
            "remoteAccessDisabled" : false
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "result": {
                "id": 1,
                "sharedUserDisplayName": "John Doe"
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }

Grant access using email (backward compatibility)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "userEmail": "john.doe@email.com",
            "accessLevel": 0,
            "weekDays": 7,
            "dayStartTime": "2020-12-01T08:00:00.000Z",
            "dayEndTime": "2020-12-31T20:00:00.000Z",
            "startDate": "2020-12-01T08:09:57.781Z",
            "endDate": "2020-12-31T23:10:57.781Z",
            "remoteAccessDisabled" : false
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "result": {
                "id": 1,
                "sharedUserDisplayName": "John Doe"
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }
