Update
=========================

Update personal access key

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/my/personalaccesskey

**Body Parameters**

+--------------------+---------------+----------------------------------------------------+
| Name               | Type          | Description                                        |
+====================+===============+====================================================+
| id                 | UUID          | id of the personal access key                      |
+--------------------+---------------+----------------------------------------------------+
| name               | string        | name of the personal access key                    |
+--------------------+---------------+----------------------------------------------------+
| validTo            | datetime      | date when key expires                              |
+--------------------+---------------+----------------------------------------------------+
| scopes             | list<string>  | list of scopes that is assigned to key             |
+--------------------+---------------+----------------------------------------------------+

Responses 
-------------

+------------------------+-------------------------+
| Name                   |Description              |
+========================+=========+===============+
| 204 NoContent          |successful operation     |
+------------------------+-------------------------+

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

    curl -X PUT "|apiUrl|/api/|apiVersion|/my/personalaccesskey" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996", 
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
            "result": {}
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }
