Get organization access links
=============================

Show organization access links.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/accesslink

**URI Parameters**

+-------------------+-------------------+------------------------------------------------------------+
| Name              | Type              | Description                                                |
+===================+===================+============================================================+
| organizationId    | number            | id of the organization                                     |
+-------------------+-------------------+------------------------------------------------------------+
| page              | number            | page number                                                |
+-------------------+-------------------+------------------------------------------------------------+
| itemsPerPage      | number (optional) | number of elements to load (max 100, default 100)          |
+-------------------+-------------------+------------------------------------------------------------+
| filters.LinkName  | string (optional) | filtering by access link name                              |
+-------------------+-------------------+------------------------------------------------------------+
| filters.DeviceId  | int [] (optional) | filtering by devices included in organization access links |
+-------------------+-------------------+------------------------------------------------------------+
| filters.StartDate | date (optional)   | access link start date                                     |
+-------------------+-------------------+------------------------------------------------------------+
| filters.EndDate   | date (optional)   | access link end date                                       |
+-------------------+-------------------+------------------------------------------------------------+

Responses 
-------------

+--------+-------------------------------------------------------------------------------------------+----------------------+
| Name   | Type                                                                                      | Description          |
+========+===========================================================================================+======================+
| 200 OK | :doc:`Organization Access Link List <../../datastructures/organization-access-link-list>` | successful operation |
+--------+-------------------------------------------------------------------------------------------+----------------------+

Scopes
-------------

+-----------------------+--------------------------------------------------------------+
| Name                  | Description                                                  |
+=======================+==============================================================+
| AccessLinks.Read      | Grants user possibility to view organization access links.   |
+-----------------------+--------------------------------------------------------------+
| AccessLinks.ReadWrite | Grants user possibility to manage organization access links. |
+-----------------------+--------------------------------------------------------------+

Examples
-------------

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/accesslink" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "items": [
                    {
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
                        }
                ],
                "page": 1,
                "itemsPerPage": 25
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }