Overview
========

Tedee's API exposes resources that enable you to work with your devices.
By calling relevant endpoint user is able, among others, to manipulate lock, get battery level or read it's activities.
This guide aims to help you to get started with Tedee's API.

What you need?
--------------

Starting working with the API doesn't require much prerequisites.
You'll need:

* Account assosiated with your devices
* REST API client - `Postman <https://www.postman.com/>`_ is a great example here

How to start?
-------------

Since every action exposed on this API is related to user's devices or account, it's required to authenticate all requests.
The process of authentication is described in dedicated :doc:`section <authentication>`, however for now we'll just need to `get JWT`.
Once we've got our access token we can use Postman to make authenticated request to Tedee's API.

To do this open Postman and go to Authorization tab. 

.. image:: images/postman-auth.png
  :alt: Authentication with Postman

In ``TYPE`` dropdown select **Bearer Token** and in ``Token`` input field put your access token.
From now on, our requests should be authenticated.

Let's get some information about our devices now.
Put the below address in the `url` input like in the screen above and click **Send**.

``https://api.tedee.com/api/v1.13/my/device``

You should receive response with all your devices.

Response structure
------------------

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

What's next?
------------

Here's a list of example actions that you can do using the API:

* Get device details,
* Update device settings,
* Calibrate lock,
* Read lock state,
* Read device activities,
* Lock, unlock or pull spring

We encourage you to visit our "**HOW TO ...**" section to find detailed instructions for some of the actions.
