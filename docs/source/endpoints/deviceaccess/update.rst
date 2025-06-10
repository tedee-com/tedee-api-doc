Update
=========================

Allows to update access details to the device for specific access.
This endpoint can be used by owner or administrator of the device.

.. code-block:: sh

    PUT |apiUrl|/api/|apiVersion|/my/device/{deviceId}/access/{accessId}

**Body Parameters**

+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| Name                      | Type                                                                      | Description                                          |
+===========================+===========================================================================+======================================================+
| accessLevel               | :doc:`Access level <../../enums/access-level>`                            | represents user access level                         |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| dayEndTime                | datetime                                                                  | end time of the day when user can access the device  |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| dayStartTime              | datetime                                                                  | start time of the day when user can access the device|
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| endDate                   | datetime                                                                  | end date of period when user can access the device   |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| remoteAccessDisabled      | boolean                                                                   | represents if remote access is disabled              |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| startDate                 | datetime                                                                  | start date of period when user can access the device |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+
| weekDays                  | number                                                                    | allowed week days when user can access the device    |
+---------------------------+---------------------------------------------------------------------------+------------------------------------------------------+

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
| DeviceShare.ReadWrite | Grants user possibility to read and write data connected with device access   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Update access
^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X PUT "|apiUrl|/api/|apiVersion|/my/device/{deviceId}/access/{accessId}" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "accessLevel": 1,
            "weekDays": 10,
            "dayStartTime": "2020-12-14T08:09:57.781Z",
            "dayEndTime": "2020-12-31T08:10:57.781Z",
            "startDate": null,
            "endDate": null,
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