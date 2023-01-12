Webhooks overview
====================================

From an integration perspective, it is very important to keep devices information always up to date. 
Instead of periodically sending requests to the Tedee API to refresh devices, we provide webhooks functionality for integrations. Webhooks notify you if there are any updates on users' devices.

Webhooks are designed for integrations using OAuth authentication (have a client id issued for their application by Tedee). 
When submitting an application registration request for your integration, you can provide a webhook URL in the form (:ref:`How to register your app <Oauth-20>`).

Once we register a webhook URL for your integration, we will send POST requests to that URL if there are any changes to the devices connected to your integration.

We send webhooks for all connected users, which allows you to receive device changes for each user independently. 
Example: If a device has an owner and another user, where both are using integration, then two webhooks will be sent for one event on the device. 
The 'Data' object in the webhooks is the same, but the user identities are different.

**Available webhooks**

- `Device battery level changed <device-battery-level-changed.html>`_
- `Device connection changed <device-connection-changed.html>`_
- `Device settings changed <device-settings-changed.html>`_
- `Lock status changed <lock-status-changed.html>`_