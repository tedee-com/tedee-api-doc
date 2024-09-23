Get all
=========================

Get a list of all pins for the given lock.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/lock/{id}/pin?listVersion={listVersion}

**URI Parameters**

+------------------------+-------------------+------------------------------------------+
| Name                   | Type              | Description                              |
+========================+===================+==========================================+
| id                     | number            | id of the lock                           |
+------------------------+-------------------+------------------------------------------+
| listVersion            | number (optional) | last received version of the pin list    | 
+------------------------+-------------------+------------------------------------------+

Responses 
-------------

+------------------------+--------------------------------------------------------------+----------------------------------------------+
| Name                   | Type                                                         | Description                                  |
+========================+==============================================================+==============================================+
| 200 OK                 | :doc:`Lock PIN list <../../datastructures/lock-pin-list>` [] | successful operation                         |
+------------------------+--------------------------------------------------------------+----------------------------------------------+
| 304 Not Modified       |                                                              | provided list version is up to date          |
+------------------------+--------------------------------------------------------------+----------------------------------------------+
| 403 Forbidden          |                                                              | user doesn't have permission to the lock     |
+------------------------+--------------------------------------------------------------+----------------------------------------------+
| 408 Request Timeout    |                                                              | timeout while fetching data from the device  |
+------------------------+--------------------------------------------------------------+----------------------------------------------+
| 409 Conflict           |                                                              | other request is currently processing        |
+------------------------+--------------------------------------------------------------+----------------------------------------------+

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

Get a list of all pins for the lock with id 123 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/123/pin" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "listVersion": 2,
            "pins": [
                {
                    "id": 1,
                    "alias": "test pin 1"
                },
                {
                    "id": 2,
                    "alias": "test pin 2"
                }
            ]
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }

Attempting to get a list of pins after providing the current version of the list 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request for lock with id = 123**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/123/pin?listVersion=2" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``304``

.. code-block:: js

    {
        "success": false,
        "errorMessages": [
            "List version is up to date."
        ],
        "statusCode": 304
    }
