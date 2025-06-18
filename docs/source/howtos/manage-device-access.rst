How to automate access to the Tedee Lock
=========================================

This tutorial will go through the Tedee Lock access management based on a real case scenario, managing access to the Tedee Lock within an organization.

Imagine an organization where the Tedee Lock is installed in the main door. You want to automatically grant access to the main entrance when a new employee is hired and taken away when the employee ends his job. 

Granting user access
------------------------

Let's consider that situation. You hired a new employee who will start work next month. You want to grant access to the entrance door for him.

You can do that by creating device access in Tedee API. You need to use :doc:`Create access <../endpoints/deviceaccess/create>` endpoint. Call this endpoint with the new organization's email address and define ``startDate`` as the date when the employee starts work. The access will be created and active from the date you specified as the ``startDate``.

.. note::
   Every device access you create for the specific Tedee Lock must have a unique address email.

If the employee you want to grant access to already has a Tedee account, he will receive a notification that the access was granted. Otherwise, an email invitation will be sent automatically by the Tedee system and the user will be asked to register a new Tedee account.

**Sample request**

.. code-block:: sh

 curl -X POST "|apiUrl|/api/|apiVersion|/my/device/1/access" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

 {
    "accessLevel": 1,
    "userEmail": "john.doe@email.com"
    "weekDays": 10,
    "dayStartTime": "2020-12-14T08:09:57.781Z",
    "dayEndTime": "2020-12-31T08:10:57.781Z",
    "startDate": null,
    "endDate": null,
    "remoteAccessDisabled" : false
 }

In the next section, we will present how you can customize access to the Tedee Lock.

.. note::
    We recommend using **email** as the identifier of the access. You can use it later to find the access, e.g. if you want to update or delete it.

Access types
------------
Not all employees should have the same access to the main entrance. For some of them, you will assign permanent access, but, e.g., for subcontractors or other services like cleaning service, you want to narrow the access to the office.

The sharing feature enables the creation of fully customized access to the Tedee Lock. The access can be permanent, time-restricted, or fully customized - which means the access can be constrained by time, weekdays, or daily hours.

Permanent access
^^^^^^^^^^^^^^^^

If you want a user to have permanent access to the Tedee Lock, you need to send an null values for time restrictions.

**Sample permanent access restriction**

.. code-block:: js
    
 {
    "weekDays": null,
    "dayStartTime": null,
    "dayEndTime": null,
    "startDate": null,
    "endDate": null
 }

Customized access
^^^^^^^^^^^^^^^^^^^^

If you want to restrict user access to the Tedee Lock, you can send ``startDate`` or ``endDate`` fields. The access will be active only in the specified period.
You can also restrict access to specific day hours by sending ``dayStartTime`` and ``dayEndTime``. You can further customize the access by selecting only particular weekdays.
To send it properly, you need to use :doc:`Week days <../enums/week-days>` enum. 

**Sample repeat event objects**

In this case, the access will be created from 14 December 2020 to 31 December 2020.

.. code-block:: js
    
 {
    "weekDays": null,
    "dayStartTime": null,
    "dayEndTime": null,
    "startDate": "2020-12-14T08:09:57.781Z",
    "endDate": "2020-12-31T08:10:57.781Z"
 }

In this case, the access will be created from 1 December 2020 to 31 December 2020, and the user will have access only on Friday and Saturday between 15:00 and 18:00.

.. code-block:: js
    
 {
    "weekDays": 48,
    "dayStartTime": "2020-12-01T15:00:00.000Z",
    "dayEndTime": "2020-12-31T18:00:00.000Z",
    "startDate": "2020-12-01T08:00:00.000Z",
    "endDate": "2020-12-31T20:00:00.000Z"
 }

In this case, the user will have access only from Monday to Friday between 8:00 and 16:00.

.. code-block:: js
    
 {
     "weekDays": 31,
     "dayStartTime": "2020-12-01T08:00:00.000Z",
     "dayEndTime": "2020-12-31T16:00:00.000Z",
     "startDate": null,
     "endDate": null
 }

Update user access
----------------------

If you want to change your employees' access to the main entrance, for example, if you're going to give some of the admin permissions, you can update user access.

To find the access, you need the **employee email** the access was created for. Use :doc:`Get device access list <../endpoints/deviceaccess/get-all>` with ``Filters.Email`` parameter to fetch employee access for the specific Tedee Lock.

Finally, to update the access use :doc:`Update access <../endpoints/deviceaccess/update>` endpoint.

**Sample request**

.. code-block:: sh

 curl -X PUT "|apiUrl|/api/|apiVersion|/my/device/1/access/" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

 {
    "accessLevel": 1,
    "weekDays": 10,
    "dayStartTime": "2020-12-14T08:09:57.781Z",
    "dayEndTime": "2020-12-31T08:10:57.781Z",
    "startDate": null,
    "endDate": null,
    "remoteAccessDisabled" : false
 }

List users with access to the device
---------------------------------------

You can use the Tedee App or the Tedee API to see all accesses for the specific Tedee Lock.

Using the Tedee API, if you want to get accesses for the Tedee Lock, you need the ``deviceId`` and use :doc:`Get all accesses <../endpoints/deviceaccess/get-all>`.
This endpoint will return all accesses for the device.

.. note::
    From the mobile app as the Tedee Lock owner/admin, you can see users who have access to the device and those who have pending invitations. The pending invitation means that the invited user has no account created in the Tedee App, and the access will be granted automatically after the registering. 

**Sample request**

.. code-block:: sh

 curl -X GET "|apiUrl|/api/|apiVersion|/my/device/1/access" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


Removing user access
---------------------

If user access was limited in time then it will expire automatically after the specified ``endDate``.

Let's consider a different situation. Unfortunately, you need to fire one of your employees. In that case, you must call the :doc:`Delete access <../endpoints/deviceaccess/delete>` endpoint to remove his access to the Lock.

To find the access, you need the **employee email** the access was created for. Use :doc:`Get device access list <../endpoints/deviceaccess/get-all>` with ``Filters.Email`` parameter to fetch employee access for the specific Tedee Lock.

**Sample request**

.. code-block:: sh

 curl -X DELETE "|apiUrl|/api/|apiVersion|/my/device/1/access/15" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>"


.. note::
   You do not need to remove accesses where the ``endDate`` is defined. When it is specified, the access is active only till this date.

