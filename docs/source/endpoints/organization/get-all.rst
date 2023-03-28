Get all
=========================

Show organizations the user is admin of.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization?dataScope={dataScope}&page={page}&itemsPerPage={itemsPerPage}&filters.Text={textFilter}&filters.HaveLocks={haveLocksFilter}'

**URI Parameters**

+-------------------+-------------------+---------------------------------------------------------------+
| Name              | Type              | Description                                                   |
+===================+===================+===============================================================+
| page              | number (optional) | page number                                                   |
+-------------------+-------------------+---------------------------------------------------------------+
| itemsPerPage      | number (optional) | number of elements to load (max 200, default 200)             |
+-------------------+-------------------+---------------------------------------------------------------+
| filters.Text      | string (optional) | filtering by organization name                                |
+-------------------+-------------------+---------------------------------------------------------------+
| filters.HaveLocks | bool (optional)   | filtering by organization where at least one lock is assigned |
+-------------------+-------------------+---------------------------------------------------------------+
| dataScope         | number (optional) | data scope (0: all data, 1:minimal data loaded )              |
+-------------------+-------------------+---------------------------------------------------------------+


Responses 
-------------

+--------+-------------------------------------------------------------+----------------------+
| Name   | Type                                                        | Description          |
+========+=============================================================+======================+
| 200 OK | :doc:`Organizations <../../datastructures/organization>` [] | successful operation |
+--------+-------------------------------------------------------------+----------------------+

Scopes
-------------

+------------------------+---------------------------------------------+
| Name                   | Description                                 |
+========================+=============================================+
| Organization.Read      | Grants the ability to view organizations.   |
+------------------------+---------------------------------------------+
| Organization.ReadWrite | Grants the ability to manage organizations. |
+------------------------+---------------------------------------------+

Examples
-------------

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "organizations": [
                    {
                        "id": 1,
                        "name": "Organization 1",
                        "ownerName": "Owner",
                        "description": "Sample organization",
                        "logo": "https://example.com/logo.png",
                        "color": "#007bff",
                        "initials": "O1",
                        "slug": "organization-1",
                        "bridgesCount": 5,
                        "locksCount": 10,
                        "organizationRole": 1
                    },
                    {
                        "id": 2,
                        "name": "Organization 2",
                        "ownerName": "Another Owner",
                        "description": "Another organization",
                        "logo": "https://example.com/logo2.png",
                        "color": "#dc3545",
                        "initials": "O2",
                        "slug": "organization-2",
                        "bridgesCount": 3,
                        "locksCount": 7,
                        "organizationRole": 1
                    }
                ]
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }