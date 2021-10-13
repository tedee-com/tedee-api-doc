How to register mobile and get mobile certificate
=================================================

As integrator you may want to establish secure connection between Tedee device and own device. To do that you need
to register the device you will use and generate certificate for it. In this tutorial we will cover how to register
new integration device in our system (e.g. mobile device) and manage certificates for it.

.. note::
    Originally integration with Tedee devices was reserved only for mobile phones with Tedee App. Currently, we are exteding the Mobile area
    to handle registration to our system by other external devices.

    In this tutorial we will name device which want to establish secure connection with Tedee device as **mobile**.


Step 1: Generate auth pair key on the integration device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

As a first step, on mobile device a auth key pair should be generated.

TODO: Details how to create certificate.

.. note::
    We are recommending using libraries to generate the auth key pair:
        - C Language: **MbedTLS**,
        - iOS: **CryptoSwift** and native Apple framework **Security** for keys management,
        - Java: **javax.crypto** and **java.security**

.. warning::
    The generated private key should be kept only on the mobile device and stored securely.


Step 2: Register mobile device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

When the auth key pair is generated on the mobile device, then device can be registered in Tedee Cloud. If you are integrating external device
operating system flag should be set to 3.

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/mobile" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"


**Sample body**

.. code-block:: js

        {
            "name": "<<integration device name>>",
            "operatingSystem": 3,
            "publicKey": "<<public as base64 key generated in step 1>>"
        }

**Sample response**

.. code-block:: js

        {
            "result": {
                "id": 123,
            }
            "success": true,
            "errorMessages": [],
            "statusCode": 201
        }

If the registration succeed it means, your device is properly registered in Tedee Cloud. Mobile identifier should be saved.

Step 3: Get certificate for mobile device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

To establish secure connection with Tedee device, required is certificate which is read by Tedee device. If the certificate is correct and valid,
PTLS session is established (Secure Bluetooth connection). Mobile device is responsible for generating and refreshing the certificates to connect
to Tedee devices.

To generate the certificate `Get for mobile <../endpoints/devicecertificate/get-for-mobile.html>`_ endpoint should be used.

**Sample request**

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/my/devicecertificate/getformobile?mobileId=123&deviceId=1

In the response the certificate data will be returned. Please remember to refresh the certificate before it expiration date, to keep the connection
live.

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

Using the certificate, mobile should be able to establish connection with Tedee device.

Step 4: Get time for Tedee device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Tedee device require time updates. When the Tedee device is asking for current time, it can be obtained from Tedee API
using `Get signed time <../endpoints/datetime/get-signed-time.html>`_ endpoint.

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/datetime/getsignedtime" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Sample response**

HTTP status code: ``200``

.. code-block:: js

    {
        "result": {
            "datetime" : "AAABfHgtDbU=",
            "signature" : "MEQCIIa7NtKXDHDzynw0y5Gmi98HrA9UYnBimzXbixzaqoJiAiBDekhYsN7Eo0+d4so79zJFVni25kJJKlDklX04u7gEMA==",
        },
        "success": true,
        "errorMessages": [],
        "statusCode": 200
    }

**Next steps:**

- TODO: Revoked certificates management.