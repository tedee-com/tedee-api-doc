Release notes
=============

**2021-05-24:**

* added a new API version 1.19
* added timezone for lock and bridge devices
* removed "Put" endpoint and added "Patch" endpoint to bridge update

**2021-05-10:**

* added a new API version 1.18
* removed "unregister" endpoint from StandardNotificationHub

**2021-04-26:**

* added a new API version 1.17
* added endpoint to check close/open/pull operation status
* changed response for close/open/pull operation request (added "lastStateChangedDate" and changed result code to 202 Accepted)
* added "lastStateChangedDate" and "stateChangeResult" to all endpoints returning Lock state

**2021-01-18:**

* added a new API version 1.16
* all user settings moved to a new "userSettings" property in the Lock type
* removed "bridgeId" property from the Lock type
* removed "connectedToId", "iotDeviceName" and "voipNumber" properties from Bridge type

**2020-12-07:**

* removed API versions 1.10, 1.11 and 1.12
* added information about an ongoing bridge software update
* lock state returned as an enum

**2020-11-23:**

* scopes applied to all API endpoints
* added new endpoints for lock synchronization
* API versions in swagger sorted in descending order
