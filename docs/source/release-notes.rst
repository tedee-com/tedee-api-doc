Release notes
=============

2026-01-07
----------

**New Features:**

* Added `DeviceAccess > Copy permissions <https://api.tedee.com/swagger/index.html#/DeviceAccess/CopyDeviceAccess>`_ – copies device access to other users or groups.

2025-08-11
----------

**API v37 – BREAKING CHANGE** ·

Migration note: Integrations using device access endpoints must adopt ``principalId`` and ``principalType``; ``userEmail`` is now conditional on principal type.

**Breaking Changes:**

* ``[CHANGED]`` :doc:`Access details <../datastructures/access-details>` extended with ``principalId``, ``principalType``, and ``principalName``; ``userEmail`` is now required only for user access (``principalType: 0``).
* ``[CHANGED]`` ``principalId`` is required when creating access for user groups (``principalType: 1``).

**New Features:**

* Added complete :doc:`Organization Groups <../endpoints/organizationgroups/index>` management – create, update, and delete groups; manage members; grant device access to groups.
* Added ``principalType`` and ``principalId`` filters to device access endpoints.

**Documentation:**

* Updated :doc:`How to manage device access <../howtos/manage-device-access>` guide with user group support.

2025-06-09
----------

**New Features:**

* Added :doc:`Event type <../enums/event-type>`: ``LockPulledByAutoUnlock``.
* `Lock > Get all locks <https://api.tedee.com/swagger/index.html#/Lock/GetAllLocks>`_ extended with ``Filters.AccessLevel`` to filter locks by :doc:`Access level <../enums/access-level>`.

2025-04-22
----------

**New Features:**

* `Organization Device > Get organization devices <https://api.tedee.com/swagger/index.html#/OrganizationDevice/GetOrganizationDevices>`_ response extended with ``connectedToId`` property (from API version 1.28).

2025-04-07
----------

**API v1.36 – BREAKING CHANGE** ·

Migration note: Integrations using bridge pairing or unpairing endpoints must update their request and response handling.

**Breaking Changes:**

* ``[CHANGED]`` Schema of `Bridge > Pair bridge with device <https://api.tedee.com/swagger/index.html#/Bridge/PairDeviceWithBridge>`_ endpoint updated.
* ``[CHANGED]`` Schema of `Bridge > Unpair bridge from device <https://api.tedee.com/swagger/index.html#/Bridge/UnpairDeviceFromBridge>`_ endpoint updated.

2025-03-25
----------

**API v1.35 – BREAKING CHANGE** ·

Migration note: Integrations reading ``organizationName`` or ``organizationSlug`` from lock responses, or using ``lockProperties``, must update before adopting v1.35.

**Breaking Changes:**

* ``[REMOVED]`` ``organizationName`` and ``organizationSlug`` from :doc:`Lock <../../datastructures/lock>` – no longer returned from :doc:`GET Lock <../endpoints/lock/get-single>`, :doc:`GET All Locks <../endpoints/lock/get-all>`, or :doc:`Get devices with details <../endpoints/device/get-all-with-details>`.
* ``[RENAMED]`` ``lockProperties`` → ``deviceState`` in :doc:`Lock Single Sync <../../endpoints/lock/sync-single>`, :doc:`Lock Sync <../../endpoints/lock/sync>`, and all organization endpoints.

2025-02-10
----------

**New Features:**

* ``Lock`` extended with ``DoorStateEventLoggingEnabled`` setting – enables or disables creation of ``DoorOpened`` and ``DoorClosed`` events from the door sensor in activity logs. Default: ``false``.

2025-01-27
----------

**API v1.34 – BREAKING CHANGE** ·

Migration note: Integrations using the Device Share area must migrate to the `Device Access area <https://api.tedee.com/swagger/index.html#/DeviceAccess>`_; access data is now returned in ``accessDetails`` instead of ``shareDetails``.

**Breaking Changes:**

* ``[CHANGED]`` Device Share area replaced by the `Device Access area <https://api.tedee.com/swagger/index.html#/DeviceAccess>`_.
* ``[RENAMED]`` ``shareDetails`` → ``accessDetails`` in device access responses.
* ``[RENAMED]`` ``lockProperties`` → ``deviceState`` in the :doc:`Lock <../../datastructures/lock>` model.
* ``[CHANGED]`` Access restrictions moved to :doc:`access details <../../datastructures/access-details>`.

2025-01-13
----------

**New Features:**

* API v1.33 extended with :doc:`Door Sensor Area <../endpoints/doorsensor/index>` for managing door sensor devices.

2024-12-16
----------

**New Features:**

* ``Lock`` extended with ``AutoLockAfterDoorClosedEnabled`` setting – enables auto-locking after the door closes. Default: ``false``.
* Added :doc:`Event type <../enums/event-type>`: ``DoorOpenTooLong``.
* Added :doc:`Bell Button Pressed <../webhooks/bell-button-pressed>` webhook event.

2024-11-18
----------

**New Features:**

* `Device > Transfer ownership <https://api.tedee.com/swagger/index.html#/Device/PostTransferDeviceOwnership>`_ extended with ``removeExistingShares`` parameter – if ``true``, all existing shares are removed from transferred devices.

2024-11-04
----------

**New Features:**

* `Device > Transfer ownership <https://api.tedee.com/swagger/index.html#/Device/PostTransferDeviceOwnership>`_ now supports transferring multiple devices at once; pairings with devices outside the transfer request are automatically removed.
* ``deviceSettings`` removed from the dry contact model – dry contact configuration is now only possible through the mobile app.

2024-10-22
----------

**New Features:**

* Added `Device > Transfer ownership <https://api.tedee.com/swagger/index.html#/Device/PostTransferDeviceOwnership>`_ endpoint – transfers device ownership to another user (owner permission required).

**Bug Fixes:**

* Fixed: exception in `Organization access link > Edit organization access link <https://api.tedee.com/swagger/index.html#/OrganizationAccessLink/PatchAccessLink>`_ when changing device order.

2024-10-07
----------

**New Features:**

* `Lock > Get Accessories <https://api.tedee.com/swagger/index.html#/Lock/GetAccessories>`_ extended with ``AccessoryType`` parameter to filter accessories by type.
* ``Keypad`` model extended with ``deviceState``, including ``batteryLevel`` and ``batteryLevelModifiedDateTime`` (returned only if no older than 30 days).

2024-09-23
----------

**API v1.33 – BREAKING CHANGE** ·

Migration note: Integrations accessing accessories via direct lock fields or the old dedicated pair/unpair endpoints must switch to the ``accessories`` array and the new unified endpoints.

**Breaking Changes:**

* ``[REMOVED]`` ``connectedToDryContactId`` and ``connectedToKeypadId`` from ``Lock`` model; replaced by ``accessories`` array of type :doc:`Lock Accessory [] <../datastructures/lock-accessory>`.
* ``[REMOVED]`` `Lock > Pair lock with DryContact device <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/PairLockWithDryContact>`_ endpoint.
* ``[REMOVED]`` `Lock > Unpair lock from DryContact device <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/UnpairLockFromDryContact>`_ endpoint.
* ``[REMOVED]`` `Lock > Pair lock with Keypad device <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/PairDeviceWithKeypad>`_ endpoint.
* ``[REMOVED]`` `Lock > Unpair lock from Keypad device <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/UnpairDeviceFromKeypad>`_ endpoint.

**New Features:**

* Added `Lock > Pair Accessory <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.33#/Lock/PairLockWithAccessory>`_ endpoint – pairs any accessory type to a lock.
* Added ``revision`` field to :doc:`Lock > Sync <../../endpoints/lock/sync>` and :doc:`Lock > Sync single <../../endpoints/lock/sync-single>` endpoints.
* `DeviceShare > Post Bulk <https://api.tedee.com/swagger/index.html#/DeviceShare/PostBulkDeviceShare>`_ response extended with user display name.

2024-08-12
----------

**New Features:**

* Added `Lock > Get Accessories <https://api.tedee.com/swagger/index.html#/Lock/GetAccessories>`_ endpoint – returns accessories available to pair with the lock.
* Added `Lock > Unpair Accessory <https://api.tedee.com/swagger/index.html#/Lock/UnpairLockFromAccessory>`_ endpoint – unpairs an accessory from a lock.

**Bug Fixes:**

* Fixed: BleBox devices now display correctly in the Tedee app after account linking.

2024-07-15
----------

**New Features:**

* `User > Delete account <https://api.tedee.com/swagger/index.html#/User/DeleteUser>`_ returns ``HTTP 412 Precondition Failed`` when the user owns an organization – the organization must be `deleted first <https://api.tedee.com/swagger/index.html#/Organization/DeleteOrganization>`_.

2024-07-02
----------

**New Features:**

* `Organization user > Add user to organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/PostOrganizationUser>`_ extended with ``role`` property.
* Personal access key global rate limit introduced: 1000 requests per hour.

2024-06-17
----------

**New Features:**

* Added `DryContact > Get all <https://api.tedee.com/swagger/index.html#/DryContact/GetAllDryContacts>`_ endpoint.
* :doc:`Unlock gate <../../endpoints/gate/unlock>` extended with new HTTP statuses:
    + ``412 Precondition Failed`` – no active BleBox integration.
    + ``423 Locked`` – gate is disconnected.

2024-06-03
----------

**New Features:**

* Added ``DryContact`` area with CRUD endpoints: `Add <https://api.tedee.com/swagger/index.html#/DryContact/PostDryContact>`_, `Update <https://api.tedee.com/swagger/index.html#/DryContact/PatchDryContact>`_, `Delete <https://api.tedee.com/swagger/index.html#/DryContact/DeleteDryContact>`_, `Get <https://api.tedee.com/swagger/index.html#/DryContact/GetDryContact>`_.
* ``Lock`` area extended with `Pair DryContact <https://api.tedee.com/swagger/index.html#/Lock/PairLockWithDryContact>`_ and `Unpair DryContact <https://api.tedee.com/swagger/index.html#/Lock/UnpairLockFromDryContact>`_ endpoints.
* :doc:`Lock <../../datastructures/lock>` extended with ``connectedToDryContactId`` property.
* `Device > Get devices with details <https://api.tedee.com/swagger/index.html#/Device/GetDevicesWithDetails>`_ response extended with ``drycontacts[]`` array.

2024-02-19
----------

**New Features:**

* :doc:`Device settings <../../datastructures/device-settings>` extended with ``isAsync`` (hotel mode) property for lock devices.

2023-11-27
----------

**New Features:**

* `Bridge > Get paired devices <https://api.tedee.com/swagger/index.html#/Bridge/GetPairedDevices>`_ response extended with ``serialNumber``, ``softwareVersion``, and ``state`` properties.

2023-10-30
----------

**New Features:**

* `Gate > Unlock Gate <https://api.tedee.com/swagger/index.html#/Gate/UnlockGate>`_ returns ``HTTP 408 Request Timeout`` when connecting to a BleBox device times out.

2023-10-16
----------

**New Features:**

* `Organization > Get organization permission matrix <https://api.tedee.com/swagger/index.html#/Organization/GetOrganizationPermissions>`_ extended with ``Filters.Text`` (search by name or email) and ``Filters.DeviceId[]`` filters.
* `Lock > Calibrate Lock <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/CalibrateLock>`_ and `Calibrate Pull Spring <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/CalibratePullSpring>`_ now return ``HTTP 409 Conflict`` when bridge firmware is outdated.

2023-10-02
----------

**API v1.32 – BREAKING CHANGE** ·

Migration note: Integrations using the old lock calibration endpoints must switch to the new ``Calibrate Lock`` and ``Calibrate Pull Spring`` endpoints.

**Breaking Changes:**

* ``[REMOVED]`` Old lock calibration endpoints; replaced by `Lock > Calibrate Lock <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/CalibrateLock>`_ and `Lock > Calibrate Pull Spring <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20V1.32#/Lock/CalibratePullSpring>`_.

**New Features:**

* Lock device setting added: ``autoUnlockCancelOtherAutoUnlock`` – cancels other auto-unlocks when one triggers.
* User profile setting added: ``dynamicFirstLock`` – dynamically changes the first lock on the device list based on user location.

2023-09-18
----------

**API v1.31 – BREAKING CHANGE** ·

Migration note: Integrations passing ``UserId`` to organization endpoints must switch to ``OrganizationUserId``.

**Breaking Changes:**

* ``[CHANGED]`` `Organization > Get activities <https://api.tedee.com/swagger/index.html#/Organization/GetActivities>`_ now takes ``OrganizationUserId`` instead of ``UserId``.
* ``[CHANGED]`` `Organization User > Get all user organization devices with permissions <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetUserDevices>`_ now takes ``OrganizationUserId`` instead of ``UserId``; response extended with ``Timezone`` per device.
* ``[CHANGED]`` `Organization User > Get organization user profile <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetOrganizationUserProfile>`_ now takes ``OrganizationUserId`` instead of ``UserId``; response extended with ``OrganizationUserId``, ``UserId``, and ``Roles``.

**New Features:**

* `Organization User > Add user to organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/PostOrganizationUser>`_ returns ``organizationUserId`` in the response body.
* Added `Organization Device > Return all shares for specific device <https://api.tedee.com/swagger/index.html#/OrganizationDevice/GetSpecificDeviceShareDetails>`_ endpoint.

2023-08-07
----------

**New Features:**

* `Organization User > Get all users from organization <https://api.tedee.com/swagger/index.html#/OrganizationUser/GetOrganizationUsers>`_ extended with filter to search by name or email, and option to include pending users.
* `Gate > Sync single <https://api.tedee.com/swagger/index.html#/Gate/SyncSingleGate>`_ extended with ``IncludeUserSetting`` parameter.

2023-07-24
----------

**New Features:**

* ``Bridge`` extended with ``LocalApiEnabled`` setting.
* Rate limit applied to ``Get All Locks`` endpoint for personal access keys: 10 requests per 10 minutes.
* Organization endpoints extended with ``deviceType`` property.

2023-07-10
----------

**New Features:**

* Organization access links extended with ``location`` support.

2023-06-26
----------

**New Features:**

* `Integration > Disconnect with BleBox <https://api.tedee.com/swagger/index.html#/Integration/DisconnectBleBoxAccount/>`_ extended with option to hard-delete gates.

2023-06-12
----------

**New Features:**

* Added `Gate > Delete Gate device <https://api.tedee.com/swagger/index.html#/Gate/DeleteGate>`_ endpoint.
* ``Gate`` extended with ``Location`` property and remote unlock setting.
* `Gate > Unlock Gate <https://api.tedee.com/swagger/index.html#/Gate/UnlockGate>`_ updated: success now returns ``204 No Content`` instead of ``200 OK`` with no response body.
* `Integration > Update linked BleBox account connection <https://api.tedee.com/swagger/index.html#/Integration/PatchLinkedBleBoxAccount/>`__ now supports personal access key authentication.
* ``OrganizationAccessLink`` description limit extended to 1000 characters.
* `Device > Clone device data <https://api.tedee.com/swagger/index.html#/Device/Clone>`_ extended with ``userSettings`` cloning (``DataToClone`` value: ``4``).

2023-05-29
----------

**New Features:**

* Added `Device > Clone device data <https://api.tedee.com/swagger/index.html#/Device/Clone>`_ endpoint – clones device settings and permissions to another device.
* Added `Gate > Show all gates <https://api.tedee.com/swagger/index.html#/Gate/GetAllGates>`_ endpoint.
* Added `Integration > Sync BleBox Accounts <https://api.tedee.com/swagger/index.html#/Integration/PostSyncBleBoxAccounts>`_ endpoint – synchronizes BleBox accounts with Tedee Cloud.
* `Organization Access Link > Get organization access links <https://api.tedee.com/swagger/index.html#/OrganizationAccessLink/GetAllAccessLinksForOrganization>`_ now returns results sorted by name.
* ``Gate`` firmware version is returned in the ``softwareVersions`` property.

**Bug Fixes:**

* Fixed: guest users can now update gate settings via `Gate > Update Gate device <https://api.tedee.com/swagger/index.html#/Gate/PatchGate>`_.

2023-05-15
----------

**New Features:**

* ``OrganizationAccessLink`` name limited to 50 characters; description limited to 500 characters.
* ``Gate`` models extended with ``Icon`` property for selecting a predefined icon.

2023-04-10
----------

**New Features:**

* `Integration > Update linked BleBox account connection <https://api.tedee.com/swagger/index.html#/Integration/PatchLinkedBleBoxAccount>`_ extended with optional ``organizationId`` parameter – assigns all BleBox devices to the specified organization.

**Bug Fixes:**

* Fixed: ``userEmail`` is now validated when creating a device share.

2023-03-27
----------

**API v1.30 – BREAKING CHANGE** ·
**New Features:**

* Added organization access links management endpoints.

2022-12-05
----------

**API v1.29 – BREAKING CHANGE** ·

Migration note: Integrations reading ``HoldToUnlock`` as a boolean must update to handle it as an enum value.

**Breaking Changes:**

* ``[CHANGED]`` ``HoldToUnlock`` user setting type changed from boolean to enum.

2022-08-16
----------

**API v1.28 – BREAKING CHANGE** ·

Migration note: Integrations using the old organization endpoints must migrate to the unified organization/device area schema before adopting v1.28.

**Breaking Changes:**

* ``[REMOVED]`` Old organization endpoints.
* ``[CHANGED]`` Organization/device area schema unified.

2022-07-18
----------

**API v1.27 – BREAKING CHANGE** ·

Migration note: Integrations reading the unlocked notification from global user settings must remove this field before adopting v1.27.

**Breaking Changes:**

* ``[REMOVED]`` Unlocked notification from global user settings.

2022-06-20
----------

**API v1.26 – BREAKING CHANGE** ·

Migration note: Integrations consuming the ``my/lock`` endpoint must update to handle paged responses.

**Breaking Changes:**

* ``[CHANGED]`` ``my/lock`` endpoint now returns paged and filterable results.

**New Features:**

* Added support for device notification settings.
* ``my/lock`` endpoint extended with ``IncludeOrganization`` parameter.

2022-02-28
----------

**New Features:**

* ``Lock`` extended with user setting for WiFi checking in auto-unlock.

2022-01-31
----------

**New Features:**

* ``Keypad`` extended with setting to enable or disable lock action by keypad button.
* Added event types: ``LockedByKeypadWithPin`` and ``LockedByKeypadWithoutPin``.

2022-01-17
----------

**New Features:**

* Keypad is now automatically paired with bridge when paired with a lock.

**Deprecations:**

* API version 1.9 retired.

2021-12-20
----------

**API v1.25 – BREAKING CHANGE** ·

**Breaking Changes:**

* ``[CHANGED]`` Keypad sound volume values are now restricted to an allowed range.

**New Features:**

* ``Keypad`` extended with ``batteryType`` setting.

2021-11-22
----------

**API v1.24 – BREAKING CHANGE** ·

**New Features:**

* ``Keypad`` extended with setting to enable or disable the bell button.

2021-11-08
----------

**API v1.23 – BREAKING CHANGE** ·

Migration note: Integrations using mobile device identifiers must update from ``integer`` to UUID format.

**Breaking Changes:**

* ``[CHANGED]`` Mobile device identifier type changed from ``integer`` to UUID.

2021-10-25
----------

**New Features:**

* ``Mobile`` endpoint extended with ``Other`` as a supported operating system.

2021-10-11
----------

**New Features:**

* Timezone validation added for devices.
* Added endpoints for keypad PIN list management.
* Request rate limit added on lock sync endpoints.
* ``my`` prefix added to personal access key endpoints.
* Email notification sent after creating a personal access key.

2021-09-27
----------

**API v1.22 – BREAKING CHANGE** ·

Migration note: Integrations creating device shares must remove ``accessType`` from requests; integrations using the unlock endpoint must update to the new default mode (no auto-pull) and explicitly use the new ``unlock or pull spring`` mode when pull spring behavior is needed.

**Breaking Changes:**

* ``[REMOVED]`` ``accessType`` property from POST/PATCH device share endpoints.
* ``[CHANGED]`` Default unlock mode changed to "not pull"; new ``unlock or pull spring`` mode added for explicit pull behavior when the lock is already unlocked.

**New Features:**

* Personal access key maximum expiration extended to 5 years.

2021-09-13
----------

**New Features:**

* User authentication via personal access key introduced.
* Recurring device share can now be configured with only start/end times or only weekdays (both no longer required together).

2021-08-30
----------

**API v1.21 – BREAKING CHANGE** ·

**Bug Fixes:**

* Fixed: issue with deleting a bridge.

2021-08-16
----------

**API v1.20 – BREAKING CHANGE** ·

Migration note: Integrations using lock, unlock, or pull spring operations must update to pass all parameters in the path instead of the request body.

**Breaking Changes:**

* ``[CHANGED]`` Lock/unlock/pull operation endpoints refactored – all parameters are now in the path, not the request body.

**New Features:**

* Unlock operation extended with ``without auto pull spring`` mode.

2021-08-02
----------

**New Features:**

* Keypad pair/unpair endpoints moved to the ``Lock`` area.
* ``Lock`` model extended with ``connectedToKeypadId`` property.

2021-06-21
----------

**New Features:**

* Added endpoints to pair and unpair keypad with lock.
* ``Keypad`` extended with timezone.

**Bug Fixes:**

* Fixed: device share can now be removed when the device is in an organization.

2021-06-07
----------

**New Features:**

* Added endpoints to manage keypad devices.

2021-05-24
----------

**API v1.19 – BREAKING CHANGE** ·

Migration note: Integrations using the Bridge update endpoint must switch from ``PUT`` to ``PATCH``.

**Breaking Changes:**

* ``[REMOVED]`` Bridge ``PUT`` update endpoint; replaced by ``PATCH``.

**New Features:**

* Lock and bridge devices extended with timezone.

2021-05-10
----------

**API v1.18 – BREAKING CHANGE** ·

Migration note: Integrations calling the ``unregister`` endpoint on ``StandardNotificationHub`` must remove this call.

**Breaking Changes:**

* ``[REMOVED]`` ``unregister`` endpoint from ``StandardNotificationHub``.

2021-04-26
----------

**API v1.17 – BREAKING CHANGE** ·

Migration note: Integrations handling close/open/pull responses must update to ``202 Accepted`` and poll the new status endpoint for operation results.

**Breaking Changes:**

* ``[CHANGED]`` Close/open/pull operation requests now return ``202 Accepted``; response includes ``lastStateChangedDate``.

**New Features:**

* Added endpoint to check close/open/pull operation status.
* ``lastStateChangedDate`` and ``stateChangeResult`` added to all endpoints returning lock state.

2021-01-18
----------

**API v1.16 – BREAKING CHANGE** ·

Migration note: Integrations reading user settings directly from lock properties, or relying on ``bridgeId``, ``connectedToId``, ``iotDeviceName``, or ``voipNumber``, must update before adopting v1.16.

**Breaking Changes:**

* ``[CHANGED]`` All user settings moved from individual lock properties to the new ``userSettings`` property in the ``Lock`` type.
* ``[REMOVED]`` ``bridgeId`` from the ``Lock`` type.
* ``[REMOVED]`` ``connectedToId``, ``iotDeviceName``, and ``voipNumber`` from the ``Bridge`` type.

2020-12-07
----------

**New Features:**

* Bridge software update status added to bridge information.
* Lock state is now returned as an enum.

**Deprecations:**

* API versions 1.10, 1.11, and 1.12 retired.

2020-11-23
----------

**New Features:**

* Scopes applied to all API endpoints.
* Added new endpoints for lock synchronization.
* API versions in Swagger sorted in descending order.
