How to update lock settings
===========================

If you want to update lock settings, the first thing you need to do is use endpoint :doc:`Get single lock <../endpoints/lock/get-single>`. 
This endpoint will return data for the selected lock. The data includes the **revision** attribute. 
This is the version of the current lock settings and you must provide this value in the update request.

After successfully retrieving the revision of the current lock settings, you can use endpoint :doc:`Update lock <../endpoints/lock/update>` to update the lock.

All parameters in this endpoint (except id and revision) are optional. 
This means that specifying a given parameter will update its value in the database. If a given parameter is not specified, its value will not change.
