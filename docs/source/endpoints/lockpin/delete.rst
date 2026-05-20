Delete
=========================

Deletes selected pin for the given lock.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/my/lock/{id}/pin/{pinId}

.. note::
    Pins created with an ``endDate`` are automatically removed from the system once they expire.
    You do not need to call this endpoint to clean up time-restricted pins — deletion is only necessary
    when you want to remove a pin before its expiration date, or when removing a permanent pin.

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

+-----------------------------+----------------------------------------------------------------+
| Name                        | Description                                                    |
+=============================+================================================================+
| 204 No Content              | successful operation                                           |
+-----------------------------+----------------------------------------------------------------+
| 403 Forbidden               | user doesn't have permission to the lock                       |
+-----------------------------+----------------------------------------------------------------+
| 404 Not Found               | pin not found                                                  |
+-----------------------------+----------------------------------------------------------------+
| 408 Request Timeout         | timeout while sending data to the device                       |
+-----------------------------+----------------------------------------------------------------+
| 409 Conflict                | another request is currently being processed for this device   |
+-----------------------------+----------------------------------------------------------------+
| 428 Precondition Required   | lock is disconnected or device setup is incorrect              |
+-----------------------------+----------------------------------------------------------------+

Scopes
-------------

+--------------------+-------------------------------------------------------------------------------+
| Name               | Description                                                                   |
+====================+===============================================================================+
| Device.ReadWrite   | Grants user possibility to read and write data connected with devices         |
+--------------------+-------------------------------------------------------------------------------+

Examples
-------------

Delete pin with id 2 for the lock with id 123
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/lock/123/pin/2" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {   
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }
