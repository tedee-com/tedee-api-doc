How to manage device shares
==============================

This tutorial will go through the Tedee Lock shares management based on a real case scenario, managing access to the Tedee Lock within an organization.

Imagine an organization where the Tedee Lock is installed in the main door. You want to automatically grant access to the main entrance when a new employee is hired and taken away when the employee ends his job. 

List device shares
-------------------

You can use the Tedee App or the Tedee API to see all shares for the specific Tedee Lock. 

Using the Tedee API, if you want to get shares for the Tedee Lock, you need the ``deviceId`` and use :doc:`Get all shares <../endpoints/deviceshare/get-all>`. 
This endpoint will return all shares for the device. 

.. note::
    From the mobile app as the Tedee Lock owner/admin, you can see users who have access to the device and those who have pending invitations. The pending invitation means that the invited user has no account created in the Tedee App, and the access will be granted automatically after the account creation. 

**Sample request**

.. code-block:: sh

 curl -X GET "|apiUrl|/api/|apiVersion|/my/deviceShare?deviceId=1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"

Creating share access
------------------------

Let's consider that situation. You are responsible for managing entrance access in your organization, and you want to automate granting access to the Tedee Lock. 

You can automate this process by creating a share in Tedee API. Then, all you need is when the new employee will start work and an email the employee will use.

You need to use :doc:`Create share <../endpoints/deviceshare/create>` endpoint. Call this endpoint with the new organization's email address to create a new device share.

If the employee you want to share the device with already has a Tedee account, he will receive a notification that the device was shared with him. Otherwise, an email invitation will be sent automatically by the Tedee system.

**Sample request**

.. code-block:: sh

 curl -X POST "|apiUrl|/api/|apiVersion|/my/deviceshare" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

 {
    "deviceId": 1,
    "accessLevel": 1,
    "userEmail": "john.doe@email.com"
    "repeatEvent": {
        "weekDays": 10,
        "dayStartTime": "2020-12-14T08:09:57.781Z",
        "dayEndTime": "2020-12-31T08:10:57.781Z",
        "startDate": null,
        "endDate": null
    },
    "remoteAccessDisabled" : false
 }

In the next section, we will present how you can customize access to the Tedee Lock.

.. note::
    We recommend using **email** as the identifier of the share. You can use it later to find the share, e.g. if you want to update or delete it.

Share types
------------
Not all employees should have the same access to the main entrance. For some of them, you will assign a permanent share, but, e.g., for subcontractors or other services like, e.g., cleaning service, you want to narrow the access to the office.

The sharing feature enables the creation of fully customized access to the Tedee Lock. The access can be permanent, time-restricted, or fully customized - which means the access can be constrained by time, weekdays, or daily hours.

Permanent access
^^^^^^^^^^^^^^^^

If you want a user to have permanent access to the Tedee Lock, you need to send an empty :doc:`repeatEvent <../datastructures/repeat-event>` object.

**Sample repeat event object**

.. code-block:: js

 "repeatEvent": {
    "weekDays": null,
    "dayStartTime": null,
    "dayEndTime": null,
    "startDate": null,
    "endDate": null
 },

Customized access
^^^^^^^^^^^^^^^^^^^^

If you want to restrict user access to the Tedee Lock, you can send ``startDate`` or ``endDate`` fields. The share will be active only in the specified period.
You can also restrict access to specific day hours by sending ``dayStartTime`` and ``dayEndTime``. You can further customize the access by selecting only particular weekdays.
To send it properly, you need to use :doc:`Week days <../enums/week-days>` enum. 

**Sample repeat event objects**

In this case, the share will be created from 14 December 2020 to 31 December 2020.

.. code-block:: js

 "repeatEvent": {
    "weekDays": null,
    "dayStartTime": null,
    "dayEndTime": null,
    "startDate": "2020-12-14T08:09:57.781Z",
    "endDate": "2020-12-31T08:10:57.781Z"
 },

In this case, the share will be created from 1 December 2020 to 31 December 2020, and the user will have access only on Friday and Saturday between 15:00 and 18:00.

.. code-block:: js

 "repeatEvent": {
    "weekDays": 48,
    "dayStartTime": "2020-12-01T15:00:00.000Z",
    "dayEndTime": "2020-12-31T18:00:00.000Z",
    "startDate": "2020-12-01T08:00:00.000Z",
    "endDate": "2020-12-31T20:00:00.000Z"
 },


In this case, the user will have access only from Monday to Friday between 8:00 and 16:00.

.. code-block:: js

 "repeatEvent": {
 "weekDays": 31,
 "dayStartTime": "2020-12-01T08:00:00.000Z",
 "dayEndTime": "2020-12-31T16:00:00.000Z",
 "startDate": null,
 "endDate": null
 }

Update share access
----------------------

If you want to change your employees' access to the main entrance, for example, if you're going to give some of the admin permissions, you can update user share.

To find the share, you need the **employee email** the share was created. Firstly, use :doc:`Get device shares <../endpoints/deviceshare/get-all>` to fetch all shares for the specific Tedee Lock, and later find the share using the email.

Finally, to update the share use :doc:`Update share <../endpoints/deviceshare/update>` endpoint.

**Sample request**

.. code-block:: sh

 curl -X PATCH "|apiUrl|/api/|apiVersion|/my/deviceshare" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

 {
    "id": 1,
    "accessLevel": 1,
    "repeatEvent": {
        "id": 1,
        "weekDays": 10,
        "dayStartTime": "2020-12-14T08:09:57.781Z",
        "dayEndTime": "2020-12-31T08:10:57.781Z",
        "startDate": null,
        "endDate": null
    },
    "remoteAccessDisabled" : false
 }


Delete share access
---------------------

Let's consider a different situation. Unfortunately, you need to fire one of your employees. 

After deleting access to organization resources, you can also remove employees' access to the organization's Tedee Lock devices using :doc:`Delete share <../endpoints/deviceshare/delete>` endpoint.

The delete endpoint requires finding ``shareId``. You can obtain it by fetching all device shares from :doc:`Get all shares <../endpoints/deviceshare/get-all>` and finding it, searching the list by ``userEmail``. 

**Sample request**

.. code-block:: sh

 curl -X DELETE "|apiUrl|/api/|apiVersion|/my/deviceshare/15" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>"

