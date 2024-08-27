Imports DevExpress.Drawing
Imports DevExpress.Pdf
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO

Namespace DocumentCreationAPI

    Friend Class Program

        Shared Sub Main(ByVal args As String())

            Dim docPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Result.pdf")

            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Create an empty document.
                processor.CreateEmptyDocument(docPath)
                ' Create and draw PDF graphics.
                Using graph As PdfGraphics = processor.CreateGraphics()
                    DrawGraphics(graph)
                    ' Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graph)
                End Using
            End Using
            ' Generate a watermark.
            AddWatermark("Not for sale", docPath, docPath)
            Process.Start(docPath)
        End Sub

        ' Draw graphics inside a PDF document.
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

        ' Add a watermark with custom text.
        Private Shared Sub AddWatermark(Text As String, fileName As String, resultFileName As String)
            Using documentProcessor As New PdfDocumentProcessor()
                Dim fontName As String = "Arial Black"
                Dim fontSize As Integer = 12
                Dim stringFormat As PdfStringFormat = PdfStringFormat.GenericTypographic
                stringFormat.Alignment = PdfStringAlignment.Center
                stringFormat.LineAlignment = PdfStringAlignment.Center
                documentProcessor.LoadDocument(fileName)
                Using brush As New SolidBrush(Color.FromArgb(63, Color.Black))
                    Using font As New Font(fontName, fontSize)
                        For Each page In documentProcessor.Document.Pages
                            Dim watermarkSize = page.CropBox.Width * 0.75
                            Using graphics As PdfGraphics = documentProcessor.CreateGraphics()
                                Dim stringSize As SizeF = graphics.MeasureString(Text, font)
                                Dim scale As Single = CSng(watermarkSize) / stringSize.Width
                                graphics.TranslateTransform(CSng(page.CropBox.Width * 0.5), CSng(page.CropBox.Height * 0.5))
                                graphics.RotateTransform(-45.0)
                                graphics.TranslateTransform(CSng(-stringSize.Width * scale * 0.5), CSng(-stringSize.Height * scale * 0.5))
                                Using actualFont As Font = New Font(fontName, fontSize * scale)
                                    Dim rect As RectangleF = New RectangleF(0, 0, stringSize.Width * scale, stringSize.Height * scale)
                                    graphics.DrawString(Text, actualFont, brush, rect, stringFormat)
                                End Using
                                graphics.AddToPageForeground(page, 72, 72)
                            End Using
                        Next
                    End Using
                End Using
                documentProcessor.SaveDocument(resultFileName)
            End Using
        End Sub
    End Class
End Namespace
