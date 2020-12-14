Delete
=========================

Delete share for device

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/my/deviceshare/{deviceShareId}

**URI Parameters**

+---------------------------+-----------+--------------------------+
| Name                      | Type      |    Description           | 
+===========================+===========+==========================+
| deviceShareId             | number    | id of share to delete    |
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
| DeviceShare.ReadWrite  | Grants user possibility to read and write data connected with device shares   |
+------------------------+-------------------------------------------------------------------------------+

Examples
-------------

Delete share
^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/deviceshare/15" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>"



**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }