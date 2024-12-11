Delete door sensor
===============================

Deletes the door sensor with the specified id.

After running this endpoint, the door sensor will disappear from your Tedee account.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/my/doorsensor/{id}

**URI Parameters**

+------+--------+-----------------------+
| Name | Type   | Description           |
+======+========+=======================+
| id   | number | id of door sensor     |
+------+--------+-----------------------+

Responses 
-------------

+----------------+-------------------------+
| Name           | Description             |
+================+=========================+
| 204 No Content | successful operation    |
+----------------+-------------------------+
| 404 Not Found  | door sensor not found   |
+----------------+-------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Delete door sensor
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request for door sensor with id = 123**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/doorsensor/123" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

    {   
        "success": true,
        "errorMessages": [],
        "statusCode": 204
    }