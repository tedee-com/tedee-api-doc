=======================
Tedee API documentation
=======================

.. image:: https://readthedocs.com/projects/tedee-tedee-api-doc/badge/?version=latest&token=c15c0a0bb62ff2f28681d75ba3b06908a59633e67d3669989d156498b63fbbd2
    :target: https://tedee-tedee-api-doc.readthedocs-hosted.com/en/latest/?badge=latest
    :alt: Documentation Status

Overview
========

This repository contains a documentation of the `Tedee's API <https://api.tedee.com/>`_. It aims to help users to integrate with the API by providing guides and code samples.

You can find a compiled version of this documentation `here <https://tedee-tedee-api-doc.readthedocs-hosted.com/en/latest/>`_.

Visit our website `tedee.com <https://tedee.com>`_.

Contribution
============

If you think that there are some areas that should be improved or extended please let us know by creating an `Issue <https://github.com/tedee-com/tedee-api-doc/issues>`_.
However, we also highly encourage you to contribute to this repo, wheather you want to add some description, guide or provide a sample code.

Documentation specification
---------------------------

The documentation is:

- Written in `RST markup <https://docutils.sourceforge.io/docs/user/rst/quickref.html>`_
- Generated using `Sphinx <https://www.sphinx-doc.org/en/master/>`_
- Hosted on `ReadTheDocs <https://readthedocs.org/>`_

How to start
------------

Prepare the infrastructure
^^^^^^^^^^^^^^^^^^^^^^^^^^
| To start working on this documentation you will have to install required components.
  It's well described in `ReadTheDocs documentation <https://docs.readthedocs.io/en/stable/intro/getting-started-with-sphinx.html>`_.
| However, here's a quick list of what needs to be done:

* Install `Python <https://www.python.org/downloads/>`_

    .. note::
        In the Python installation wizard check the "Add Python to environment variables" option

* Install `Sphinx <https://www.sphinx-doc.org/en/master/>`_

    .. code-block:: py

        pip install sphinx

Prepare your environment
^^^^^^^^^^^^^^^^^^^^^^^^

We find the `Visual Studio Code <https://code.visualstudio.com/>`_ to be a great IDE to work on this documentation.
Since it's written in **RST** markup, we recommend to install `RST Preview <https://marketplace.visualstudio.com/items?itemName=tht13.rst-vscode>`_ extension
to highlight the syntax. It also allows you to immediately preview the document in the IDE using ``ctrl+shiht+v`` combination or ``ctrl+k v`` to  open preview to the side.

Build and test
^^^^^^^^^^^^^^

| Once you install all the required components, setup the environment and clone the repo, you're ready to make some changes.
  As it was mentioned earlier you can preview your changes in the IDE. However, to get the full documentaion running locally, you'll have to generate it.

1. Open terminal and go to ``docs`` directory
2. Build the documentaion by executing this command

    .. code-block:: py

        .\make.bat html

3. After a while you should get the ``_build`` folder created where you can find there ``html`` catalog with ``index.html`` file inside. Open it.

| Sometimes you may notice that after running ``make html`` command, the files won't get updated.
  In such case we recommand to run ``make clean`` command or just remove ``_build`` catalog and try again.

Pushing changes
^^^^^^^^^^^^^^^

Please make your changes in feature branches starting from master branch, using naming convention presented below:

* `feature/[feature-description]` - to implement new features, eg. `feature/authenticate-module`
* `fix/[bug-description]` - to fix bugs, eg. `bug/incorect-link`

Once the changes are done and tested you are ready to create a pull request.