Create
=========================

Create new share for device

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/deviceshare

**Body Parameters**

+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| Name                      | Type                                                                      | Description                                        |
+===========================+===========================================================================+====================================================+
| accessLevel               | :doc:`Access level <../../enums/access-level>`                            | represents user access level                       |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| accessType                | :doc:`Access type <../../enums/access-type>`                              | represents user access type                        |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| deviceId                  | number                                                                    | device id                                          |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| remoteAccessDisabled      | boolean                                                                   | represents if remote access is disabled            |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| repeatEvent               | :doc:`Repeat event <../../datastructures/repeat-event>`                   | represents repeat event object                     |
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

Create share
^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/deviceshare" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "deviceId": 1,
            "accessLevel": 1,
            "accessType": 1,
            "userEmail": "john.doe@email.com"
            "repeatEvent": {
                "weekDays": 10,
                "dayStartTime": "2020-12-14T08:09:57.781Z",
                "dayEndTime": "2020-12-31T08:10:57.781Z",
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
                "sharedUserDisplayName": "john.doe"
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }
