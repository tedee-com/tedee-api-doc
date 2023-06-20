Delete gate
===============================

Deletes the gate with specified id.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/my/gate/{id}

**URI Parameters**

+------+--------+-----------------------+
| Name | Type   | Description           |
+======+========+=======================+
| id   | number | id of gate            |
+------+--------+-----------------------+

Responses 
-------------

+----------------+-----------------------+
| Name           | Description           |
+================+=======================+
| 204 No Content | successful operation  |
+----------------+-----------------------+
| 404 Not Found  | gate not found        |
+----------------+-----------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Delete gate
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/gate/123" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {   
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }