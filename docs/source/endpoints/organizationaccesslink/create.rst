Create organization access link
===============================

Creates a new organization access link.

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/organization/{organizationId}/accesslink

.. warning:: 
    We do not recommend to create access links with permanent access.

**URI Parameters**

+----------------+--------+------------------------+
| Name           | Type   | Description            |
+================+========+========================+
| organizationId | number | id of the organization |
+----------------+--------+------------------------+

**Body Parameters**

+-------------+--------------------------------------------------------------------+---------------------------------------------------+
| Name        | Type                                                               | Description                                       |
+=============+====================================================================+===================================================+
| name        | string                                                             | access link name (visible only during management) |
+-------------+--------------------------------------------------------------------+---------------------------------------------------+
| description | string (optional, multiline)                                       | access link description for guests                |
+-------------+--------------------------------------------------------------------+---------------------------------------------------+
| devicesIds  | int []                                                             | array of devices included in the access link      |
+-------------+--------------------------------------------------------------------+---------------------------------------------------+
| repeatEvent | :doc:`Repeat event <../../datastructures/repeat-event>` (optional) | repeat event of the access link                   |
+-------------+--------------------------------------------------------------------+---------------------------------------------------+

.. note::
    Access links requirements:

    - * description must be in range 0-72 characters
    - deviceIds must contain at least one device
    - deviceIds must contain distinct device ids
    - user must be at least organization admin to perform this operation

.. note::
    Dates sent to Tedee API must be in the UTC timezone. The client must convert the date to UTC before sending it to the API.

Responses 
-------------

+-----------------+------------------------------------------------------------------------------------+-----------------------------------------------------------------+
| Name            | Type                                                                               | Description                                                     |
+=================+====================================================================================+=================================================================+
| 201 Created     | :doc:`Access Link created <../../datastructures/organization-access-link-created>` | successful operation                                            |
+-----------------+------------------------------------------------------------------------------------+-----------------------------------------------------------------+
| 400 Bad Request |                                                                                    | request model is not valid                                      |
+-----------------+------------------------------------------------------------------------------------+-----------------------------------------------------------------+
| 404 Not found   |                                                                                    | organization does not exist or user is not allowed to manage it |
+-----------------+------------------------------------------------------------------------------------+-----------------------------------------------------------------+

Scopes
-------------

+----------------------+-------------------------------------------------------------+
| Name                 | Description                                                 |
+======================+=============================================================+
+----------------------+-------------------------------------------------------------+
| Name                 | Description                                                 |
+======================+=============================================================+
| AccessLink.ReadWrite | Grants user possibility to manage organization access links |
+----------------------+-------------------------------------------------------------+

Examples
-------------

Create organization access link for organization with id 1 with restricted access
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/organization/1/accesslink" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "name": "test pin 3",
            "description": "918273",
            "deviceIds": [
                123,
                223
            ],
            "repeatEvent": {
                "startDate": "2023-01-01T00:00:00.000Z",
                "endDate": "2023-02-01T00:00:00.000Z"
            }
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "result": {
                "id": 10df36b5-a06e-4bec-9398-786b0231453a,
                "url" "https://portal.tedee.com/link/0bbDshXmsgjRdDmU2zwYjR1-iQZOcHJL7TuL9NoXOXgC1iF2zVKVKCquVqbEldmkDSspWJKRlH4JcPk.QMzs4Q__"
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }
