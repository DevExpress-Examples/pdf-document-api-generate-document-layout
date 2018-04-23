using DevExpress.Pdf;
using System;
using System.Drawing;

namespace DocumentCreationAPI {
    class Program {

        static void Main(string[] args) {
            #region #DocumentCreation
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                // Create an empty document using PDF creation options.
                processor.CreateEmptyDocument("..\\..\\Result.pdf", new PdfCreationOptions() {
                    Compatibility = PdfCompatibility.PdfA2b,
                    DisableEmbeddingAllFonts = false
                });

                // Create and draw PDF graphics.
                using (PdfGraphics graph = processor.CreateGraphics()) {
                    DrawGraphics(graph);

                    // Create a link to a page specifying link area, the page number and X, Y destinations.
                    graph.AddLinkToPage(new RectangleF(180, 160, 480, 30), 1, 168, 230);

                    // Create a link to URI specifying link area and URI.
                    graph.AddLinkToUri(new RectangleF(110, 350, 180, 15), new Uri("https://www.devexpress.com"));

                    // Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graph);
                }

                // Add three bookmarks to the PDF document.
                AddBookmarks(processor);
            }
            #endregion #DocumentCreation
        }
        #region #Graphics
        static void DrawGraphics(PdfGraphics graph) {
            // Draw an image on the page. 
            using (Bitmap image = new Bitmap("..\\..\\DevExpress.png")) {
                float width = image.Width;
                float height = image.Height;
                graph.DrawImage(image, new RectangleF(20, 40, width / 2, height / 2));
            }

            // Draw text lines on the page. 
            SolidBrush black = (SolidBrush)Brushes.Black;
            using (Font font1 = new Font("Times New Roman", 32, FontStyle.Bold)) {
                graph.DrawString("PDF Document Processor", font1, black, 180, 150);
            }
            using (Font font2 = new Font("Arial", 20)) {
                graph.DrawString("Display, Print and Export PDF Documents", font2, black, 168, 230);
            }
            using (Font font3 = new Font("Arial", 10)) {
                graph.DrawString("The PDF Document Processor is a non-visual component " +
                                  "that provides the application programming interface of the PDF Viewer.", font3, black, 16, 300);
                graph.DrawString("Learn more at", font3, black, 20, 350);
                SolidBrush blue = (SolidBrush)Brushes.Blue;
                graph.DrawString("https://www.devexpress.com", font3, blue, 110, 350);
            }
        }
        #endregion #Graphics

        #region #Bookmarks
        static void AddBookmarks(PdfDocumentProcessor processor) {
            // Create bookmarks and add them to the PDF document.
            PdfDestination destination1 = processor.CreateDestination(1, 180, 150);
            PdfDestination destination2 = processor.CreateDestination(1, 168, 230);
            PdfDestination destination3 = processor.CreateDestination(1, 20, 350);
            processor.Document.Bookmarks.Add(new PdfBookmark() { Title = "PDF Document Processor", Destination = destination1 });
            processor.Document.Bookmarks.Add(new PdfBookmark() { Title = "Display, Print and Export PDF Documents", Destination = destination2 });
            processor.Document.Bookmarks.Add(new PdfBookmark() { Title = "Learn More", Destination = destination3 });
        }
        #endregion #Bookmarks
    }
}