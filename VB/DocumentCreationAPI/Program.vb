Imports DevExpress.Pdf
Imports System
Imports System.Drawing

Namespace DocumentCreationAPI
    Friend Class Program

        Shared Sub Main(ByVal args() As String)
'            #Region "#DocumentCreation"
            Using processor As New PdfDocumentProcessor()
                ' Create an empty document using PDF creation options.
                processor.CreateEmptyDocument("..\..\Result.pdf", New PdfCreationOptions() With {.Compatibility = PdfCompatibility.PdfA2b, .DisableEmbeddingAllFonts = False})

                ' Create and draw PDF graphics.
                Using graph As PdfGraphics = processor.CreateGraphics()
                    DrawGraphics(graph)

                    ' Create a link to a page specifying link area, the page number and X, Y destinations.
                    graph.AddLinkToPage(New RectangleF(180, 160, 480, 30), 1, 168, 230)

                    ' Create a link to URI specifying link area and URI.
                    graph.AddLinkToUri(New RectangleF(110, 350, 180, 15), New Uri("https://www.devexpress.com"))

                    ' Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graph)
                End Using

                ' Add three bookmarks to the PDF document.
                AddBookmarks(processor)
            End Using
'            #End Region ' #DocumentCreation
        End Sub
        #Region "#Graphics"
        Private Shared Sub DrawGraphics(ByVal graph As PdfGraphics)
            ' Draw an image on the page. 
            Using image As New Bitmap("..\..\DevExpress.png")
                Dim width As Single = image.Width
                Dim height As Single = image.Height
                graph.DrawImage(image, New RectangleF(20, 40, width / 2, height / 2))
            End Using

            ' Draw text lines on the page. 
            Dim black As SolidBrush = CType(Brushes.Black, SolidBrush)
            Using font1 As New Font("Times New Roman", 32, FontStyle.Bold)
                graph.DrawString("PDF Document Processor", font1, black, 180, 150)
            End Using
            Using font2 As New Font("Arial", 20)
                graph.DrawString("Display, Print and Export PDF Documents", font2, black, 168, 230)
            End Using
            Using font3 As New Font("Arial", 10)
                graph.DrawString("The PDF Document Processor is a non-visual component " & "that provides the application programming interface of the PDF Viewer.", font3, black, 16, 300)
                graph.DrawString("Learn more at", font3, black, 20, 350)
                Dim blue As SolidBrush = CType(Brushes.Blue, SolidBrush)
                graph.DrawString("https://www.devexpress.com", font3, blue, 110, 350)
            End Using
        End Sub
        #End Region ' #Graphics

        #Region "#Bookmarks"
        Private Shared Sub AddBookmarks(ByVal processor As PdfDocumentProcessor)
            ' Create bookmarks and add them to the PDF document.
            Dim destination1 As PdfDestination = processor.CreateDestination(1, 180, 150)
            Dim destination2 As PdfDestination = processor.CreateDestination(1, 168, 230)
            Dim destination3 As PdfDestination = processor.CreateDestination(1, 20, 350)
            processor.Document.Bookmarks.Add(New PdfBookmark() With {.Title = "PDF Document Processor", .Destination = destination1})
            processor.Document.Bookmarks.Add(New PdfBookmark() With {.Title = "Display, Print and Export PDF Documents", .Destination = destination2})
            processor.Document.Bookmarks.Add(New PdfBookmark() With {.Title = "Learn More", .Destination = destination3})
        End Sub
        #End Region ' #Bookmarks
    End Class
End Namespace