Get all
====================================

Endpoint that returns paged list of activities for provided device id.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/deviceactivity

**Parameters**

+------------------------+-----------+---------------------+
| Name                   | Type      | Description         |
+========================+===========+=====================+
| Id                     | number    | id of lock          |
+------------------------+-----------+---------------------+

.. code-block:: sh
    :caption: curl

    curl -X GET "|apiUrl|/api/|apiVersion|/my/deviceactivity" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


Responses 
-------------

+------------------------+-----------------------------------------------+--------------------------+
| Name                   | Type                                          | Description              |
+========================+===============================================+==========================+
| 200 OK                 | :doc:`Lock <../../datastructures/lock>` []    | successful operation     |
+                        +-----------------------------------------------+                          +
|                        | :doc:`Bridge <../../datastructures/bridge>` []|                          |
+------------------------+-----------------------------------------------+--------------------------+

Scopes
-------------

+------------------------+-------------------------------------------------------------------------+
| Name                   | Description                                                             |
+========================+=========================================================================+
| Device.Read            | Grants user possibility to read data connected with devices             |
+------------------------+-------------------------------------------------------------------------+
| Device.ReadWrite       | Grants user possibility to read and write data connected with devices   |
+------------------------+-------------------------------------------------------------------------+

Examples
-------------

**Example response**

* HTTP status code - ``200``
* Response body: