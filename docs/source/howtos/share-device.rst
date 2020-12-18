How to manage device shares
==============================

Once user have his device set, he will probably want to share it with other users (e.g. family or friends).
To do this he need to create a share. In this tutorial we will walk through the process of creating, updating, deleting and listing share for user device.

Get current share list
----------------------------

If you want to get current shares for device, you will need deviceId and use :doc:`Get all shares <../endpoints/deviceshare/get-all>`. 
This endpoint will return all shares for device.

**Sample request**

.. code-block:: sh

    curl -X GET "|apiUrl|/api/|apiVersion|/my/deviceShare?deviceId=1" -H "accept: application/json" -H "Authorization: Bearer <<access token>>"


Prepare share data
-----------------------------

To manage access to the device you need to prepare some data. Depends on what :doc:`access type <../enums/access-type>` have been chosen you need to adjust :doc:`repeatEvent <../datastructures/repeat-event>` object in proper way.

accessType =  0 (Permanent)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^

In this case, you can send empty :doc:`repeatEvent <../datastructures/repeat-event>` object.

**Sample repeat event object**

.. code-block:: js

    "repeatEvent": {
        "weekDays": null,
        "dayStartTime": null,
        "dayEndTime": null,
        "startDate": null,
        "endDate": null
    },

accessType = 1 (TimeRestricted)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

If access type is "TimeRestricted" you need to send fields "startDate" and "endDate" it will mark the period when share for user will be active.

**Sample repeat event object**

.. code-block:: js

    "repeatEvent": {
        "weekDays": null,
        "dayStartTime": null,
        "dayEndTime": null,
        "startDate": "2020-12-14T08:09:57.781Z",
        "endDate": "2020-12-31T08:10:57.781Z"
    },


accessType = 2 (Custom)
^^^^^^^^^^^^^^^^^^^^^^^^^^

The most complicated type is "Custom". The required fields for this type are "dayStartTime" and "dayEndTime". They represent at which hour period user will have access to the device.
User can further customize this by selecting days. To send it proper way you need to use :doc:`Week days <../enums/week-days>` enum. Fields "startDate" and "endDate" are optional in this case.

**Sample repeat event objects**

In this case the share will be created from 1 december to 31 december, and user will have access only on friday and saturday between 15:00 and 18:00

.. code-block:: js

    "repeatEvent": {
        "weekDays": 48,
        "dayStartTime": "2020-12-01T15:00:00.000Z",
        "dayEndTime": "2020-12-31T18:00:00.000Z",
        "startDate": "2020-12-01T08:00:00.000Z",
        "endDate": "2020-12-31T20:00:00.000Z"
    },


In this case user will have access only from monday to friday between 8:00 and 16:00

.. code-block:: js

    "repeatEvent": {
        "weekDays": 31,
        "dayStartTime": "2020-12-01T8:00:00.000Z",
        "dayEndTime": "2020-12-31T16:00:00.000Z",
        "startDate": null,
        "endDate": null
    },


Add access to the device
----------------------------

Let's consider that situation. You are responsible for managing access for users in your organization. If new employee is recruited you don't want to give him keys to the office (or you don't use keys in your organization). 
Instead you want to share door lock to him/her. To do that you need to use :doc:`Create share <../endpoints/deviceshare/create>`. Simply call this endpoint with new organization email address to create new device share.

If user that you want to share device with already have Tedee account he will be notified that device was shared with him. If not the email with invitaion will be sent.

**Sample request**

.. code-block:: sh

    curl -X POST "|apiUrl|/api/|apiVersion|/my/deviceshare" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "deviceId": 1,
            "accessLevel": 1,
            "accessType": 2,
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


Update access to the device
----------------------------

If you want to change access to the door lock for your employees for example you want give some of them admin permissions, you can update user access to the device. 
For that you need to have shareId, which you get when creating share with success or you can simply use endpoint to get all share for the device :doc:`Get all shares <../endpoints/deviceshare/get-all>`.
When you have complete information you can send request :doc:`Update share <../endpoints/deviceshare/update>` to update share.

**Sample request**

.. code-block:: sh

    curl -X PATCH "|apiUrl|/api/|apiVersion|/my/deviceshare" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>" -d "<<body>>"

Body:

.. code-block:: js

        {
            "id": 1,
            "accessLevel": 1,
            "accessType": 1,
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


Delete share
-------------

Let's consider different situation. Unfortunately, you need to fire one of your employee. 
After deleting access to organization resources you can also remove employee's access to the devices within organization with the call to the :doc:`Delete share <../endpoints/deviceshare/delete>` endpoint.
For that you need to have share id you want to delete. You can get shares for each device from :doc:`Get all shares <../endpoints/deviceshare/get-all>` endpoint.

**Sample request**

.. code-block:: sh

    curl -X DELETE "|apiUrl|/api/|apiVersion|/my/deviceshare/15" -H "accept: application/json" -H "Content-Type: application/json-patch+json" -H "Authorization: Bearer <<access token>>"
