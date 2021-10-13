Get for mobile
=========================

Get certificate for specific mobile device endpoint. To establish secure PTLS connection (Secure Bluetooth Connection)
with Tedee device required is certificate obtained from this endpoint.

.. note::
    Refreshing the certificate is in scope of mobile.

.. note::
    To keep the connection alive, we recommend to refresh the certificate when validity is about 40-50%
    remain validity period.

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/devicecertificate/getformobile?mobileId={mobileId}&deviceId={deviceId}

**URI Parameters**

+----------+--------+---------------------+
| Name     | Type   | Description         |
+==========+========+=====================+
| mobileId | number | id of mobile device |
+----------+--------+---------------------+
| deviceId | number | id of Tedee device  |
+----------+--------+---------------------+

Responses 
-------------

+--------+------------------------------------------------------------------------------+----------------------+
| Name   | Type                                                                         | Description          |
+========+==============================================================================+======================+
| 200 OK | :doc:`Certificates for mobile <../../datastructures/certificate-for-mobile>` | successful operation |
+--------+------------------------------------------------------------------------------+----------------------+

Scopes
-------------

+---------------------------+--------------------------------------------------------+
| Name                      | Description                                            |
+===========================+========================================================+
| DeviceCertificate.Operate | Grants user possibility to access devices certificates |
+---------------------------+--------------------------------------------------------+

Examples
-------------

Get certificate for mobile
^^^^^^^^^^^^^^^^^^^^^^^^^^

**Sample Request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/devicecertificate/getformobile?mobileId=123&deviceId=456" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


**Sample response**

HTTP status code: ``200``

.. code-block:: js

        {
            "result": {
                "certificate": "AQECAgECAwRhZ+ZwBAF/BQQAAAAABgQAAVF/BRhZNAACARjRgOACQQAACLdCgQAAGHMCwgAAAF7ybAKin5BBKbnztHKIog
                8hD3/OqFWBI5/oNECVRyQm5EfxZyGz/Pv7oKvlXNkF2503/RCRgocotF6rVQaYsH9c5Xq4btSF/RjBEAiDLNX00yWXmpIi0AigSb3veeFyEQRN
                sCRYbEwCZxkFe1gIgJEGKT6EoSHwPfYmPJsHCdcgtBQPiDXM/M2qJRbu6Pb4=",
                "expirationDate": "2021-12-12T00:00:00.000000Z",
                "devicePublicKey": "BL4lFWWQ0SCxYr5aLWaCUA/88XsWkVJdxihYIN0kL9VKhE9jAx8+INXVG/vsen/VEj9YltNMtb1I+qDTUdVqo8c=",
                "mobilePublicKey": "BkbnztKHIog8hD3/OqFWBI5/oNECVRyQm5EfXZyGz/Pv7oKvlXNkF2503/RCRgocotF6rVQaYsH9c5Xq4btSYKE="
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 200
        }
