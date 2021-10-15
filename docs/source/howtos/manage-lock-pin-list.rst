How to manage PIN list of the lock
==================================

If you have a lock paired with a keypad and your lock is also paired with a bridge, you can manage pins using API.
In this tutorial we will walk through the process of listing, creating, updating, and deleting pins for the lock device.

Get current pin list
--------------------

If you want to get the current pin list for the lock, you will need deviceId and use :doc:`Get all pins <../endpoints/lockpin/get-all>` endpoint. 

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/1/pin" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

This endpoint will return all pins for the given lock.

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

Along with the pins, the version of the list is also returned. 
After each pin operation, such as creating, updating or deleting, the version of the pin list is incremented.

When getting the pins, you can optionally provide the last received version of the pin list.
If there is a newer version of the list on the device, all pins will be returned, otherwise the response code 304 Not Modified will be returned. 

**Sample request with a list version parameter**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/1/pin?listVersion=2" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response when the provided version of the list is up-to-date**

HTTP status code: ``304``

.. code-block:: js

    {
        "success": false,
        "errorMessages": [
            "List version is up to date."
        ],
        "statusCode": 304
    }

**Sample response when a newer version of the list is available**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "listVersion": 3,
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


Get pin details
---------------

If you want to get details of a selected pin, you will need deviceId along with pinId and use :doc:`Get single pin <../endpoints/lockpin/get-single>` endpoint.

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/lock/1/pin/2" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

This endpoint will return pin details.

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


Create a new pin
----------------

If you want to add a new pin for the given lock, you will need deviceId and use :doc:`Create pin <../endpoints/lockpin/create>` endpoint.

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/lock/1/pin" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

This endpoint will return Id of the created pin.

Create a pin with permanent access to the lock
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

If you want to have a pin with permanent access to the lock, you only need to send pin alias and pin value:

Body:

.. code-block:: js

        {
            "alias": "test pin 3",
            "pin": "918273"
        }

Create a pin with time restricted access to the lock
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

If you want to restrict pin access to the lock you can send fields "startDate" or "endDate", it will mark the period when pin will be active.
You can also restrict access to specific hours of the day by sending "dayStartTime" and "dayEndTime". You can further customize this by selecting days. 
To send it proper way you need to use :doc:`Week days <../enums/week-days>` enum. 

In this case the created pin will be active from 1 October to 31 December:

Body:

.. code-block:: js

        {
            "alias": "test pin 3",
            "pin": "918273",
            "startDate": "2021-10-01T00:00:00.000Z",
            "endDate": "2021-12-31T00:00:00.000Z",
            "dayStartTime": null,
            "dayEndTime": null,
            "weekDays": null
        }

In this case the created pin will be active from 1 October to 31 December, and also will have access only on friday and saturday between 10:00 and 18:00:

Body:

.. code-block:: js

        {
            "alias": "test pin 3",
            "pin": "918273",
            "startDate": "2021-10-01T00:00:00.000Z",
            "endDate": "2021-12-31T00:00:00.000Z",
            "dayStartTime": "2021-10-01T10:00:00.000Z",
            "dayEndTime": "2021-12-31T18:00:00.000Z",
            "weekDays": 48
        }

In this case the created pin will be active only from monday to friday between 8:00 and 16:00:

Body:

.. code-block:: js

        {
            "alias": "test pin 3",
            "pin": "918273",
            "startDate": null,
            "endDate": null,
            "dayStartTime": "2021-10-01T08:00:00.000Z",
            "dayEndTime": "2021-10-01T16:00:00.000Z",
            "weekDays": 31
        }


Update selected pin
-------------------

If you want to update the selected pin for the given lock, you will need deviceId and pinId. 
Before making any changes you should read the pin details to have complete information about the pin. To do that use :doc:`Get single pin <../endpoints/lockpin/get-single>` endpoint.
Once you have all, you can send the updated information to the endpoint :doc:`Update pin <../endpoints/lockpin/update>` to update the pin.

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


Delete pin
----------

If you want to delete selected pin for the given lock, you will need deviceId along with pinId and use :doc:`Delete pin <../endpoints/lockpin/delete>` endpoint.

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/lock/1/pin/2" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"
