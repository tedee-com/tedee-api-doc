Get single
=========================

Get pin details by provided pin id.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/lock/{id}/pin/{pinId}

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

+------------------------+-----------------------------------------------------------------+----------------------------------------------+
| Name                   | Type                                                            | Description                                  |
+========================+=================================================================+==============================================+
| 200 OK                 | :doc:`Lock PIN details <../../datastructures/lock-pin-details>` | successful operation                         |
+------------------------+-----------------------------------------------------------------+----------------------------------------------+
| 403 Forbidden          |                                                                 | user doesn't have permission to the lock     |
+------------------------+-----------------------------------------------------------------+----------------------------------------------+
| 404 Not Found          |                                                                 | pin not found                                |
+------------------------+-----------------------------------------------------------------+----------------------------------------------+
| 408 Request Timeout    |                                                                 | timeout while fetching data from the device  |
+------------------------+-----------------------------------------------------------------+----------------------------------------------+
| 409 Conflict           |                                                                 | other request is currently processing        |
+------------------------+-----------------------------------------------------------------+----------------------------------------------+

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

Get pin details of pin id 2 for the lock with id 1 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/1/pin/2" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "id": 2,
            "alias": "test pin 2",
            "pin": "192837",
            "startDate": "2021-10-01T00:00:00.000Z",
            "endDate": "2021-12-31T00:00:00.000Z",
            "dayStartTime": "2021-10-01T10:00:00.000Z",
            "dayEndTime": "2021-10-01T18:00:00.000Z",
            "weekDays": 1
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "id": 2,
            "alias": "test pin 2",
            "pin": "192837",
            "startDate": null,
            "endDate": null,
            "dayStartTime": null,
            "dayEndTime": null,
            "weekDays": null
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
