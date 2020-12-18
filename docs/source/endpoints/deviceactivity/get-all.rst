Get all
====================================

Get a list of activities for provided device id.
Results are paged and sorted by date in descending order.

Users with guest access to the device can only see his/her activities and activities without the author (for example manual operations).

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

.. note::
    This endpoint doesn't return all activities that exist. Maximum number of actvities you can get from this endpoint is 200. 
    To get more actvity logs you need to use paging feature in that endpoint. To do that simply use URI parameter lastElemDate. 
    You need to set this parameter a value the same as the date of the last element date from previous page. 
    For first page you can leave this parameter as it's optional and default value is current date in UTC.


Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| DeviceActivity.Read    | Grants user possibility to read device activities                       |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

To better understand the idea of getting activities and paging mechanism we prepared following examples:

* `Get first top activities for device <get-all.html#get-first-top-activities>`_
* `Get next page of activities for device <get-all.html#get-next-page>`_

.. _get-first-top-activities:

Get first top activities for device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Example shows how to get first top activities. We will leave URI parameter lastElemDate and set that we want to receive 3 top activities.

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/deviceactivity?deviceId=2&elements=3" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample Response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": [
            {
                "id": 3,
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
            },
            {
                "id": 1,
                "deviceId": 2,
                "userId": 3,
                "organizationUserId": 1,
                "username": "Test",
                "event": 32,
                "source": 0,
                "date": "2020-11-20T12:50:45.600"
            }
        ],
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }

.. _get-next-page:

Get next page of activities for device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Example shows how to get next page of activities. 
Now we need to specify lastElemDate parameter because we want to receive next elements. 
To do that we take date from the last element from previous example. Also we take 3 activities.

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/deviceactivity?deviceId=2&elements=3&lastElemDate=2020-11-20T12:50:45.600" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample Response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": [
            {
                "id": 6,
                "deviceId": 2,
                "userId": 3,
                "organizationUserId": 1,
                "username": "Test",
                "event": 32,
                "source": 0,
                "date": "2020-11-20T12:49:26.212"
            },
            {
                "id": 5,
                "deviceId": 2,
                "userId": 3,
                "organizationUserId": 1,
                "username": "Test",
                "event": 33,
                "source": 0,
                "date": "2020-11-20T12:23:45.554"
            },
            {
                "id": 4,
                "deviceId": 2,
                "userId": 3,
                "organizationUserId": 1,
                "username": "Test",
                "event": 32,
                "source": 0,
                "date": "2020-11-20T12:10:45.600"
            }
        ],
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }

