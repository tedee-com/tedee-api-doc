.. Tedee-docs documentation master file, created by
   sphinx-quickstart on Mon Mar 23 10:22:37 2020.
   You can adapt this file completely to your liking, but it should at least
   contain the root `toctree` directive.

Tedee API documentation
=======================

.. toctree::
   :maxdepth: 1
   :caption: Overview
   :hidden:

   getting-started
   api-versioning
   api-rate-limiting
   logo-guidance
   release-notes

.. toctree::
   :maxdepth: 1
   :caption: How to ...
   :hidden:

   Begin integration <howtos/begin-integration>
   Authenticate <howtos/authenticate>
   Get and sync locks <howtos/get-and-sync-locks>
   Operate locks <howtos/operate-locks>
   Update lock settings <howtos/update-lock-settings>
   Share device <howtos/share-device>
   Manage lock PIN list <howtos/manage-lock-pin-list>
   Manage access links <howtos/manage-access-links>
   Manage and operate gates <howtos/manage-and-operate-gates>
   Use state from door sensor <howtos/use-state-from-door-sensor>
   Connect to device via Bluetooth <howtos/connect-device-via-ble>
   Example integrations <howtos/example-integrations>

.. toctree::
   :maxdepth: 1
   :includehidden:
   :caption: Endpoints
   :hidden:

   endpoints/datetime/index
   endpoints/device/index
   endpoints/deviceactivity/index
   endpoints/devicecertificate/index
   endpoints/deviceshare/index
   endpoints/doorsensor/index
   endpoints/gate/index
   endpoints/lock/index
   endpoints/lockpin/index
   endpoints/mobile/index
   endpoints/organization/index
   endpoints/organizationaccesslink/index
   endpoints/personalaccesskey/index

.. toctree::
   :maxdepth: 1
   :caption: Webhooks
   :hidden:

   Overview <webhooks/overview>
   Device battery level changed <webhooks/device-battery-level-changed>
   Device connection changed <webhooks/device-connection-changed>
   Device settings changed <webhooks/device-settings-changed>
   Lock status changed <webhooks/lock-status-changed>

.. toctree::
   :maxdepth: 1
   :caption: Data structures
   :hidden:

   Bridge <datastructures/bridge>
   Certificate for mobile <datastructures/certificate-for-mobile>
   Device activities <datastructures/device-activity>
   Device operation <datastructures/device-operation>
   Device settings <datastructures/device-settings>
   Device share success <datastructures/device-share-success>
   Door sensor list <datastructures/door-sensor-list>
   Door sensor state <datastructures/door-sensor-state>
   Door sensor updated <datastructures/door-sensor-updated>
   Door sensor user settings <datastructures/door-sensor-user-settings>
   Door sensor <datastructures/door-sensor>
   Execute command response <datastructures/execute-command>
   Gate list <datastructures/gate-list>
   Gate user settings <datastructures/gate-user-settings>
   Gate <datastructures/gate>
   Location <datastructures/location>
   Lock <datastructures/lock>
   Lock user settings <datastructures/lock-user-settings>
   Lock PIN <datastructures/lock-pin>
   Lock PIN created <datastructures/lock-pin-created>
   Lock PIN details <datastructures/lock-pin-details>
   Lock PIN list <datastructures/lock-pin-list>
   Lock properties <datastructures/lock-properties>
   Lock sync <datastructures/lock-sync>
   Lock updated <datastructures/lock-updated>
   Lock accessory <datastructures/lock-accessory>
   Mobile identifier <datastructures/mobile-identifier>
   Mobile registered <datastructures/registered-mobile>
   Organization <datastructures/organization>
   Organization access link <datastructures/organization-access-link>
   Organization access link created <datastructures/organization-access-link-created>
   Organization access link list <datastructures/organization-access-link-list>
   Organization access link single <datastructures/organization-access-link-single>
   Organization access link device <datastructures/organization-access-link-device>
   Organization access link assignable device list <datastructures/organization-access-link-assignable-devices-list>
   Organization access link assignable device <datastructures/organization-access-link-assignable-device>
   Personal access key <datastructures/personal-access-key>
   Personal access key created <datastructures/personal-access-key-created>
   Repeat event <datastructures/repeat-event>
   Revoked certificate <datastructures/revoked-certificate>
   Revoked certificate list <datastructures/revoked-certificate-list>
   Share details <datastructures/share-details>
   Signed time <datastructures/signed-time>
   Software versions <datastructures/software-versions>

.. toctree::
   :maxdepth: 1
   :caption: Enums
   :hidden:

   Access level <enums/access-level>
   Activity source <enums/activity-source>
   Auto unlock pull condition <enums/auto-unlock-pull-condition>
   Device operation type <enums/device-operation-type>
   Device type <enums/device-type>
   Door state <enums/door-state>
   Event type <enums/event-type>
   Gate icon <enums/gate-icon>
   Lock state <enums/lock-state>
   Operating System type <enums/operating-system>
   Software type <enums/software-type>
   Unlock mode <enums/unlock-mode>
   Week days <enums/week-days>

This site contains a documentation for Tedee REST API (https://api.tedee.com).
It aims to help users to automate their lock's actions or to intergrate custom solutions with Tedee API.
You can find here guides and code samples which should help you to work with the API.

About Tedee
-----------

**Tedee** is smart home system which allows you control access to your home directly from phone. Please visit our site for more details https://tedee.com.

Useful links
------------

- `Forum <https://tedee.freshdesk.com/en/support/discussions>`_
- `Tedee API <https://api.tedee.com/>`_
- `Documentation repository <https://github.com/tedee-com/tedee-api-doc>`_
- `Tedee Bridge API documentation <https://docs.tedee.com/bridge-api>`_

Need a help?
------------

We encourage you to join a discussion or start a new one under `Community forum <https://tedee.freshdesk.com/en/support/discussions>`_ or ask on `Twiter (@tedee_smartlock) <https://twitter.com/tedee_smartlock>`_.
