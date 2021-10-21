Create
=========================

Creates a new pin for the given lock.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/lock/{id}/pin

**URI Parameters**

+------------------------+-------------------+------------------------------------------+
| Name                   | Type              | Description                              |
+========================+===================+==========================================+
| id                     | number            | id of the lock                           |
+------------------------+-------------------+------------------------------------------+

**Body Parameters**

+--------------------+-----------------------+-------------------------------------------------------+
| Name               | Type                  | Description                                           |
+====================+=======================+=======================================================+
| alias              | string                | name of the pin                                       |
+--------------------+-----------------------+-------------------------------------------------------+
| dayEndTime         | datetime (optional)   | end time when pin has access to the device            |
+--------------------+-----------------------+-------------------------------------------------------+
| dayStartTime       | datetime (optional)   | start time when pin has access to the device          |
+--------------------+-----------------------+-------------------------------------------------------+
| endDate            | datetime (optional)   | end date when pin has access to the device            |
+--------------------+-----------------------+-------------------------------------------------------+
| pin                | string                | value of the pin                                      |
+--------------------+-----------------------+-------------------------------------------------------+
| startDate          | datetime (optional)   | start date when pin has access to the device          |
+--------------------+-----------------------+-------------------------------------------------------+
| weekDays           | number (optional)     | week days when pin has access to the device           |
+--------------------+-----------------------+-------------------------------------------------------+

Responses 
-------------

+-------------------------+-----------------------------------------------------------------+----------------------------------------------+
| Name                    | Type                                                            | Description                                  |
+=========================+=================================================================+==============================================+
| 201 Created             | :doc:`Pin created <../../datastructures/lock-pin-created>`      | successful operation                         |
+-------------------------+-----------------------------------------------------------------+----------------------------------------------+
| 403 Forbidden           |                                                                 | user doesn't have permission to the lock     |
+-------------------------+-----------------------------------------------------------------+----------------------------------------------+
| 406 Not Acceptable      |                                                                 | pin already exists                           |
+-------------------------+-----------------------------------------------------------------+----------------------------------------------+
| 408 Request Timeout     |                                                                 | timeout while sending data to the device     |
+-------------------------+-----------------------------------------------------------------+----------------------------------------------+
| 409 Conflict            |                                                                 | other request is currently processing        |
+-------------------------+-----------------------------------------------------------------+----------------------------------------------+
| 422 Unprocessable Entity|                                                                 | adding more pins is not available            |
+-------------------------+-----------------------------------------------------------------+----------------------------------------------+

Scopes
-------------

+--------------------+-------------------------------------------------------------------------------+
| Name               | Description                                                                   |
+====================+===============================================================================+
| Device.ReadWrite   | Grants user possibility to read and write data connected with devices         |
+--------------------+-------------------------------------------------------------------------------+

.. note::
    Pin value must meet the following requirements:

    - pin cannot be null, empty, or whitespace
    - pin length must be in range 5-8
    - pin can contain only numeric values (0-9)
    - pin must contain at least 3 different digits
    - pin cannot be built as ascending or descending sequence


Examples
-------------

Create a pin with permanent access to the lock with id 1 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/1/pin" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "alias": "test pin 3",
            "pin": "918273"
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "result": {
                "id": 3
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }

Create a pin with restricted access to the lock with id 1 
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/1/pin" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "alias": "test pin 3",
            "pin": "918273",
            "startDate": "2021-10-01T00:00:00.000Z",
            "endDate": "2021-12-31T00:00:00.000Z",
            "dayStartTime": "2021-10-01T10:00:00.000Z",
            "dayEndTime": "2021-10-01T18:00:00.000Z",
            "weekDays": 1
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "result": {
                "id": 3
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }
