Delete switch
===============================

Deletes the switch with specified id.

After running this endpoint, the switch will disappear from your Tedee account. Only the owner or an organization admin can delete the switch.

If you want to get familiar with the whole flow how to manage and operate switches, please refer to our tutorial: :doc:`How to manage and operate switches <../../howtos/manage-and-operate-switches>`.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/my/switch/{id}

**URI Parameters**

+--------+--------+--------------+
| Name   | Type   | Description  |
+========+========+==============+
| id     | number | id of switch |
+--------+--------+--------------+

Responses
-------------

+----------------+------------------------------------------------------+
| Name           | Description                                          |
+================+======================================================+
| 204 No Content | successful operation                                 |
+----------------+------------------------------------------------------+
| 404 Not Found  | switch not found or user is not allowed to delete it |
+----------------+------------------------------------------------------+

Scopes
-------------

+------------------+-----------------------------------------------------------------------+
| Name             | Description                                                           |
+==================+=======================================================================+
| Device.ReadWrite | Grants user possibility to read and write data connected with devices |
+------------------+-----------------------------------------------------------------------+

Examples
-------------

Delete switch
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request for switch with id = 123**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/switch/123" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }
