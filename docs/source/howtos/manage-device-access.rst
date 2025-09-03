How to manage access to the Tedee Lock
=========================================

This tutorial will guide you through managing access to Tedee Lock devices for both individual users and user groups.

Overview
--------

The Tedee API supports both individual user and user group access management. This allows organizations to efficiently manage access for teams, departments, or any logical grouping of users.

Key concepts:
- **Principal**: A generic term for either a user or a user group
- **Principal Type**: Identifies whether access is for a user (0) or user group (1)
- **Principal ID**: A UUID that uniquely identifies a user or group

Access Management for Individual Users
---------------------------------------

Granting user access
^^^^^^^^^^^^^^^^^^^^

When hiring a new employee who needs access to your office's main entrance, you can grant them access using the :doc:`Create access <../endpoints/deviceaccess/create>` endpoint.

For individual users:
- **Required**: userEmail field when principalType is 0
- The API will return the principalId in the response

**Sample request using email**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/1/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

    {
        "accessLevel": 1,
        "dayEndTime": null,
        "dayStartTime": null,
        "endDate": null,
        "principalType": 0,
        "remoteAccessDisabled": false,
        "startDate": "2025-02-01T00:00:00.000Z",
        "userEmail": "john.doe@company.com",
        "weekDays": null
    }

.. note::
   When creating access for a user (principalType: 0), provide the userEmail. The API will return the principalId in the response.

Access Management for User Groups
----------------------------------

You can grant access to entire groups of users, making it easier to manage access for teams or departments.

Creating group access
^^^^^^^^^^^^^^^^^^^^^

When you want to grant access to an entire team (e.g., Engineering Team, Cleaning Service, Security Team), use the group's principalId with principalType: 1.

**Sample request for user group**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/device/1/access" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

    {
        "accessLevel": 0,
        "dayEndTime": "17:00:00.000Z",
        "dayStartTime": "09:00:00.000Z",
        "endDate": null,
        "principalId": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
        "principalType": 1,
        "remoteAccessDisabled": false,
        "startDate": null,
        "weekDays": 31
    }

.. note::
   For user groups (principalType: 1), you must provide the principalId. User groups don't have email addresses.

Access Types and Time Restrictions
-----------------------------------

Both individual users and user groups can have their access customized with time restrictions.

Permanent access
^^^^^^^^^^^^^^^^

Grant unlimited access by setting all time restrictions to null:

.. code-block:: js
    
    {
        "dayEndTime": null,
        "dayStartTime": null,
        "endDate": null,
        "startDate": null,
        "weekDays": null
    }

Time-restricted access
^^^^^^^^^^^^^^^^^^^^^^

Limit access to specific dates:

.. code-block:: js
    
    {
        "dayEndTime": null,
        "dayStartTime": null,
        "endDate": "2025-12-31T23:59:59.000Z",
        "startDate": "2025-01-01T00:00:00.000Z",
        "weekDays": null
    }

Business hours access
^^^^^^^^^^^^^^^^^^^^^

Grant access only during working hours (Monday-Friday, 8:00-17:00):

.. code-block:: js
    
    {
        "dayEndTime": "17:00:00.000Z",
        "dayStartTime": "08:00:00.000Z",
        "endDate": null,
        "startDate": null,
        "weekDays": 31
    }

Listing Device Access
---------------------

To view all users and groups with access to a device, use the :doc:`Get all accesses <../endpoints/deviceaccess/get-all>` endpoint.

**Sample request with filters**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/device/1/access?Filters.PrincipalType=1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

Available filters:
- ``Filters.PrincipalId``: Filter by specific user or group UUID
- ``Filters.Text``: Search by email or name
- ``Filters.PrincipalType``: 0 for users, 1 for groups

**Sample response**

.. code-block:: js

    {
        "result": [
            {
                "accessLevel": 1,
                "dayEndTime": null,
                "dayStartTime": null,
                "deviceId": 1,
                "endDate": null,
                "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                "isPending": false,
                "organizationUserId": 11,
                "principalId": "bcc1fdc9-13ee-43b3-a13e-eaba8eaf7996",
                "principalName": "John Doe",
                "principalType": 0,
                "remoteAccessDisabled": false,
                "startDate": null,
                "userEmail": "john.doe@company.com",
                "weekDays": null
            },
            {
                "accessLevel": 0,
                "dayEndTime": "17:00:00.000Z",
                "dayStartTime": "09:00:00.000Z",
                "deviceId": 1,
                "endDate": null,
                "id": "5bc07g86-7939-6784-d5he-4e185h88chc8",
                "isPending": false,
                "organizationUserId": 0,
                "principalId": "a4d5e6f7-8b9c-4d2e-9f1a-3b4c5d6e7f8a",
                "principalName": "Engineering Team",
                "principalType": 1,
                "remoteAccessDisabled": false,
                "startDate": null,
                "userEmail": null,
                "weekDays": 31
            }
        ],
        "errorMessages": [],
        "statusCode": 200,
        "success": true
    }

Updating Access
---------------

To update existing access for either users or groups, use the :doc:`Update access <../endpoints/deviceaccess/update>` endpoint with the access UUID.

**Finding the access to update**

First, retrieve the access ID using filters:

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/device/1/access?Filters.Text=john.doe@company.com" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

**Updating the access**

.. code-block:: sh

    curl -X PUT "|apiUrl|/api/|apiVersion|/my/device/1/access/3fa85f64-5717-4562-b3fc-2c963f66afa6" -H "accept: application/json" -H "Content-Type: application/json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

    {
        "accessLevel": 2,
        "dayEndTime": null,
        "dayStartTime": null,
        "endDate": null,
        "remoteAccessDisabled": false,
        "startDate": null,
        "weekDays": null
    }

Removing Access
---------------

To revoke access for users or groups, use the :doc:`Delete access <../endpoints/deviceaccess/delete>` endpoint with the access id.

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/device/1/access/3fa85f64-5717-4562-b3fc-2c963f66afa6" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

.. note::
   Access with a defined ``endDate`` will expire automatically. You don't need to manually delete time-limited access.

Best Practices
--------------

1. **Use Groups for Teams**: Instead of granting individual access to each team member, create a user group and grant access once.

2. **Required Fields by Principal Type**: 
   - **For Users (principalType: 0)**: userEmail is required
   - **For Groups (principalType: 1)**: principalId is required

3. **Time Restrictions**: Always consider whether permanent access is necessary. Use time restrictions for contractors, temporary employees, or service providers.

4. **Access Levels**: Grant the minimum required access level:
   - Guest (0): Basic access
   - Admin (1): Can manage other users' access
   - Owner (2): Full control over the device

5. **Filtering**: When managing many accesses, use the filter parameters to find specific users or groups quickly.

Important Notes
---------------

1. **UUID Format**: Access IDs and Principal IDs use UUID format

2. **Group Support**: Manage access for entire user groups using principalType: 1

3. **Response Format**: The response includes both user-specific fields (userEmail) and generic principal fields (principalId, principalName, principalType) for comprehensive access information