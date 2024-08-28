<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595553/24.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T244516)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->

# PDF Document API - Generate a Document Layout from Scratch

This example shows the PDF Document Creation API that is used to programmatically generate a document layout.

- The custom `DrawGraphics` method draws content inside an empty PDF document.
- The custom `AddWatermark` method generates a watermark with custom text and adds it to the created PDF document.

When you launch the app, the file is saved to your Documents folder (`%userprofile%/Documents`). 

The [Result.pdf](Result.pdf) file is an example of a generated PDF document:

![](pdf-processor-result.png)

The Universal Subscription or Office File API Subscription is required to use this example in production code. Please refer to the [DevExpress Subscriptions](https://www.devexpress.com/Subscriptions/) page for pricing information.

# Files to Review

* [Program.cs](./CS/DocumentCreationAPI/Program.cs) (VB: [Program.vb](./VB/DocumentCreationAPI/Program.vb))
* [Result.pdf](Result.pdf)
<!-- default file list end -->

# Documentation

- [How to: Generate a PDF Document Layout from Scratch](https://docs.devexpress.com/OfficeFileAPI/114824/pdf-document-api/examples/pdf-graphics-and-additional-content/how-to-generate-a-document-layout-from-scratch)
- [Document Generation](https://docs.devexpress.com/OfficeFileAPI/118794/pdf-document-api/document-generation)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-generate-document-layout&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-generate-document-layout&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
