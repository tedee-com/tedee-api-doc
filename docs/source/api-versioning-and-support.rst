API versioning and support
==========================

Tedee API is versioned, which allows us to develop and provide new functionalities while keeping backwards compatibility.
This ensures that even when a breaking change happens, other services will still be able to work with the API the same way they did.

Usage
-----

Each request requires the version number to be provided in the url using this format.

``|apiUrl|/{version}/{resource}``

For example:

``|apiUrl|/|apiVersion|/my/device``

Version supported features
--------------------------

To verify which versions provide the feature that you want to utilize, we recommend to visit the `API Swagger documentation <|apiUrl|/swagger/index.html>`_.
You should be able to select a version in top right corner and check if the desired endpoint is available and how the request body should look like.

Version support and deprecation
--------------------------------

API versions are supported for **12 months** after a newer breaking version is released.
Once that period ends, the version is considered deprecated and will eventually be removed.

Deprecated versions remain accessible for an additional **6 months** after the deprecation notice is issued,
giving integrators time to migrate. We recommend upgrading to the latest version as soon as possible.

.. warning::
   Customers using deprecated API versions are notified by email with the deprecation timeline and migration resources.
   Deprecated versions are also subject to reduced rate limits, so we recommend migrating to the latest version as soon as possible.
