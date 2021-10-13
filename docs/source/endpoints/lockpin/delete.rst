Delete
=========================

Deletes selected pin for the given lock.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/my/lock/{id}/pin/{pinId}

**URI Parameters**

+------------------------+-------------------+------------------------------------------+
| Name                   | Type              | Description                              |
+========================+===================+==========================================+
| id                     | number            | id of the lock                           |
+------------------------+-------------------+------------------------------------------+
| pinId                  | number            | id of the pin                            | 
+------------------------+-------------------+------------------------------------------+

Responses 
-------------

+-------------------------+----------------------------------------------+
| Name                    | Description                                  |
+=========================+==============================================+
| 204 No Content          | successful operation                         |
+-------------------------+----------------------------------------------+
| 404 Not Found           | pin not found                                |
+-------------------------+----------------------------------------------+
| 408 Request Timeout     | timeout while sending data to the device     |
+-------------------------+----------------------------------------------+
| 409 Conflict            | other request is currently processing        |
+-------------------------+----------------------------------------------+

Scopes
-------------

+--------------------+-------------------------------------------------------------------------------+
| Name               | Description                                                                   |
+====================+===============================================================================+
| Device.ReadWrite   | Grants user possibility to read and write data connected with devices         |
+--------------------+-------------------------------------------------------------------------------+

Examples
-------------

Delete pin with id 2 for the lock with id 1
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/lock/1/pin/2" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {   
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }
