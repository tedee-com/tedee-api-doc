=======================
Tedee API documentation
=======================

.. image:: https://readthedocs.com/projects/tedee-tedee-api-doc/badge/?version=latest&token=c15c0a0bb62ff2f28681d75ba3b06908a59633e67d3669989d156498b63fbbd2
    :target: https://tedee-tedee-api-doc.readthedocs-hosted.com/en/latest/?badge=latest
    :alt: Documentation Status

Overview
========

This repository contains documentation for the `Tedee API <https://api.tedee.com/>`_. It aims to help users integrate with the API by providing guides and code samples.

You can find a compiled version of this documentation `here <https://tedee-tedee-api-doc.readthedocs-hosted.com/en/latest/>`_.

Visit our website: `tedee.com <https://tedee.com>`_.

Contribution
============

If you think there are areas that should be improved or extended, please let us know by creating an `Issue <https://github.com/tedee-com/tedee-api-doc/issues>`_.
We also highly encourage you to contribute to this repo, whether you want to add a description, guide, or provide sample code.

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
To start working on this documentation, you need to install the required components.
This is well described in the `ReadTheDocs documentation <https://docs.readthedocs.io/en/stable/intro/getting-started-with-sphinx.html>`_.
However, here's a quick list of what needs to be done:

* Install `Python <https://www.python.org/downloads/>`_

    .. note::
        In the Python installation wizard, check the "Add Python to environment variables" option.

* Install `Sphinx <https://www.sphinx-doc.org/en/master/>`_

    .. code-block:: bash

        pip install sphinx

Prepare your environment
^^^^^^^^^^^^^^^^^^^^^^^^

We find `Visual Studio Code <https://code.visualstudio.com/>`_ to be a great IDE for working on this documentation, and we configure some automation for it.
Since it's written in **RST** markup, we recommend installing the `RST Preview <https://marketplace.visualstudio.com/items?itemName=tht13.rst-vscode>`_ extension
to highlight the syntax. It also allows you to immediately preview the document in the IDE using ``ctrl+shift+v`` or ``ctrl+k v`` to open preview to the side.

Regardless of the IDE used, please do the following:

#. Clone the repository
#. (Optional) Create and activate a virtual environment (venv):

    .. code-block:: bash

        python3 -m venv venv
        source venv/bin/activate

#. Install all required dependencies from the ``docs/requirements.txt`` file.

    .. code-block:: bash

        pip install -r requirements.txt

Build and test
^^^^^^^^^^^^^^

Once you have installed all the required components, set up the environment, and cloned the repo, you're ready to make some changes.
As mentioned earlier, you can preview your changes in the IDE. However, to get the full documentation running locally, you'll have to generate it.

To build the documentation:

#. If you use Visual Studio Code, run the build task (``ctrl+shift+b``)
#. OR if you use the terminal, go to the ``docs`` directory and execute the appropriate command for your operating system:

    - On **Windows**:

      .. code-block:: bat

          .\make.bat html

    - On **macOS/Linux**:

      .. code-block:: bash

          make html

#. After a while, you should get the ``_build`` folder created, where you can find the ``html`` directory with the ``index.html`` file inside. Open it.

Sometimes you may notice that after building, the files won't get updated.
In such a case, we recommend running the ``make clean`` command or just removing the ``_build`` directory and trying again.

Pushing changes
^^^^^^^^^^^^^^^

Please make your changes in feature branches starting from the master branch, using the naming convention presented below:

* use only lowercase
* do not use whitespace
* do not use any special characters except: -/
* `feature/[feature-description]` - to implement new features, e.g. `feature/authenticate-module`
* `fix/[bug-description]` - to fix bugs, e.g. `fix/incorrect-link`

Once the changes are done and tested, you are ready to create a pull request.
