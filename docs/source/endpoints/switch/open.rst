Open
=========================

Send a command to open the switch with provided id.

The switch triggers the output selected in ``deviceSettings.openActionOutput`` for the impulse length configured for that output.
The switch is connected to the Tedee cloud over Wi-Fi, so no external integration is needed.

Running this operation requires active permission to the switch with remote access enabled.

If you want to get familiar with the whole flow how to manage and operate switches, please refer to our tutorial: :doc:`How to manage and operate switches <../../howtos/manage-and-operate-switches>`.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/switch/{id}/operation/open

**URI Parameters**

+--------+--------+--------------+
| Name   | Type   | Description  |
+========+========+==============+
| id     | number | id of switch |
+--------+--------+--------------+

Responses
-------------

+-----------------------------+-----------------------------------------------------------------------------+
| Name                        | Description                                                                 |
+=============================+=============================================================================+
| 204 No Content              | Successful operation                                                        |
+-----------------------------+-----------------------------------------------------------------------------+
| 403 Forbidden               | The user's access to the switch is not active or has remote access disabled |
+-----------------------------+-----------------------------------------------------------------------------+
| 404 Not Found               | Switch not found or user has no access to it                                |
+-----------------------------+-----------------------------------------------------------------------------+
| 423 Locked                  | Switch is disconnected                                                      |
+-----------------------------+-----------------------------------------------------------------------------+
| 412 Precondition Failed     | The switch rejected the request (missing user)                              |
+-----------------------------+-----------------------------------------------------------------------------+
| 415 Unsupported Media Type  | The switch firmware does not support the open operation                     |
+-----------------------------+-----------------------------------------------------------------------------+
| 502 Bad Gateway             | The switch returned an unexpected error                                     |
+-----------------------------+-----------------------------------------------------------------------------+
| 503 Service Unavailable     | The switch did not respond                                                  |
+-----------------------------+-----------------------------------------------------------------------------+
| 506 Variant Also Negotiates | The switch could not trigger the output (output error)                      |
+-----------------------------+-----------------------------------------------------------------------------+

Scopes
-------------

+------------------+-----------------------------------------------------------------------+
| Name             | Description                                                           |
+==================+=======================================================================+
| Device.ReadWrite | Grants user possibility to read and write data connected with devices |
+------------------+-----------------------------------------------------------------------+
| Lock.Operate     | Grants user possibility to operate locks                              |
+------------------+-----------------------------------------------------------------------+

Example
-------------

Open the switch
^^^^^^^^^^^^^^^^^^

**Sample request for switch with id = 123**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/switch/123/operation/open" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``204``

.. code-block:: js

    {
        "success": true,
        "errorMessages": [],
        "statusCode": 204
    }
