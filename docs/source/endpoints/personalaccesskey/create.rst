Create
=========================

Creates new personal access key

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/personalaccesskey

**Body Parameters**

+--------------------+---------------+----------------------------------------------------+
| Name               | Type          | Description                                        |
+====================+===============+====================================================+
| name               | string        | name of the personal access key                    |
+--------------------+---------------+----------------------------------------------------+
| validTo            | datetime      | date when key expires (max 5 years)                |
+--------------------+---------------+----------------------------------------------------+
| scopes             | list<string>  | list of scopes that is assigned to key             |
+--------------------+---------------+----------------------------------------------------+

Responses 
-------------

+------------------------+------------------------------------------------------------------------------------------+--------------------------+
| Name                   | Type                                                                                     | Description              |
+========================+==========================================================================================+==========================+
| 201 Created            | :doc:`Personal access key created <../../datastructures/personal-access-key-created>`    | successful operation     |
+------------------------+------------------------------------------------------------------------------------------+--------------------------+

Scopes
-------------

+--------------------+-------------------------------------------------------------------------------+
| Name               | Description                                                                   |
+====================+===============================================================================+
| Account.ReadWrite  | Grants user possibility to read and write data connected with account         |
+--------------------+-------------------------------------------------------------------------------+

Examples
-------------

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/personalaccesskey" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "name": "SomeExampleKeyName",
            "validTo": "2021-04-26T06:02:04.197Z",
            "scopes": [
                "Device.Read",
                "Organization.ReadWrite"
            ]
        }

**Sample response**

HTTP status code: ``201``

.. code-block:: js

        {
            "result": {
                "id": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
                "key": "smnxaz.IWA6u00VLQmA8tlfioDXcH+bSiI6u8LgTG9cv3Evh/E"
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }
