Update
=========================

Updates selected pin for the given lock.

.. code-block:: sh

    PUT |apiUrl|/api/|apiVersion|/my/lock/{id}/pin/{pinId}

**URI Parameters**

+------------------------+-------------------+------------------------------------------+
| Name                   | Type              | Description                              |
+========================+===================+==========================================+
| id                     | number            | id of the lock                           |
+------------------------+-------------------+------------------------------------------+
| pinId                  | number            | id of the pin                            | 
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

+-------------------------+----------------------------------------------+
| Name                    | Description                                  |
+=========================+==============================================+
| 204 No Content          | successful operation                         |
+-------------------------+----------------------------------------------+
| 404 Not Found           | pin not found                                |
+-------------------------+----------------------------------------------+
| 406 Not Acceptable      | pin already exists                           |
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

.. note::
    Pin value must meet the following requirements:

    - pin cannot be null, empty, or whitespace
    - pin length must be in range 5-8
    - pin can contain only numeric values (0-9)
    - pin must contain at least 3 different digits
    - pin cannot be built as ascending or descending sequence


Examples
-------------

Update pin with id 2 for the lock with id 1 (permanent access)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X PUT "|apiUrl|/api/|apiVersion|/my/lock/1/pin/2" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "alias": "new test pin 2",
            "pin": "827364"
        }

**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {   
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }

Update pin with id 2 for the lock with id 1 (restricted access)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X PUT "|apiUrl|/api/|apiVersion|/my/lock/1/pin/2" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "alias": "new test pin 2",
            "pin": "827364",
            "startDate": "2021-10-01T00:00:00.000Z",
            "endDate": "2021-12-31T00:00:00.000Z",
            "dayStartTime": "2021-10-01T10:00:00.000Z",
            "dayEndTime": "2021-10-01T18:00:00.000Z",
            "weekDays": 1
        }

**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {   
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }
