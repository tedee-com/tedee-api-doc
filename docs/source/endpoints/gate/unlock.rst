Unlock
=========================

Send command to unlock the device by provided id.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/gate/{id}/operation/unlock
    
**URI Parameters**

+------------------------+---------------------------------------------------------+-----------------------------+
| Name                   | Type                                                    | Description                 |
+========================+=========================================================+=============================+
| id                     | number                                                  | id of gate                  |
+------------------------+---------------------------------------------------------+-----------------------------+

Responses 
-------------

+-------------------------+---------------------------------------------------------------------+
| Name                    | Description                                                         |
+=========================+=====================================================================+
| 204 No Content          | successful operation                                                |
+-------------------------+---------------------------------------------------------------------+
| 400 Bad Request         | user doesn't have active BleBox integration, gate is disconnected   |
+-------------------------+---------------------------------------------------------------------+
| 403 Forbidden           | user doesn't have permission to the gate                            |
+-------------------------+---------------------------------------------------------------------+
| 404 Not Found           | gate not found                                                      |
+-------------------------+---------------------------------------------------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------------+
| Name                   | Description                                                                   |
+========================+===============================================================================+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices         |
+------------------------+-------------------------------------------------------------------------------+
| Lock.Operate           | Grants user possibility to operate locks                                      |
+------------------------+-------------------------------------------------------------------------------+

Example
-------------

Unlock gate with id 1
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/gate/1/operation/unlock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

    {
        "success": true,
        "errorMessages": [],
        "statusCode": 204
    }