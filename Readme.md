<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595553/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T244516)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/DrawAPI/Program.cs) (VB: [Program.vb](./VB/DrawAPI/Program.vb))
<!-- default file list end -->
# How to generate a document layout from scratch


This example shows the PDF Document Creation API that is used to programmatically generate a document layout.<br><br>The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br>


<h3>Description</h3>

This example shows how to draw a business card in the document foreground. <br /><br />To do this: <br />&nbsp;- Create&nbsp;a PDF document processor and add an empty document to it&nbsp;by calling the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_CreateEmptyDocumenttopic">PdfDocumentProcessor.CreateEmptyDocument&nbsp;</a>method.<br />&nbsp;- Add a new page to the PDF document. For this, call the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_AddNewPagetopic">PdfDocumentProcessor.AddNewPage</a> method.&nbsp;<br />&nbsp;- To access PDF graphics, create a <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressPdfPdfGraphicstopic">PdfGraphics</a> object. You need to reference the DevExpress.Pdf.Drawing assembly.&nbsp;<br />&nbsp;- To draw an image on the PDF page, call the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfGraphics_DrawImagetopic">PdfGraphics.DrawImage</a> method for the specified image at the specified location with the specified size.<br />&nbsp;- To draw text, call the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfGraphics_DrawStringtopic">PdfGraphics.DrawString</a> method at the specified location with the specified <strong>Brush</strong> and<strong> Font</strong> objects.<br />&nbsp;- To&nbsp;draw&nbsp;graphics&nbsp;as&nbsp;foreground&nbsp;of a page content,&nbsp;call the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfGraphics_AddToPageForegroundtopic">PdfGraphics.AddToPageForeground&nbsp;</a> method with a page parameter.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-generate-document-layout&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-generate-document-layout&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
