Get access link assignable devices
===============================================

Get devices which can be assigned to an organization access link.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization/{organizationId}/accesslink/device/assignable

**URI Parameters**

+--------------------+-------------------+---------------------------------------------------+
| Name               | Type              | Description                                       |
+====================+===================+===================================================+
| organizationId     | number            | id of the organization                            |
+--------------------+-------------------+---------------------------------------------------+
| page               | number            | page number                                       |
+--------------------+-------------------+---------------------------------------------------+
| itemsPerPage       | number (optional) | number of elements to load (max 100, default 100) |
+--------------------+-------------------+---------------------------------------------------+
| filters.DeviceName | string (optional) | filtering device name                             |
+--------------------+-------------------+---------------------------------------------------+
| filters.DeviceId   | int (optional)    | filtering by device id                            |
+--------------------+-------------------+---------------------------------------------------+

Responses 
-------------

+--------+--------------------------------------------------------------------------------------------------------------------+----------------------+
| Name   | Type                                                                                                               | Description          |
+========+====================================================================================================================+======================+
| 200 OK | :doc:`Access Link Assignable Devices List <../../datastructures/organization-access-link-assignable-devices-list>` | successful operation |
+--------+--------------------------------------------------------------------------------------------------------------------+----------------------+

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

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/123/accesslink/device/assignable" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "accessLinkDevices": [
                    {
                        "deviceId": 1,
                        "name": "Lock",
                        "type": 2,
                        "timeZone": "Europe/Warsaw",
                        "softwareVersions": [
                        {
                            "softwareType": 0,
                            "version": "2.4.5200"
                        }
                        ]
                    },
                    {
                        "deviceId": 2,
                        "name": "Gate",
                        "type": 5,
                        "timeZone": "Europe/London",
                        "softwareVersions": [
                        {
                            "softwareType": 0,
                            "version": "2.4.2081"
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