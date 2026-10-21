Update
=========================

Updates the switch with the specified id.

If you want to get familiar with the whole flow how to manage and operate switches, please refer to our tutorial: :doc:`How to manage and operate switches <../../howtos/manage-and-operate-switches>`.

.. code-block:: sh

    PATCH |apiUrl|/api/|apiVersion|/my/switch/{id}

**URI Parameters**

+--------+--------+------------------+
| Name   | Type   | Description      |
+========+========+==================+
| id     | number | id of the switch |
+--------+--------+------------------+

**Body Parameters**

+----------------+----------------------------------------------------------------------------------------+------------------------------------------+
| Name           | Type                                                                                   | Description                              |
+================+========================================================================================+==========================================+
| revision       | number                                                                                 | current revision of switch configuration |
+----------------+----------------------------------------------------------------------------------------+------------------------------------------+
| name           | string (optional)                                                                      | switch name (1-32 characters)            |
+----------------+----------------------------------------------------------------------------------------+------------------------------------------+
| timeZone       | string (optional)                                                                      | timezone of switch                       |
+----------------+----------------------------------------------------------------------------------------+------------------------------------------+
| icon           | :doc:`Gate icon <../../enums/gate-icon>` (optional)                                    | icon presented for the switch            |
+----------------+----------------------------------------------------------------------------------------+------------------------------------------+
| deviceSettings | :doc:`Switch device settings <../../datastructures/switch-device-settings>` (optional) | settings loaded onto the device          |
+----------------+----------------------------------------------------------------------------------------+------------------------------------------+
| userSettings   | :doc:`Switch user settings <../../datastructures/switch-user-settings>` (optional)     | settings of current user for that device |
+----------------+----------------------------------------------------------------------------------------+------------------------------------------+

All parameters in this endpoint (except id and revision) are optional.
This means that specifying a given parameter will update its value. If a given parameter is not specified, its value will not change.
Outputs not provided in ``deviceSettings`` are left unchanged.

Only the owner or admin can update name, time zone, icon and device settings. Guest can only modify user settings.

Responses
-------------

+-----------------+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| Name            | Type                                                            | Description                                                                                                              |
+=================+=================================================================+==========================================================================================================================+
| 200 OK          | :doc:`Device updated <../../datastructures/device-updated>`     | successful operation                                                                                                     |
+-----------------+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| 400 Bad Request | :doc:`Validation error <../../datastructures/validation-error>` | request model is not valid                                                                                               |
+-----------------+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| 403 Forbidden   |                                                                 | guest share is not active or guest tries to change device settings                                                       |
+-----------------+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| 404 Not Found   |                                                                 | switch not found or user has no access to it                                                                             |
+-----------------+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| 409 Conflict    |                                                                 | revision in request is different than in database, or mode is changed to ``Gate`` while the switch is paired with a lock |
+-----------------+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------+

Scopes
-------------

+------------------+-----------------------------------------------------------------------+
| Name             | Description                                                           |
+==================+=======================================================================+
| Device.ReadWrite | Grants user possibility to read and write data connected with devices |
+------------------+-----------------------------------------------------------------------+

Examples
-------------

Update name and icon of the switch
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Example shows how to update name and icon of the switch with id = 123. Only owner or admin can update name and icon of the device.

**Sample Request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/switch/123" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "revision": 3,
            "name": "Garage",
            "icon": 3
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "id": 123,
            "revision": 4,
            "targetDeviceRevision": 4
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }

Update impulse length of the first output
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Example shows how to set the impulse length of the first output to 5 seconds. The second output is not changed.

**Sample Request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/switch/123" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "revision": 4,
            "deviceSettings": {
                "output1": {
                    "impulseLength": 5
                }
            }
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "id": 123,
            "revision": 5,
            "targetDeviceRevision": 5
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
