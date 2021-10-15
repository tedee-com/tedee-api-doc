Get signed time
====================================

Get signed time, required by Tedee device to secure Bluetooth connection.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/datetime/getsignedtime

Responses 
-------------

+--------+-------------------------------------------------------+----------------------+
| Name   | Type                                                  | Description          |
+========+=======================================================+======================+
| 200 OK | :doc:`Signed time <../../datastructures/signed-time>` | successful operation |
+--------+-------------------------------------------------------+----------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.Read            | Grants user possibility to read data connected with devices             |
+------------------------+-------------------------------------------------------------------------+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Get signed time
^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/datetime/getsignedtime" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "datetime" : "AAABfHgtDbU=",
            "signature" : "MEQCIIa7NtKXDHDzynw0y5Gmi98HrA9UYnBimzXbixzaqoJiAiBDekhYsN7Eo0+d4so79zJFVni25kJJKlDklX04u7gEMA==",
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
