Update organization access link
===============================

Updates an organization access link.

.. code-block:: sh

    PATCH |apiUrl|/api/|apiVersion|/organization/{organizationId}/accesslink/{accessLinkId}

**URI Parameters**

+----------------+--------+------------------------+
| Name           | Type   | Description            |
+================+========+========================+
| organizationId | number | id of the organization |
+----------------+--------+------------------------+
| accessLinkId   | UUID   | id of the access link  |
+----------------+--------+------------------------+

**Body Parameters**

+-------------+--------------------------------------------------------------------+---------------------------------------------------+
| Name        | Type                                                               | Description                                       |
+=============+====================================================================+===================================================+
| name        | string (optional)                                                  | access link name (visible only during management) |
+-------------+--------------------------------------------------------------------+---------------------------------------------------+
| description | string (optional, multiline)                                       | access link description for guests                |
+-------------+--------------------------------------------------------------------+---------------------------------------------------+
| devicesIds  | int [] (optional)                                                  | array of devices included in the access link      |
+-------------+--------------------------------------------------------------------+---------------------------------------------------+
| repeatEvent | :doc:`Repeat event <../../datastructures/repeat-event>` (optional) | repeat event of the access link                   |
+-------------+--------------------------------------------------------------------+---------------------------------------------------+

Responses 
-------------

+-----------------+------+-----------------------------------------------------------------+
| Name            | Type | Description                                                     |
+=================+======+=================================================================+
| 200 OK          |      | successful operation                                            |
+-----------------+------+-----------------------------------------------------------------+
| 400 Bad Request |      | request model is not valid                                      |
+-----------------+------+-----------------------------------------------------------------+
| 404 Not found   |      | organization does not exist or user is not allowed to manage it |
+-----------------+------+-----------------------------------------------------------------+

Scopes
-------------

+-----------------------+-------------------------------------------------------------+
| Name                  | Description                                                 |
+=======================+=============================================================+
| AccessLink.ReadWrite | Grants user possibility to manage organization access links |
+-----------------------+-------------------------------------------------------------+

.. note::
    Access links requirements:

    - description must be in range 0-72 characters
    - deviceIds must contain at least one device
    - deviceIds must contain distinct device ids
    - user must be at least organization admin to perform this operation


.. note::
    We do not recommend to create access links with permanent access.

Examples
-------------

Update organization access link
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/organization/1/accesslink/10df36b5-a06e-4bec-9398-786b0231453a" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "repeatEvent": {
                "startDate": "2023-02-01T00:00:00.000Z",
                "endDate": "2023-03-01T00:00:00.000Z"
            }
        }

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }
