How to manage users in an organization
======================================

This tutorial shows how to manage organization users with the Tedee API: listing users, checking whether user already exists, inviting a new user, viewing profile details, updating a profile, granting or removing admin role, and removing users from organization.

Overview
--------

Organization user management is available in the ``OrganizationUser`` area.
Use these operations as a reference:

* `Get all users from organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetOrganizationUsers>`_
* `Add user to organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/PostOrganizationUser>`_
* `Get organization user profile <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetOrganizationUserProfile>`_
* `Edit organization user profile <https://api.tedee.com/swagger/index.html#/OrganizationUser/PutOrganizationUser>`_
* `Assign admin role to user <https://api.tedee.com/swagger/index.html#/OrganizationUser/AssignAdminRole>`_
* `Remove admin role from user <https://api.tedee.com/swagger/index.html#/OrganizationUser/RemoveAdminRole>`_
* `Remove user from organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/DeleteOrganizationUser>`_

Prerequisites
-------------

Before you start, make sure:

* You are authenticated (see :doc:`Authenticate <authenticate>`)
* Your token includes ``Organization.ReadWrite`` scope
* You know your ``organizationId`` (you can get it from :doc:`Get organizations <../endpoints/organization/get-all>`)

Step 1: List users in organization
----------------------------------

Use `Get all users from organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetOrganizationUsers>`_ to retrieve current members.

Endpoint schema:
``GET /organization/{organizationId}/user``

Useful query parameters:

* ``Filters.Text`` (search by display name or email)
* ``Filters.UserTypes`` (filter by user type)
* ``Filters.IncludePendingUsers`` (include invited users that have not accepted yet)
* ``Page`` and ``ItemsPerPage`` (pagination)

``Filters.UserTypes`` values (``OrganizationUserType`` enum):

* ``0`` - Admin
* ``1`` - Other
* ``2`` - Owner

Example search patterns:

* Search by email: ``?Filters.Text=new.member@company.com``
* Search by name: ``?Filters.Text=John%20Doe``
* Find pending users: ``?Filters.IncludePendingUsers=true``
* List only admins: ``?Filters.UserTypes=0``

Search organization users by email (new.member@company.com):

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user?Filters.Text=new.member%40company.com" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"

Search organization users by display name (John Doe):

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user?Filters.Text=John%20Doe" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"

List pending invited users in organization with id 1:

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user?Filters.IncludePendingUsers=true" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"

List only organization admins (Filters.UserTypes=0):

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user?Filters.UserTypes=0" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"

This is usually the first call in your sync flow, and helps you map ``organizationUserId`` values for later operations.

Step 2: Check if user already exists
------------------------------------

Before you invite a user, first call `Get all users from organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetOrganizationUsers>`_ with ``Filters.Text`` using their email.

Endpoint schema:
``GET /organization/{organizationId}/user``

Recommended duplicate-check flow:

1. Search by exact email in ``Filters.Text``
2. Check both active and pending users (set ``Filters.IncludePendingUsers=true``)
3. If the user already exists (or invitation is pending), skip invitation
4. If no match is found, proceed with invite

Check whether new.member@company.com already exists in organization with id 1:

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user?Filters.Text=new.member%40company.com&Filters.IncludePendingUsers=true" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"

.. note::
   This prevents duplicate invitations and keeps your onboarding flow clean.

Step 3: Invite a new user
-------------------------

Use `Add user to organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/PostOrganizationUser>`_.

Endpoint schema:
``POST /organization/{organizationId}/user``

``PostRequest`` requires:

* ``name``
* ``email``

Optional field:

* ``role`` (enum ``OrganizationRoleType``)

Example body:

.. code-block:: js

    {
        "name": "John Doe",
        "email": "new.member@company.com",
        "role": 2
    }

Invite John Doe (new.member@company.com) to organization with id 1:

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/organization/1/user" \
      -H "accept: application/json" \
      -H "Content-Type: application/json" \
      -H "Authorization: Bearer <<access token>>" \
      -d "{\"name\":\"John Doe\",\"email\":\"new.member@company.com\",\"role\":2}"

``OrganizationRoleType`` values:

* ``0`` - Owner
* ``1`` - Admin
* ``2`` - Member

.. important::
   On success, this operation returns ``organizationUserId``.

.. note::
   After invitation, the new user is marked as ``Pending`` until they create a Tedee account and accept the invitation.

Step 4: Get user profile details
--------------------------------

Use `Get organization user profile <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetOrganizationUserProfile>`_ when you need full details of a single organization member.

Endpoint schema:
``GET /organization/{organizationId}/user/{organizationUserId}``

Get profile details for user with id 123 from organization with id 1:

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/organization/1/user/123" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"

This endpoint is useful when:

* building admin panels,
* validating invitation state,
* reading current role flags before admin role updates.

Step 5: Update user profile
---------------------------

Use `Edit organization user profile <https://api.tedee.com/swagger/index.html#/OrganizationUser/PutOrganizationUser>`_.

Endpoint schema:
``PUT /organization/{organizationId}/user/byorganizationuserid/{organizationUserId}``

``PutRequest`` requires:

* ``displayName``

Example body:

.. code-block:: js

    {
        "displayName": "John A. Doe"
    }

Update display name for organization user with id 123:

.. code-block:: sh

    curl -X PUT "|apiUrl|/api/|apiVersion|/organization/1/user/byorganizationuserid/123" \
      -H "accept: application/json" \
      -H "Content-Type: application/json" \
      -H "Authorization: Bearer <<access token>>" \
      -d "{\"displayName\":\"John A. Doe\"}"

Step 6: Grant or remove admin role
----------------------------------

Use dedicated operations for admin role management:

* `Assign admin role <https://api.tedee.com/swagger/index.html#/OrganizationUser/AssignAdminRole>`_
* `Remove admin role <https://api.tedee.com/swagger/index.html#/OrganizationUser/RemoveAdminRole>`_

Endpoint schema (assign admin):
``PUT /organization/{organizationId}/assignadmin``

Endpoint schema (remove admin):
``PUT /organization/{organizationId}/removeadmin``

Both operations use request body with:

* ``organizationUserId``

Example body:

.. code-block:: js

    {
        "organizationUserId": 123
    }

Assign admin role to organization user with id 123 in organization with id 1:

.. code-block:: sh

    curl -X PUT "|apiUrl|/api/|apiVersion|/organization/1/assignadmin" \
      -H "accept: application/json" \
      -H "Content-Type: application/json" \
      -H "Authorization: Bearer <<access token>>" \
      -d "{\"organizationUserId\":123}"

Remove admin role from organization user with id 123 in organization with id 1:

.. code-block:: sh

    curl -X PUT "|apiUrl|/api/|apiVersion|/organization/1/removeadmin" \
      -H "accept: application/json" \
      -H "Content-Type: application/json" \
      -H "Authorization: Bearer <<access token>>" \
      -d "{\"organizationUserId\":123}"

Recommended approach:

1. Read users list and find target ``organizationUserId``
2. Call assign/remove admin endpoint
3. Re-read users list or user profile to verify role change

Step 7: Remove a user from organization
---------------------------------------

Use `Remove user from organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/DeleteOrganizationUser>`_.

Endpoint schema:
``DELETE /organization/{organizationId}/user/byorganizationuserid/{organizationUserId}``

Remove user with id 123 from organization with id 1:

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/organization/1/user/byorganizationuserid/123" \
      -H "accept: application/json" \
      -H "Authorization: Bearer <<access token>>"

Before deleting a member, check whether that user is used in organization groups or device access assignments.

After the user is removed from the organization, they lose access to all organization devices.

Related operations you may need:

* :doc:`Remove members from user group <../endpoints/organizationgroups/remove-members>`
* :doc:`Delete access <../endpoints/deviceaccess/delete>`
