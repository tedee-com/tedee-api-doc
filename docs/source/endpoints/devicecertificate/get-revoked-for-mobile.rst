Get revoked for mobile
=========================

Get all revoked certificates for mobile device.

OPIS TODO

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/devicecertificate/getrevokedformobile?deviceId={deviceId}&version={version}

**URI Parameters**

+----------+--------+----------------------------------------+
| Name     | Type   | Description                            |
+==========+========+========================================+
| deviceId | number | id of Tedee device                     |
+----------+--------+----------------------------------------+
| version  | number | certificates Tedee device list version |
+----------+--------+----------------------------------------+

Responses 
-------------

+----------------+---------------------------------------------------------------------------------+----------------------+
| Name           | Type                                                                            | Description          |
+================+=================================================================================+======================+
| 200 OK         | :doc:`Revoked certificate list <../../datastructures/revoked-certificate-list>` | successful operation |
+----------------+---------------------------------------------------------------------------------+----------------------+
| 204 No Content |                                                                                 | version up to date   |
+----------------+---------------------------------------------------------------------------------+----------------------+

Scopes
-------------

+---------------------------+--------------------------------------------------------+
| Name                      | Description                                            |
+===========================+========================================================+
| DeviceCertificate.Operate | Grants user possibility to access devices certificates |
+---------------------------+--------------------------------------------------------+

Examples
-------------

Revoked certificates for mobile
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/devicecertificate/getrevokedformobile?deviceId=123&version=1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "deviceId": 123,
                "version": 2,
                "lastUpdated": 1633692928,
                "signature": "MEUCICFNUa+s27psC6CFYV0KJ/f=g/6AU/rS7+CWZMPahrstESAiEA5tOCveS4a1MWz4qMQN7b+cJhuFWcJjPXPr0Sl3GfCUQ=",
                "revokedCertificates": [
                    {
                        "certificateId": 982,
                        "expirationDate": "2020-12-12T00:00:00.000000Z" 
                    }
                ]
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }

Version up to date
^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/devicecertificate/getrevokedformobile?deviceId=123&version=2" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``204``