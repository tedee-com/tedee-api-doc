Delete
=========================

Delete personal access key.

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/my/personalaccesskey/{id}

**URI Parameters**

+--------------------+---------------+----------------------------------------------------+
| Name               | Type          | Description                                        |
+====================+===============+====================================================+
| id                 | UUID          | id of the personal access key                      |
+--------------------+---------------+----------------------------------------------------+


Responses 
-------------

+------------------------+-------------------------+
| Name                   |Description              |
+========================+=========+===============+
| 204 No Content         |successful operation     |
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

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/personalaccesskey/bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``204``

.. code-block:: js

        {   
            "success": true,
            "errorMessages": [],
            "statusCode": 204
        }
