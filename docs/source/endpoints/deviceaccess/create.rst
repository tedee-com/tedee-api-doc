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
| principalId               | UUID                                                                      | principal (user or group) UID to grant access        |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| principalType             | number                                                                    | 0 = User, 1 = UserGroup                              |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| remoteAccessDisabled      | boolean                                                                   | represents if remote access is disabled              |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| startDate                 | string                                                                    | start date of period when user can access the device |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| userEmail                 | string                                                                    | user email to grant access                           |
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

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "accessLevel": 1,
            "dayEndTime": null,
            "dayStartTime": null,
            "endDate": null,
            "principalType": 0,
            "remoteAccessDisabled": false,
            "startDate": null,
            "userEmail": "john.doe@email.com",
            "weekDays": null
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "accessLevel": 1,
            "dayEndTime": null,
            "dayStartTime": null,
            "endDate": null,
            "principalId": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
            "principalType": 0,
            "remoteAccessDisabled": false,
            "startDate": null,
            "userEmail": "john.doe@email.com",
            "weekDays": null
        }


Grant time-restricted guest access to user
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "accessLevel": 0,
            "dayEndTime": "2025-12-31T18:00:00.000Z",
            "dayStartTime": "2025-12-01T08:00:00.000Z",
            "endDate": "2025-12-31T23:59:59.000Z",
            "principalType": 0,
            "remoteAccessDisabled": false,
            "startDate": "2025-01-01T00:00:00.000Z",
            "userEmail": "jane.smith@email.com",
            "weekDays": 31
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "accessLevel": 0,
            "dayEndTime": "2025-12-31T18:00:00.000Z",
            "dayStartTime": "2025-12-01T08:00:00.000Z",
            "endDate": "2025-12-31T23:59:59.000Z",
            "principalId": "d5e6f7a8-9b0c-1d2e-3f4a-5b6c7d8e9f0a",
            "principalType": 0,
            "remoteAccessDisabled": false,
            "startDate": "2025-01-01T00:00:00.000Z",
            "userEmail": "jane.smith@email.com",
            "weekDays": 31
        }


Grant permanent guest access to user group
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "accessLevel": 0,
            "dayEndTime": null,
            "dayStartTime": null,
            "endDate": null,
            "principalId": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
            "principalType": 1,
            "remoteAccessDisabled": false,
            "startDate": null,
            "weekDays": null
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "accessLevel": 0,
            "dayEndTime": null,
            "dayStartTime": null,
            "endDate": null,
            "principalId": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
            "principalType": 1,
            "remoteAccessDisabled": false,
            "startDate": null,
            "userEmail": null,
            "weekDays": null
        }


Grant time-restricted access to user group
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "accessLevel": 1,
            "dayEndTime": "2025-12-31T17:00:00.000Z",
            "dayStartTime": "2025-12-01T09:00:00.000Z",
            "endDate": "2025-06-30T23:59:59.000Z",
            "principalId": "b5d6e7f8-8c9d-2e3f-4a5b-6c7d8e9f0b1c",
            "principalType": 1,
            "remoteAccessDisabled": true,
            "startDate": "2025-01-01T00:00:00.000Z",
            "weekDays": 31
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "accessLevel": 1,
            "dayEndTime": "2025-12-31T17:00:00.000Z",
            "dayStartTime": "2025-12-01T09:00:00.000Z",
            "endDate": "2025-06-30T23:59:59.000Z",
            "principalId": "b5d6e7f8-8c9d-2e3f-4a5b-6c7d8e9f0b1c",
            "principalType": 1,
            "remoteAccessDisabled": true,
            "startDate": "2025-01-01T00:00:00.000Z",
            "userEmail": null,
            "weekDays": 31
        }


Grant time-restricted access to user
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "accessLevel": 0,
            "dayEndTime": "2025-12-31T20:00:00.000Z",
            "dayStartTime": "2025-12-01T08:00:00.000Z",
            "endDate": "2025-12-31T23:59:59.000Z",
            "principalType": 0,
            "remoteAccessDisabled": false,
            "startDate": "2025-01-01T00:00:00.000Z",
            "userEmail": "john.doe@email.com",
            "weekDays": 7
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "accessLevel": 0,
            "dayEndTime": "2025-12-31T20:00:00.000Z",
            "dayStartTime": "2025-12-01T08:00:00.000Z",
            "endDate": "2025-12-31T23:59:59.000Z",
            "principalId": "7de29ia8-9b5b-89a6-f7jg-6g3a7jaaeje0",
            "principalType": 0,
            "remoteAccessDisabled": false,
            "startDate": "2025-01-01T00:00:00.000Z",
            "userEmail": "john.doe@email.com",
            "weekDays": 7
        }
