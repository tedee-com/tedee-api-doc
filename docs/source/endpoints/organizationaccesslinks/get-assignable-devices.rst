Get organization access link assignable devices
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
| itemsPerPage       | number (optional) | number of elements to load (max 200, default 200) |
+--------------------+-------------------+---------------------------------------------------+
| filters.DeviceName | string (optional) | filtering device name                             |
+--------------------+-------------------+---------------------------------------------------+
| filters.DeviceId   | int (optional)    | filtering by device id                            |
+--------------------+-------------------+---------------------------------------------------+

Responses 
-------------

+--------+---------------------------------------------------------------------------------------------------------------------+----------------------+
| Name   | Type                                                                                                                | Description          |
+========+=====================================================================================================================+======================+
| 200 OK | :doc:`Organization Assignable Devices List <../../datastructures/organization-access-link-assignable-devices-list>` | successful operation |
+--------+---------------------------------------------------------------------------------------------------------------------+----------------------+

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

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/accesslink/device/assignable" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "accessLinkDevices": [
                ],
                "page": 1,
                "itemsPerPage": 25
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }