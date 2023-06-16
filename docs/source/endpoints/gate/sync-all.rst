Sync all
=========================

Sync all users gates with BleBox.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/gate/sync

Responses 
-------------

+------------------------+--------------------------+
| Name                   | Description              |
+========================+==========================+
| 204 No Content         | successful operation     |
+------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Sync user gates
^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/gate/sync" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }