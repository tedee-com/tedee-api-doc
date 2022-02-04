Release notes
=============

**2022-01-31:**

* added new keypad device setting for enable/disable lock action by keypad button
* added new events to device activity logs (LockedByKeypadWithPin and LockedByKeypadWithoutPin)

**2022-01-17:**

* removed API version 1.9
* added automatic keypad pairing with bridge when keypad is paired with lock

**2021-12-20:**

* added a new API version 1.25
* added new keypad device setting with battery type
* added restriction for sound volume values in keypad

**2021-11-22:**

* added a new API version 1.24
* added new keypad device setting for enable/disable bell button

**2021-11-08:**

* added a new API version 1.23
* changed data type of mobile device identifier from int to guid

**2021-10-25:**

* added "Other" operating system in POST mobile endpoint

**2021-10-11:**

* added timezone validation for devices
* added endpoints for keypad pin list management
* added request rate limit in lock sync endpoints
* added "my" prefix in personal access key endpoints
* sending e-mail after creating personal access key

**2021-09-27:**

* added a new API version 1.22
* removed "accessType" property from POST/PATCH endpoints for device share
* max expiration date for personal access key set to 5 years
* changed default mode in unlock operation to "not pull" and added new "unlock or pull spring" mode, which allows to perform pull when lock is in unlocked state

**2021-09-13:**

* added user authentication based on personal access key
* allowed to set recurring device share only with start/end times or week days

**2021-08-30:**

* added a new API version 1.21
* fixed issue with deleting bridge

**2021-08-16:**

* added a new API version 1.20
* endpoints for lock/unlock/pull operations refactored to have all parameters in path instead of in body
* added "without auto pull spring" mode in unlock operation endpoint

**2021-08-02:**

* endpoints for pairing/unpairing keypad with lock moved to Lock area
* added information about keypad paired with lock ("connectedToKeypadId" property in Lock type)

**2021-06-21:**

* added endpoints to pair/unpair keypad with lock
* added timezone for keypad device
* fix: cannot remove device share when device is in organization

**2021-06-07:**

* added endpoints to manage keypad devices

**2021-05-24:**

* added a new API version 1.19
* added timezone for lock and bridge devices
* removed PUT endpoint and added PATCH endpoint to bridge update

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
