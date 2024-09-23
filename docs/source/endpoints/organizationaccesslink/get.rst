Get organization access link
============================

Show organization access link.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/accesslink/{accessLinkId}

**URI Parameters**

+----------------+--------+------------------------+
| Name           | Type   | Description            |
+================+========+========================+
| organizationId | number | id of the organization |
+----------------+--------+------------------------+
| accessLinkId   | UUID   | id of the access link  |
+----------------+--------+------------------------+

Responses 
-------------

+---------------+-----------------------------------------------------------------------------------------------+------------------------------------+
| Name          | Type                                                                                          | Description                        |
+===============+===============================================================================================+====================================+
| 200 OK        | :doc:`Organization Single Access Link <../../datastructures/organization-access-link-single>` | successful operation               |
+---------------+-----------------------------------------------------------------------------------------------+------------------------------------+
| 404 Not Found |                                                                                               | organization access link not found |
+---------------+-----------------------------------------------------------------------------------------------+------------------------------------+

Scopes
-------------

+----------------------+--------------------------------------------------------------+
| Name                 | Description                                                  |
+======================+==============================================================+
| AccessLink.Read      | Grants user possibility to view organization access links.   |
+----------------------+--------------------------------------------------------------+
| AccessLink.ReadWrite | Grants user possibility to manage organization access links. |
+----------------------+--------------------------------------------------------------+

Examples
-------------

**Sample request for organization with id = 123**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/123/accesslink/10df36b5-a06e-4bec-9398-786b0231453a" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "accessLink":{
                    "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                    "name": "Sample Link",
                    "description": "Building address: 123 Main St, City, State, 12345",
                    "repeatEvent": {
                        "startDate": "2023-04-01T09:00:00.000Z",
                        "endDate": "2023-04-30T09:00:00.000Z"
                    },
                    "devices": [
                        {
                            "id": 1,
                            "name": "Gate",
                            "timeZone": "UTC-8",
                            "order": 1,
                            "deviceType": 5
                        },
                        {
                            "id": 2,
                            "name": "Lock",
                            "timeZone": "UTC-8",
                            "order": 2,
                            "deviceType": 2
                        }
                    ]
                },
                "accessLinkUrl": "https://portal.tedee.com/link/0bbDshXmsgjRdDmU2zwYjR1-iQZOcHJL7TuL9NoXOXgC1iF2zVKVKCquVqbEldmkDSspWJKRlH4JcPk.QMzs4Q__"
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }