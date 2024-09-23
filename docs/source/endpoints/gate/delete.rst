Delete gate
===============================

Deletes the gate with specified id.

After running this endpoint, the gate will disappear from your Tedee account.

.. warning::

    The gate will be added as a new device during the next synchronization between the Tedee and Blebox systems. If you want to delete the gate permanently, you must delete it from your BleBox account first.

If you want to get familiar with the whole flow how to manage and operate gates, please refer to our tutorial: :doc:`How to manage and operate gates <../../howtos/manage-and-operate-gates>`.

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

**Sample request for gate with id = 123**

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