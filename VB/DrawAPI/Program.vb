Imports DevExpress.Pdf
Imports System.Drawing

Namespace DrawAPI
    Friend Class Program
        Shared Sub Main(ByVal args() As String)
            Using documentProcessor As New PdfDocumentProcessor()
                documentProcessor.CreateEmptyDocument()
                Dim page As PdfPage = documentProcessor.AddNewPage(PdfPaperSize.A4)
                Draw(page)
                documentProcessor.SaveDocument("..\..\Result.pdf")
            End Using
        End Sub

        Private Shared Sub Draw(ByVal page As PdfPage)
            Using graphics As New PdfGraphics()
                Using image As New Bitmap("..\..\Northwind.png")
                    Dim width As Single = image.Width
                    Dim height As Single = image.Height
                    graphics.DrawImage(image, New RectangleF(100, 100, width / 2, height / 2))
                End Using
                Dim black As SolidBrush = CType(Brushes.Black, SolidBrush)
                Using font1 As New Font("Segoe UI", 32, FontStyle.Bold)
                    graphics.DrawString("Andrew Fuller", font1, black, 300, 90)
                End Using
                Using font2 As New Font("Segoe UI", 20)
                    graphics.DrawString("Vice President, Sales", font2, black, 300, 145)
                End Using
                Using font3 As New Font("Segoe UI", 14)
                    graphics.DrawString("(206) 555-9482", font3, black, 300, 200)
                    graphics.DrawString("andrew.f@example.com", font3, black, 300, 230)
                End Using
                graphics.FillRectangle(black, New RectangleF(305, 138, 285, 3))
                graphics.AddToPageForeground(page)
            End Using
        End Sub
    End Class
End Namespace
