# Release Notes – Entry Template

> **Not for publication.** This file is not included in any toctree and will not appear in the built docs.
> Copy the relevant pattern below into `release-notes.rst`.

---

## Patterns

Two entry types are used. Drop any section that has no content.

---

### Pattern A – Breaking change (new API version)

Use when a new API version is introduced. The heading is the date only — the API version, breaking change label, and Swagger link appear as the first line of content, keeping the sidebar clean.

```rst
YYYY-MM-DD
----------

**API vXX – BREAKING CHANGE** · `View in Swagger <https://api.tedee.com/swagger/index.html?urls.primaryName=Tedee%20API%20VXX>`_

Migration note: one sentence stating which integrations are affected and what action is required.

**Breaking Changes:**

* ``[REMOVED]`` ``propertyName`` from ``ModelName``.
* ``[RENAMED]`` ``oldProperty`` → ``newProperty`` in ``ModelName``.
* ``[CHANGED]`` Type of ``id`` from ``integer`` to UUID.
* ``[CHANGED]`` Endpoint ``/old/path`` replaced by ``/new/path``.

**New Features:**

* Added `Area > Endpoint Name <swagger-link>`_ – one-line description.
* ``ModelName`` extended with ``newProperty`` – one-line description.

**Bug Fixes:**

* Fixed: short description.

**Documentation:**

* Updated :doc:`Guide title <../howtos/guide-name>`.
```

---

### Pattern B – Non-breaking update

Use for additive changes, fixes, and documentation updates that do not require a version bump.

```rst
YYYY-MM-DD
----------

**New Features:**

* Added `Area > Endpoint Name <swagger-link>`_ – one-line description.
* ``ModelName`` extended with ``newProperty`` – one-line description.

**Bug Fixes:**

* Fixed: short description.

**Deprecations:**

* API version vXX retired.

**Documentation:**

* Updated :doc:`Guide title <../howtos/guide-name>`.
```

---

## Writing rules

- **Swagger link** — replace `VXX` in the URL with the version number, e.g. `V37` or `V1.36`.
- **Migration note** — breaking releases only. State concretely what integrations must change (e.g. which property, endpoint, or type). Omit if the breaking changes list is self-explanatory.
- **One line per item.** If more context is needed, add a sub-bullet with `+`.
- **Tags** — use ``[REMOVED]``, ``[RENAMED]``, ``[CHANGED]`` only for breaking changes. Non-breaking additions need no tag.
- **Links** — use the Swagger URL for endpoint links; use ``:doc:`` for internal doc references.
- **Omit empty sections** — do not include a section heading if there is nothing to write under it.
