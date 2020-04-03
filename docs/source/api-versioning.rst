API versioning
==============

Tedee API is versioned, which allows us to develop and provide new functionalities while keeping backwards compatibility.
This ensures that even when a breaking change happens, other services will still be able to work with the API the same way they did.

Usage
-----

| Each request requires the version number to be provided in the url using this format.
| ``|apiUrl|/{version}/{resource}``
| For example:
| ``|apiUrl|/|apiVersion|/my/device``

Version supported features
--------------------------

To verify which versions provide the feature that you want to utilize, we recommend to visit the `API Swagger documentation <|apiUrl|/swagger/index.html>`_.
You should be able to select a version in top right corner and check if the desired endpoint is available and how the request body should look like.