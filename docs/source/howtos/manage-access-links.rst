How to manage access links
=========================================

In this tutorial, we will go through organization access link management. We will show you how to create, update, and delete access links.

We will introduce you to organization access links and how to use them.

Organization access links
--------------------------

Organization access allows sharing access to Tedee Lock or Gate with a guest by simple Url. A guest with an access link can open locks or gates without having a Tedee account.

Access link can be created only from organization and only for devices which are assigned to organization. If you don't have an organization, you can create it using Tedee Portal.


.. warning::
   Be careful with who you share the access link with. Anyone with the link can open the Tedee smart lock or gate.

When you should use access links?
---------------------------------

Let's imagine you have a Tedee smart lock installed in your doors and want to give access to your home to your friend. You can create an access link and share it with your friend. Your friend will be able to open the door using the access link. Your friend does not need a Tedee app or a Tedee account.

Another scenario is more business. You have a rental apartment with a Tedee smart lock installed. Your guests want to avoid installing the Tedee app and creating an account. Instead, you can create an access link and share it with your guests. Your guests can open the door using the access link from a web browser.

Your access links will be valid only in the time period you set.

When you should not use access links?
-------------------------------------

Access links are not a replacement for the Tedee app. If you have family members or employees who always use the Tedee smart lock, they should use the Tedee app. It is more secure and convenient. 

Create an access link
---------------------

You can create an access link from the Tedee Portal. Hovewer, this tutorial will show you how to create an access link using the Tedee API.

Firstly, you need to find an organization you want to create the access link in.

Use :doc:`Get organization <../endpoints/organization/get-all>` endpoint:

.. code-block:: sh

    GET |apiUrl|/api/|apiVersion|/organization

As a result you will get a list of organizations you administer. You can find the organization you want to create the access link in.

To create an access link, you need to send a POST request using :doc:`Create organization access link <../endpoints/organizationaccesslink/create>` endpoint:

.. code-block:: sh

    POST |apiUrl|/api/|apiVersion|/organization/{organizationId}/accesslink

Where ``{organizationId}`` is the ID of the organization you want to create the access link in.

The request body should contain the following parameters:

* ``name`` - the name of the access link. It is a string with a maximum length of 450 characters.
* ``description`` - the description of the access link. It is a string with a maximum length of 72 characters.
* ``deviceIds`` - the list of device IDs you want to assign to the access link. It is a list of integers.
* ``repeatEvent`` - the access details of the access link. 

The example request body is:

.. code-block:: js

        {
            "name": "test link for friend",
            "description": "test link to open the door",
            "deviceIds": [
                123,
                223
            ],
            "repeatEvent": {
                "startDate": "2023-01-01T00:00:00.000Z",
                "endDate": "2023-02-01T00:00:00.000Z"
            }
        }

After you send the POST request, you will receive the access link id and the access link URL.

.. code-block:: js

        {
            "id": "647afced-54af-40bf-90b9-f8ef28946088",
            "url": "https://tedee.com/accesslink/123"
        }

Received access link URL you can share with your friends or guests. They can open the Tedee smart lock or gate using the access link URL.

.. note::
    Tedee smart locks or gate activities will contains unlocks triggered from the access link. You can check them using both the Tedee mobile app and the Tedee Portal.

Update an access link
---------------------

You can always update the access link. You can change the name, description, devices assigned to the access link, and the time period the access link is valid.

To update an access link, you need to send a PATCH request using :doc:`Update organization access link <../endpoints/organizationaccesslink/update>` endpoint:

.. code-block:: sh

    PATCH |apiUrl|/api/|apiVersion|/organization/{organizationId}/accesslink/{accessLinkId}

Where ``{organizationId}`` is the ID of the organization you want to update the access link in and ``{accessLinkId}`` is the ID of the access link you want to update.

Delete an access link
---------------------

You can delete an access link. After you delete the access link, it will not be valid anymore.

To delete an access link, you need to send a DELETE request using :doc:`Delete organization access link <../endpoints/organizationaccesslink/delete>` endpoint:

.. code-block:: sh

    DELETE |apiUrl|/api/|apiVersion|/organization/{organizationId}/accesslink/{accessLinkId}

Where ``{organizationId}`` is the ID of the organization you want to delete the access link in and ``{accessLinkId}`` is the ID of the access link you want to delete.

.. warning::
    After you delete the access link, it will not be valid anymore. You can not restore it.