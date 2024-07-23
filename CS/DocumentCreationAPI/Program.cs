using DevExpress.Drawing;
using DevExpress.Pdf;
using System;
using System.Drawing;

namespace DocumentCreationAPI
{
    class Program
    {

        static void Main(string[] args)
        {

            using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
            {

                // Create an empty document.
                processor.CreateEmptyDocument("..\\..\\Result.pdf");

                // Create and draw PDF graphics.
                using (PdfGraphics graph = processor.CreateGraphics())
                {
                    DrawGraphics(graph);

                    // Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graph);
                }
            }
        }

        static void DrawGraphics(PdfGraphics graph)
        {
            // Draw text lines on the page. 
            DXSolidBrush black = (DXSolidBrush)DXBrushes.Black;
            DXFont font1 = new DXFont("Times New Roman", 32, DXFontStyle.Bold);
            graph.DrawString("PDF Document Processor", font1, black, 180, 150);

            DXFont font2 = new DXFont("Arial", 20);
            graph.DrawString("Display, Print and Export PDF Documents", font2, black, 168, 230);

            DXFont font3 = new DXFont("Arial", 10);
            graph.DrawString("The PDF Document Processor is a non-visual component " +
                              "that provides the application programming interface of the PDF Viewer.", font3, black, 16, 300);
        }
    }
}