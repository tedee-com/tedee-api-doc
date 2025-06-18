Create
=========================

Grants access to the device for new user.
This endpoint can be used by owner or administrator of the device.

.. note::
    User can have only one active access to the device at the time.

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
| userEmail                 | string                                                                    | user email that will receive access to the device    |
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
| DeviceShare.ReadWrite | Grants user possibility to read and write data connected with device access   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Grant permanent administrator access
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "accessLevel": 1,
            "userEmail": "john.doe@email.com",
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


Grant guest time restricted access
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "accessLevel": 0,
            "userEmail": "john.doe@email.com"
            "weekDays": null,
            "dayStartTime": null,
            "dayEndTime": null,
            "startDate": "2020-12-14T08:09:57.781Z",
            "endDate": "2020-12-31T08:10:57.781Z",
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

Grant guest custom access
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "accessLevel": 0,
            "userEmail": "john.doe@email.com"
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
