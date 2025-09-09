# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Overview

This is the Tedee API documentation repository, containing RST-based documentation for the Tedee API (https://api.tedee.com/). The documentation is built with Sphinx and hosted on ReadTheDocs.

## Development Commands

### Build Documentation
- **macOS/Linux**: `cd docs && make html`
- **Windows**: `cd docs && .\make.bat html`
- **VS Code**: Use build task (Ctrl+Shift+B)
- **Clean build**: `cd docs && make clean` then rebuild

### Live Preview with Auto-reload
```bash
cd docs && make livehtml
```

### Install Dependencies
```bash
pip install -r docs/requirements.txt
```

## Architecture and Structure

### Documentation Structure
- **docs/source/**: Main documentation source files
  - **endpoints/**: API endpoint documentation organized by resource type
  - **datastructures/**: Data structure definitions
  - **enums/**: Enumeration definitions
  - **howtos/**: How-to guides and tutorials
  - **webhooks/**: Webhook documentation
  - **images/**: Documentation images
- **samples/cs/**: C# code samples project (Tedee.Api.CodeSamples)

### Key Configuration
- **docs/source/conf.py**: Sphinx configuration with API version (v1.36) and URL replacements
- **docs/requirements.txt**: Python dependencies (sphinx_rtd_theme, sphinx-copybutton, docutils<0.18)
- **.readthedocs.yaml**: ReadTheDocs build configuration

### RST Variable Replacements
The documentation uses custom replacements defined in conf.py:
- `|clientId|`: OAuth client ID
- `|apiUrl|`: API base URL (https://api.tedee.com)
- `|authApiUrl|`: Authentication API URL
- `|apiVersion|`: Current API version
- `|scopePrefix|`: OAuth scope prefix

### Branching Strategy
- Main branch: `master`
- Feature branches: `feature/[description]` (e.g., `feature/authenticate-module`)
- Bug fixes: `fix/[description]` (e.g., `fix/incorrect-link`)
- Use lowercase, no spaces, no special characters except `-` and `/`

## Documentation Standards

### Formatting and Organization
- **Alphabetical Sorting**: All fields, properties, parameters, and attributes in documentation tables must be sorted alphabetically by name
  - This applies to data structures, API parameters, request/response bodies, and any other tabular data
  - Ensures consistency and makes it easier to find specific fields
- **Parameter Naming**: Use lowercase for parameter names (e.g., `filters.principalId` not `Filters.PrincipalId`)
- **Type Specifications**: Use precise types (e.g., UUID instead of string for identifiers)

## Important Notes
- Documentation is written in RST (reStructuredText) format
- Preview RST files in VS Code with Ctrl+Shift+V or Ctrl+K V
- Generated HTML output goes to `docs/_build/html/`
- The compiled documentation is available at: https://tedee-tedee-api-doc.readthedocs-hosted.com/en/latest/