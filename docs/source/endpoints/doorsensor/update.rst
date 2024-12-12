Update
=========================

Updates the door sensor with the specified id.

.. code-block:: sh

    PATCH |apiUrl|/api/|apiVersion|/my/doorsensor/{id}

**URI Parameters**

+------+--------+-----------------------+
| Name | Type   | Description           |
+======+========+=======================+
| id   | number | id of the door sensor |
+------+--------+-----------------------+

**Body Parameters**

+---------------------------+----------------------------------------------------------------------------------------------+----------------------------------------------------+
| Name                      | Type                                                                                         | Description                                        |
+===========================+==============================================================================================+====================================================+
| revision                  | number                                                                                       | current revision of door sensor configuration      |
+---------------------------+----------------------------------------------------------------------------------------------+----------------------------------------------------+
| name                      | string (optional)                                                                            | door sensor name                                   |
+---------------------------+----------------------------------------------------------------------------------------------+----------------------------------------------------+
| timeZone                  | datetime (optional)                                                                          | timezone of door sensor                            |
+---------------------------+----------------------------------------------------------------------------------------------+----------------------------------------------------+
| userSettings              | :doc:`Door sensor user settings <../../datastructures/door-sensor-user-settings>` (optional) | settings of current user for that device           |
+---------------------------+----------------------------------------------------------------------------------------------+----------------------------------------------------+

All parameters in this endpoint (except id and revision) are optional. 
This means that specifying a given parameter will update its value. If a given parameter is not specified, its value will not change.

Only the owner or admin can update name and time zone. Guest can only modify user settings.

Responses 
-------------

+------------------------+-------------------------------------------------------------+----------------------------------------------------+
| Name                   | Type                                                        | Description                                        |
+========================+=============================================================+====================================================+
| 200 OK                 | :doc:`Device updated <../../datastructures/device-updated>` | successful operation                               |
+------------------------+-------------------------------------------------------------+----------------------------------------------------+
| 409 Conflict           |                                                             | revision in request is different than in database  |
+------------------------+-------------------------------------------------------------+----------------------------------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Update name of the door sensor
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Example shows how to update name of the door sensor with id = 123. Only owner or admin can update name of the device.

**Sample Request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/doorsensor/123" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "revision": 1,
            "name": "New Name"
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "id": 123,
            "revision": 2,
            "targetDeviceRevision": 1
        }
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
