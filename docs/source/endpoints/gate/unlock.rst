Unlock
=========================

Send a command to unlock the gate with provided id.

Running this operation requires the user to have active BleBox integration and active permission to the gate.

After successful operation, the gate will be unlocked.

If you want to get familiar with the whole flow how to manage and operate gates, please refer to our tutorial: :doc:`How to manage and operate gates <../../howtos/manage-and-operate-gates>`.

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

+--------------------------+-------------------------------------------------------------+
| Name                     | Description                                                 |
+==========================+=============================================================+
| 204 No Content           | Successful operation                                        |
+--------------------------+-------------------------------------------------------------+
| 403 Forbidden            | The user doesn't have active permission (share) to the gate |
+--------------------------+-------------------------------------------------------------+
| 404 Not Found            | Gate not found                                              |
+--------------------------+-------------------------------------------------------------+
| 412 Precondition Failed  | The user doesn't have active BleBox integration             |
+--------------------------+-------------------------------------------------------------+
| 423 Locked               | Gate is disconnected                                        |
+--------------------------+-------------------------------------------------------------+

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

Unlock the gate
^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/gate/123/operation/unlock" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

    {
        "success": true,
        "errorMessages": [],
        "statusCode": 204
    }