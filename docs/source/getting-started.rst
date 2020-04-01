Getting started
===============

Tedee's API exposes resources that enable you to work with your devices. By calling relevant endpoint user is able, among others, to manipulate lock, get battery level or read it's activities. This guide aims to help you to get started with Tedee's API.

What you need?
--------------

Starting working with the API doesn't require much prerequisites.
You'll need:

* REST API client - `Postman <https://www.postman.com/>`_ is a great example here

Registration and authentication
-------------------------------

Since every action exposed on this API is related to user's devices or account, it's required to authenticate all requests. The process of authentication is described in dedicated :doc:`section <authentication>`, however for now we'll just need to `get JWT` (described in mentioned section). Once we've got our access token we can use Postman to make authenticated request to the API.

To do this open Postman and go to Authorization tab. 

.. image:: images/postman-auth.png
  :alt: Authentication with Postman

In ``TYPE`` dropdown select **Bearer Token** and in ``Token`` input field put your access token.
From now on, our requests should be authenticated.

REST API request
----------------

To interact with the Tedee REST API, you send HTTP requests that use a supported method: GET, POST, PATCH, or DELETE. POST and PATCH request bodies and server responses are sent in JSON payloads.

The path URL resource names and query parameters are case insensitive. However, values you assign, entity IDs, and other base64 encoded values are case sensitive.

Request message URI
^^^^^^^^^^^^^^^^^^^

All Tedee REST API requests use the following URL format:

``|apiUrl|/{version}/{resource}``

* **version** - TODO
* **resource** - TODO

Request message headers
^^^^^^^^^^^^^^^^^^^^^^^

TODO

User context
^^^^^^^^^^^^

TODO

Example request
^^^^^^^^^^^^^^^^

Let's get some information about our devices now.
Put the below address in the `url` input like in the screen above and click **Send**.

``https://api.tedee.com/api/v1.13/my/device``

You should receive response with all your devices.

REST API Response
-----------------

Response HTTP code
^^^^^^^^^^^^^^^^^^

TODO

Response message body
^^^^^^^^^^^^^^^^^^^^^

Each endpoint return data in the same format:

.. code-block:: js

  {
    "result": object,
    "success": boolean,
    "errorMessages": array,
    "statusCode": number
  }

* **result** - represents actual data that user requests for,
* **success** - describes weather the request has been processed successfully or not,
* **errorMessages** - is an array of eventual errors that occured while processing the request,
* **statusCode** - represents Http status code of the response.

Response message headers
^^^^^^^^^^^^^^^^^^^^^^^^

TODO

Example response
^^^^^^^^^^^^^^^^

TODO

What's next?
------------

Here's a list of example actions that you can do using the API:

* Get device details,
* Update device settings,
* Calibrate lock,
* Read lock state,
* Read device activities,
* Lock, unlock or pull spring