<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595553/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T244516)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/DocumentCreationAPI/Program.cs) (VB: [Program.vb](./VB/DocumentCreationAPI/Program.vb))
<!-- default file list end -->
# How to generate a document layout from scratch


This example shows the PDF Document Creation API that is used to programmatically generate a document layout.<br><br>The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br>


<h3>Description</h3>

The generated document also contains bookmarks and links to URI and a&nbsp;document page. <br /><br />To generate a document using the PDF Creation API:<br />-&nbsp; Create an empty document with no pages&nbsp;by&nbsp;calling one of the&nbsp; <strong>PdfDocumentProcessor.CreateEmptyDocument</strong> overload methods (e.g., using a file path and&nbsp; PDF creation options represented by the <strong>PdfCreationOptions</strong> object).&nbsp;<br />-&nbsp;Create PDF&nbsp;graphics&nbsp;represented by an instance of the <strong>PdfGraphics</strong> class calling the&nbsp;<strong>PdfDocumentProcessor.CreateGraphics</strong> method. To access<strong>&nbsp;PdfGraphics </strong>you need to reference the <strong>DevExpress.Pdf.Drawing</strong> assembly.&nbsp;<br />- Draw the graphic content&nbsp;(e.g. an image, a string,&nbsp; lines, polygons) by calling the corresponding <strong>Draw</strong> method.&nbsp;<br />- Add a link to the PDF page and to a URI using the <strong>PdfGraphics.AddLinkToPage</strong> and<strong> PdfGraphics.AddLinkToUri</strong> methods.<br />- Render a page with created graphics by&nbsp;calling the <strong>PdfDocumentProcessor.RenderNewPage</strong> method.<br /><br />To generate a bookmark in the document:<br />- Create a<strong> PdfBookmark</strong> object;<br />- Specify the bookmark title and destination using the <strong>PdfBookmark.Title</strong> and<strong> PdfBookmark.Destination</strong> properties. To create a destination, call the <strong>PdfDocumentProcessor.CreateDestination</strong> method.<br />- Add the bookmark to the <strong>PdfBookmark</strong> collection,&nbsp;which is accessed from the <strong>PdfDocument.Bookmarks</strong> property.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-generate-document-layout&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-generate-document-layout&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
