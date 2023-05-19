Imports DevExpress.Drawing
Imports DevExpress.Pdf
Imports System.Drawing

Namespace DocumentCreationAPI

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Create an empty document.
                processor.CreateEmptyDocument("..\..\Result.pdf")
                ' Create and draw PDF graphics.
                Using graph As PdfGraphics = processor.CreateGraphics()
                    DrawGraphics(graph)
                    ' Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graph)
                End Using
            End Using
        End Sub

        Private Shared Sub DrawGraphics(ByVal graph As PdfGraphics)
            ' Draw text lines on the page. 
            Dim black As DXSolidBrush = CType(DXBrushes.Black, DXSolidBrush)
            Dim font1 As DXFont = New DXFont("Times New Roman", 32, DXFontStyle.Bold)
            graph.DrawString("PDF Document Processor", font1, black, 180, 150)

            Dim font2 As DXFont = New DXFont("Arial", 20)
            graph.DrawString("Display, Print and Export PDF Documents", font2, black, 168, 230)

            Dim font3 As DXFont = New DXFont("Arial", 10)
            graph.DrawString("The PDF Document Processor is a non-visual component " & "that provides the application programming interface of the PDF Viewer.", font3, black, 16, 300)
        End Sub
    End Class
End Namespace
