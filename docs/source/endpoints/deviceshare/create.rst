Create
=========================

Grants access to the device for new user.
This endpoint can be used by owner or administrator of the device.

.. note::
    User can have only one active share to the device at the time.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/deviceshare

**Body Parameters**

+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| Name                      | Type                                                                      | Description                                        |
+===========================+===========================================================================+====================================================+
| accessLevel               | :doc:`Access level <../../enums/access-level>`                            | represents user access level                       |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| deviceId                  | number                                                                    | device id                                          |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| remoteAccessDisabled      | boolean                                                                   | represents if remote access is disabled            |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| repeatEvent               | :doc:`Repeat event <../../datastructures/repeat-event>`                   | represents repeat event of the share               |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| userEmail                 | string                                                                    | user email that device will be shared with         |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+

Responses 
-------------

+------------------------+----------------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                                       | Description              |
+========================+============================================================================+==========================+
| 201 Created            | :doc:`Device Share Success <../../datastructures/device-share-success>`    | successful operation     |
+------------------------+----------------------------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| DeviceShare.ReadWrite  | Grants user possibility to read and write data connected with device shares   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Grant permanent administrator access
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/deviceshare" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "deviceId": 1,
            "accessLevel": 1,
            "userEmail": "john.doe@email.com"
            "repeatEvent": {
                "weekDays": null,
                "dayStartTime": null,
                "dayEndTime": null,
                "startDate": null,
                "endDate": null
            },
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

    curl -X POST "|apiUrl|/api/|apiVersion|/my/deviceshare" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "deviceId": 1,
            "accessLevel": 0,
            "userEmail": "john.doe@email.com"
            "repeatEvent": {
                "weekDays": null,
                "dayStartTime": null,
                "dayEndTime": null,
                "startDate": "2020-12-14T08:09:57.781Z",
                "endDate": "2020-12-31T08:10:57.781Z"
            },
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

    curl -X POST "|apiUrl|/api/|apiVersion|/my/deviceshare" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "deviceId": 1,
            "accessLevel": 0,
            "userEmail": "john.doe@email.com"
            "repeatEvent": {
                "weekDays": 7,
                "dayStartTime": "2020-12-01T08:00:00.000Z",
                "dayEndTime": "2020-12-31T20:00:00.000Z",
                "startDate": "2020-12-01T08:09:57.781Z",
                "endDate": "2020-12-31T23:10:57.781Z"
            },
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
