Get all
====================================

Get a list of activities for provided device id.
Results are sorted by date in descending order.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/deviceactivity?deviceId={id}&elements={elements}&lastElemDate={lastElemDate}

**URI Parameters**

+------------------------+----------------------+-----------------------------------------------------------------------------------+
| Name                   | Type                 | Description                                                                       |
+========================+======================+===================================================================================+
| deviceId               | number               | id of device                                                                      |
+------------------------+----------------------+-----------------------------------------------------------------------------------+
| elements               | number (optional)    | number of elements to load (max 200, default 200)                                 |
+------------------------+----------------------+-----------------------------------------------------------------------------------+
| lastElemDate           | datetime (optional)  | when set, only items with a date older than the entered date (in UTC) are shown   |
+------------------------+----------------------+-----------------------------------------------------------------------------------+

Responses 
-------------

+------------------------+---------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                                | Description              |
+========================+=====================================================================+==========================+
| 200 OK                 | :doc:`Device activity <../../datastructures/device-activity>` []    | successful operation     |
+------------------------+---------------------------------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| DeviceActivity.Read    | Grants user possibility to read device activities                       |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

Get a list of activities for device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/deviceactivity?deviceId=2&elements=50&lastElemDate=2020-11-20T16%3A00%3A00.000" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample Response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": [
            {
                "id": 1,
                "deviceId": 2,
                "userId": 3,
                "organizationUserId": 1,
                "username": "Test",
                "event": 32,
                "source": 0,
                "date": "2020-11-20T13:59:26.212"
            },
            {
                "id": 2,
                "deviceId": 2,
                "userId": 3,
                "organizationUserId": 1,
                "username": "Test",
                "event": 33,
                "source": 0,
                "date": "2020-11-20T13:00:45.554"
            }
        ],
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }
