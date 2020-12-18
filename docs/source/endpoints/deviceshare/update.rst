Update
=========================

Update share details for device.

.. code-block:: sh

    PATCH |apiUrl|/api/|apiVersion|/my/deviceshare

**Body Parameters**

+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| Name                      | Type                                                                      | Description                                        |
+===========================+===========================================================================+====================================================+
| accessLevel               | :doc:`Access level <../../enums/access-level>`                            | represents user access level                       |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| accessType                | :doc:`Access type <../../enums/access-type>`                              | represents user access type                        |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| id                        | number                                                                    | id of share                                        |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| remoteAccessDisabled      | boolean                                                                   | represents if remote access is disabled            |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+
| repeatEvent               | :doc:`Repeat event <../../datastructures/repeat-event>`                   | represents repeat event of the share               |
+---------------------------+---------------------------------------------------------------------------+----------------------------------------------------+

Responses 
-------------

+------------------------+--------------------------+
| Name                   | Description              |
+========================+==========================+
| 204 No Content         | successful operation     |
+------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| DeviceShare.ReadWrite  | Grants user possibility to read and write data connected with device shares   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Update share
^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/deviceshare" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "accessLevel": 1,
            "accessType": 1,
            "repeatEvent": {
                "id": 1,
                "weekDays": 10,
                "dayStartTime": "2020-12-14T08:09:57.781Z",
                "dayEndTime": "2020-12-31T08:10:57.781Z",
                "startDate": null,
                "endDate": null
            },
            "remoteAccessDisabled" : false
        }

**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }