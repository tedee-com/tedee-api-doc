API rate limit
==============

We have implemented a rate-limiting policy for API requests to ensure optimal performance and stability of our services. Please be aware of the following restrictions.

Usage
-----

* **Rate limit** - Users can send up to **700 requests per 1-hour window**. The limit is applied per user account.
* **Exceeding the limit** - If the rate limit is exceeded, further requests will be temporarily blocked until the beginning of the next 1-hour window.
* **HTTP Status Code** -  Requests that exceed the rate limit will receive an HTTP status code of 429 (Too Many Requests).
* **Retry-After header** - The HTTP 429 status code response will include a Retry-After header indicating the number of seconds to wait before retrying the request.

Best practices to avoid rate limiting
-------------------------------------

.. warning::
    Ensure you are not filling the limit for synchronizing your devices states. You need to keep a free pool of requests to operate on your devices, e.g., open and close your locks.

* **Monitor your usage**. Track the number of requests your application is making to avoid approaching the rate limit threshold.
* **Optimize your requests**. Avoid making unnecessary requests and ensure that your application is using the API efficiently.
* **Send requests in intervals**. Distribute your requests evenly over time instead of sending them all at once. This can help avoid hitting the rate limit and improve the reliability of your requests.
* **Utilize sync endpoints appropriately**. If you only want to synchronize one lock, use the :doc:`Sync single <../endpoints/lock/sync-single>` endpoint. If you need to synchronize several, use the :doc:`Sync locks <../endpoints/lock/sync>` endpoint.  Remember that you can provide specific lock IDs to sync in the :doc:`Sync locks <../endpoints/lock/sync>` endpoint.
