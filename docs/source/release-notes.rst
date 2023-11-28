Release notes
=============

**2023-11-27**

* added "serialNumber", "softwareVersion" and "state" properties to response from `Bridge > Get paired devices <https://api.tedee.com/swagger/index.html#/Bridge/GetPairedDevices>`_ endpoint

**2023-10-30**

* improvements in `Gate > Unlock Gate <https://api.tedee.com/swagger/index.html#/Gate/UnlockGate>`_ endpoint. Endpoint now returns `HTTP 408 Request timeout` when connecting to BleBox device ends with timeout.

**2023-10-16**

* added filters to `Organization > Get organization permission matrix <https://api.tedee.com/swagger/index.html#/Organization/GetOrganizationPermissions>`_ endpoint. The currently available filters are: `Filters.Text` where you can specify user name or email, and `Filters.DeviceId [array]` where you can specify only devices you are interested in.
* improved new calibration endpoints `Lock > Calibrare Lock <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/CalibrateLock>`_ and `Lock > Calibrate Pull Spring <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/CalibratePullSpring>`_. If you try calibrating the lock using a new endpoints and your bridge firmware is outdated, you will get an `HTTP 409 Conflict` response.

**2023-10-02**

* added new API version 1.32
* added new user setting on lock device for canceling auto-unlock by other auto-unlock (autoUnlockCancelOtherAutoUnlock)
* added new user setting in user profile for dynamic changing first lock on device list based on user location (dynamicFirstLock)
* added new endpoints for lock device calibration
* removed old endpoints for lock device calibration

**2023-09-18**

* added new API version 1.31
* `Organization User > Add user to organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/PostOrganizationUser>`_ endpoint returns `organizationUserId` in the response body on success
* `Organization > Get activities for organization device or user <https://api.tedee.com/swagger/index.html#/Organization/GetActivities>`_ endpoints takes `OrganizationUserId` instead of `UserId`
* `Organization User > Get all user organization devices with permissions <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetUserDevices>`_ endpoints takes `OrganizationUserId` instead of `UserId`, `Timezone` added for each device returned in the response body
* `Organization User > Get organization user profile <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetOrganizationUserProfile>`_ endpoints takes `OrganizationUserId` instead of `UserId`, and in addition return `OrganizationUserId`, `UserId`, `Roles` in the response body
* added `Organization Device > Return all shares for specific device <https://api.tedee.com/swagger/index.html#/OrganizationDevice/GetSpecificDeviceShareDetails>`_ endpoint

**2023-08-07**

* extended `OrganizationUser Area > Get all users from organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetOrganizationUsers>`_ endpoint with filter to search by name/email and to include pending users
* added `IncludeUserSetting` parameter to `Gate Area > Sync single <https://api.tedee.com/swagger/index.html#/Gate/SyncSingleGate>`_ endpoint

**2023-07-24**

* `Bridge` extended with `LocalApiEnabled` setting
* added rate limiter for Get All Locks endpoint for Personal Access Key (10 requests per 10 minutes allowed)
* `Organization` endpoints extended with `deviceType` property

**2023-07-10:**

* added support for `location` in organization access links

**2023-06-26:**

* extended `Integration Area > Disconnect with BleBox <https://api.tedee.com/swagger/index.html#/Integration/DisconnectBleBoxAccount/>`_ endpoint with possibility to hard delete Gates

**2023-06-12:**

*  `Personal Access Key` authentication enabled on `Integration Area > Update linked BleBox account connection <https://api.tedee.com/swagger/index.html#/Integration/PatchLinkedBleBoxAccount/>`_ endpoint
*  remote unlock setting enabled for `Gate` devices
*  added `Location` property to `Gate` device 
*  `OrganizationAccessLink` description updated to 1000 chars
*  added `Gate Area > Delete Gate device <https://api.tedee.com/swagger/index.html#/Gate/DeleteGate>`_ endpoint
*  updated `Gate Area > Unlock Gate <https://api.tedee.com/swagger/index.html#/Gate/UnlockGate>`_ endpoint:
     + success operation returns `204 No Content` instead of `200 OK`
     + endpoint returns no data in response body on success
* added cloning `userSettings` in `Device > Clond device data <https://api.tedee.com/swagger/index.html#/Device/Clone>`_ endpoint
     + `DataToClone` parameter value to clone user settings is `4` 

**2023-05-29:**

* added `Device Area > Clone device data <https://api.tedee.com/swagger/index.html#/Device/Clone>`_ endpoint, which enables cloning device settings, permissions to another device
* added `Gate Area > Show all gates assigned to logged user <https://api.tedee.com/swagger/index.html#/Gate/GetAllGates>`_ endpoint
* added `Integration Area > Sync BleBox Accounts <https://api.tedee.com/swagger/index.html#/Integration/PostSyncBleBoxAccounts>`_ endpoint, which enables synchronization of BleBox accounts with Tedee Cloud
* `OrganizationAccessLink` sorted by name in `Organization Access Link Area > Get organization access links <https://api.tedee.com/swagger/index.html#/OrganizationAccessLink/GetAllAccessLinksForOrganization>`_ endpoint
* `Gate` firmware version is returned in `softwareVersions` property
*  fixes:
     +  guest user can change his user settings with `Gate Area > Update Gate device with entered Id <https://api.tedee.com/swagger/index.html#/Gate/PatchGate>`_ endpoint

**2023-05-15:**

* updated `OrganizationAccessLink` requirements:
   + `name` length constrained to 50 chars
   + `description` length constrained to 500 chars  
* extended `Gate` models with `Icon` property, which enables settings predefined icon for Gate device

**2023-04-10:**

* updated `Integration Area > Update linked BleBox account connection <https://api.tedee.com/swagger/index.html#/Integration/PatchLinkedBleBoxAccount>`_ endpoint:
     + user can optionally set the `organizationId` parameter to assign all devices from the BleBox account to the organization
* fixes:
     + `userEmail` property is validated on `DeviceShare` creating 

**2023-03-27:**

* added a new API version 1.30
* added organization access links management endpoints

**2022-12-05:**

* added a new API version 1.29
* changed HoldToUnlock user setting type to enum

**2022-08-16:**

* added a new API version 1.28
* removed old organization endpoints
* unified schema of organization/device area

**2022-07-18:**

* added a new API version 1.27
* removed unlocked notification from global user settings

**2022-06-20:**

* added a new API version 1.26
* added support for device notification settings
* added paging and filtering to my/lock endpoint
* added IncludeOrganization parameter to my/lock endpoint

**2022-02-28:**

* added new user setting on lock device for WiFi checking in auto-unlock

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
