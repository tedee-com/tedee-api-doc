Unlock
=========================

Send a command to unlock the gate with provided id.

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

+-------------------------+-----------------------------------------------------------------------------+
| Name                    | Description                                                                 |
+=========================+=============================================================================+
| 204 No Content          | Successful operation                                                        |
+-------------------------+-----------------------------------------------------------------------------+
| 400 Bad Request         | The user doesn't have active BleBox integration, the gate is disconnected   |
+-------------------------+-----------------------------------------------------------------------------+
| 403 Forbidden           | The user doesn't have permission to the gate                                |
+-------------------------+-----------------------------------------------------------------------------+
| 404 Not Found           | Gate not found                                                              |
+-------------------------+-----------------------------------------------------------------------------+

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

Unlock the gate with id 1
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