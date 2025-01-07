Webhooks overview
====================================

From an integration perspective, it is crucial to keep device information up to date. 
Webhook notifications solve this problem by automatically sending updates when changes happen. This eliminates the need to periodically send requests to the Tedee API to refresh devices. 
We use webhook notifications to send updates about important changes on the user's devices, for example, when the lock status or device connection is changed.

Webhooks feature is designed for integrations using OAuth authentication (which has a client id issued for their application by Tedee). 
When submitting an application registration request for your integration, you can provide a webhook URL in the form (:ref:`How to register your app <Oauth-20>`).

.. note::
    Remember that the lock must be paired with the bridge to track changes in real time and have the webhooks working properly.

Once the webhook URL for your integration is registered, the Tedee system will send POST requests to that URL when any changes on the devices connected to your integration occur.

We send webhooks for all connected users separately, which allows you to receive device changes for each user independently.

**Example**: Imagine there is the Tedee lock that has been opened. Suppose the Tedee lock has more than one user - for example, an owner and admin, where both of them are connected to your integration. 
In that case, two webhook notifications will be received on your webhook URL. The 'Data' object in the webhook notifications is identical, but user identities differ.

**Available webhooks**

- `Device battery level changed <device-battery-level-changed.html>`_
- `Device connection changed <device-connection-changed.html>`_
- `Device settings changed <device-settings-changed.html>`_
- `Lock status changed <lock-status-changed.html>`_
- `Bell button pressed <bell-button-pressed.html>`_