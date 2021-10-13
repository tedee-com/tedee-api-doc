How to manage PIN list of the lock
==================================

If you have a lock paired with a keypad and your lock is also paired with a bridge, you can manage pins using API.
In this tutorial we will walk through the process of listing, creating, updating and deleting pin for lock device.

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