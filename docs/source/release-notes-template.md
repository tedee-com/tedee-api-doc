# Release Notes – Entry Template

> **Not for publication.** This file is not included in any toctree and will not appear in the built docs.
> Copy the relevant pattern below into `release-notes.rst`.

---

## Patterns

Two entry types are used. Drop any section that has no content.

---

### Pattern A – Breaking change (new API version)

Use when a new API version is introduced. The `[BREAKING CHANGE]` marker and migration note are the key signals for integrators and executives deciding when to act.

```rst
**YYYY-MM-DD** – API vXX [BREAKING CHANGE]

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
**YYYY-MM-DD**

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

- **Migration note** — breaking releases only. State concretely what integrations must change (e.g. which property, endpoint, or type). Omit if the breaking changes list is self-explanatory.
- **One line per item.** If more context is needed, add a sub-bullet with `+`.
- **Tags** — use ``[REMOVED]``, ``[RENAMED]``, ``[CHANGED]`` only for breaking changes. Non-breaking additions need no tag.
- **Links** — use the Swagger URL for endpoint links; use ``:doc:`` for internal doc references.
- **Omit empty sections** — do not include a section heading if there is nothing to write under it.
