How to connect to Tedee device via Bluetooth
======================================================

As an integrator, you may want to establish a secure connection between the Tedee device and your device over BLE. To do that you need
to register your device and generate a certificate for it. In this tutorial, we will cover how to register a new integration device
in Tedee Cloud (e.g. mobile device) and manage access certificates for it.

.. note::
    Originally integration with Tedee devices was reserved only for mobile phones with Tedee App. Currently, we are extending the Mobile area
    to handle registration to our system by other external devices.

    In this tutorial, we will name a device that wants to establish a secure connection over BLE with the Tedee device as **mobile**.

Prequisities
^^^^^^^^^^^^^
    - Tedee device should be added to user account. 


Step 1: Generate ECSDA auth pair key on the mobile
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

The Tedee devices are communicating only with other trusted devices. As a first step, on the mobile device, an ECDSA auth key pair should be generated.

Tedee devices are using the ECDSA cryptography algorithm with uses elliptic curve cryptography. The elliptic curve base point 256 is used.

.. note::
    We are recommending using libraries to generate the auth key pair:
        - C Language: **MbedTLS**,
        - iOS: **CryptoSwift** and native Apple framework **Security** for keys management,
        - Java: **javax.crypto** and **java.security**

.. warning::
    The generated ECDSA private key should be kept only on the mobile device and stored securely.


Step 2: Register mobile device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
Only mobiles registered in Tedee Cloud can establish secure Bluetooth connections with Tedee devices. For those mobiles, 
Tedee Cloud is generating access certificates. 

When the auth key pair is generated on the mobile device, then it can be registered in Tedee Cloud.
If you are integrating an external device operating system flag should be set to 3.

To register new mobile use `Register mobile <../endpoints/mobile/register.html>`_ endpoint.

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

To establish a secure BLE connection with the Tedee device, an access certificate is required. This certificate is read and validated by the Tedee device.

The access certificate is issued by Tedee Cloud with a 10-days validity period. The mobile device is responsible 
for requesting and refreshing the access certificates. We recommend refreshing the certificate when validity is about 40-50% remain validity period. 

To generate the certificate `Get for mobile <../endpoints/devicecertificate/get-for-mobile.html>`_ endpoint should be used.

**Sample request**

.. code-block:: js

    GET |apiUrl|/api/|apiVersion|/my/devicecertificate/getformobile?mobileId=123&deviceId=1

In the response the certificate data will be returned. 

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

The 'result.certificate' field is containing the certificate issued by Tedee Cloud. The 'result.expirationDate' is containing the date when the access certificate will expire.
The 'result.certificate' field value should be passed to the Tedee device as the certificate.

.. note::
    The access certificate is returned in bytes in Base64 format.

For more details find **Tedee BLE API documentation**.

Step 4: Get time for Tedee device
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

To establish a secure BLE connection Tedee device require current time for proper work. When the Tedee device is not having a current time set, 
the mobile should it to the Tedee device.

To get current time from Tedee API is returned`Get signed time <../endpoints/datetime/get-signed-time.html>`_ endpoint.

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

**More information**
    - Tedee BLE API documentation   