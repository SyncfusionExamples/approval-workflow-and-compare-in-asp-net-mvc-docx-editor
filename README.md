# Document Approval Workflow

## Overview

This sample demonstrates a document review workflow using the Syncfusion ASP.NET MVC DOCX Editor.

The application allows users to:

- Open and edit Word documents in the browser.
- Save document changes back to the server.
- Assign role-based editing permissions.
- Restrict editing to specific document regions.
- Enable comments-only review for selected users.
- Enable track changes for review workflows.
- Compare the current document with the original document.

## Users and Permissions

| User | Role | Access |
|--------|--------|--------|
| David Wilson | Loan Officer | Edit loan details and financial information |
| Sarah Johnson | Relationship Manager | Edit customer information and relationship details |
| Michael Brown | Compliance Officer | Comments-only review |
| Emma Davis | Risk Officer | Track changes mode |
| John Anderson | Branch Manager | Full document access |

## Features

### Document Editing

Users can edit Word documents directly in the browser using the DOCX Editor.

### Editable Regions

Specific sections of the document can be assigned to individual users. Only authorized users can modify those sections.

### Comments Review

Compliance users can review documents and add comments without modifying document content.

### Track Changes

Risk reviewers can make document updates through tracked revisions, allowing all changes to be reviewed later.

### Document Comparison

Users can compare the modified document against the original document and review all changes.

### Save to Server

Documents can be saved back to the server without downloading and re-uploading files.

## Sample Scenario

The sample demonstrates a commercial loan review process containing:

- Customer Information
- Loan Request Details
- Financial Summary
- Relationship Manager Review
- Compliance Review
- Risk Assessment
- Final Approval

## Prerequisites

- Visual Studio 2022
- .NET Framework 4.7.2
- ASP.NET MVC 5
- Syncfusion EJ2 ASP.NET MVC packages

## Running the Sample

1. Restore NuGet packages.
2. Build the solution.
3. Run the application.
4. Open the document and review the workflow using different user roles.

## Document Storage

The sample loads and saves documents from:

```text
wwwroot/Documents/input.docx
```

## Resources

- **Product page:** [Syncfusion ASP.NET MVC DOCX Editor](https://www.syncfusion.com/docx-editor-sdk/asp-net-mvc-docx-editor)
- **Documentation:** [Syncfusion ASP.NET MVC DOCX Editor - Documentation](https://help.syncfusion.com/document-processing/word/word-processor/asp-net-mvc/getting-started)
- **Online demo:** [Syncfusion ASP.NET MVC DOCX Editor - Online demo](https://document.syncfusion.com/demos/docx-editor/asp-net-mvc/documenteditor/defaultfunctionalities#/tailwind3)

## Support and feedback

For any other queries, reach our [Syncfusion support team](https://support.syncfusion.com/?utm_source=github&utm_medium=listing&utm_campaign=github-github-documenteditor-examples) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=github&utm_medium=listing&utm_campaign=github-github-documenteditor-examples). 

Request new feature through [Syncfusion feedback portal](https://www.syncfusion.com/feedback?utm_source=github&utm_medium=listing&utm_campaign=github-github-documenteditor-examples). 

## License

This is a commercial product and requires a paid license for possession or use. Syncfusion's licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/license/studio/35.1.37/syncfusion_essential_studio_eula.pdf?utm_source=github&utm_medium=listing&utm_campaign=github-github-documenteditor-examples). You can purchase a license [here](https://www.syncfusion.com/sales/products?utm_source=github&utm_medium=listing&utm_campaign=github-github-documenteditor-examples) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=github&utm_medium=listing&utm_campaign=github-github-documenteditor-examples).