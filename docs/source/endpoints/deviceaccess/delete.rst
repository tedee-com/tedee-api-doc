Delete
=========================

This endpoint allows to remove access to the device from the user. 
To remove access from user you need to be owner or administrator of the device.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/my/device/{deviceId}/access/{accessId}

**URI Parameters**

+---------------------------+-----------+--------------------------+
| Name                      | Type      |    Description           | 
+===========================+===========+==========================+
| accessId                  | number    | id of access to delete   |
+---------------------------+-----------+--------------------------+
| deviceId                  | number    | id of device             |
+---------------------------+-----------+--------------------------+


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

Remove access to the device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/device/1/access/15" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>"



**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }