using DevExpress.Drawing;
using DevExpress.Pdf;
using System;
using System.Diagnostics;
using System.Drawing;

namespace DocumentCreationAPI
{
    class Program {

        static void Main(string[] args) {

            string docPath = "..\\..\\Result.pdf";

            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                // Create an empty document.
                processor.CreateEmptyDocument(docPath);
                // Create and draw PDF graphics.
                using (PdfGraphics graph = processor.CreateGraphics()) {
                    DrawGraphics(graph);
                    // Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graph);
                }
            }
            // Generate a watermark.
            AddWatermark("Not for sale",docPath,docPath);
            Process.Start(docPath);
        }

        // Draw graphics inside a PDF document.
        static void DrawGraphics(PdfGraphics graph) {
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

        // Add a watermark with custom text.
        static void AddWatermark(string text,string fileName,string resultFileName) {
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                string fontName = "Arial Black";
                int fontSize = 12;
                PdfStringFormat stringFormat = PdfStringFormat.GenericTypographic;
                stringFormat.Alignment = PdfStringAlignment.Center;
                stringFormat.LineAlignment = PdfStringAlignment.Center;
                documentProcessor.LoadDocument(fileName);
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(63,Color.Black))) {
                    using (Font font = new Font(fontName,fontSize)) {
                        foreach (var page in documentProcessor.Document.Pages) {
                            var watermarkSize = page.CropBox.Width * 0.75;
                            using (PdfGraphics graphics = documentProcessor.CreateGraphics()) {
                                SizeF stringSize = graphics.MeasureString(text,font);
                                float scale = (float)(watermarkSize / (double)stringSize.Width);
                                graphics.TranslateTransform((float)(page.CropBox.Width * 0.5),(float)(page.CropBox.Height * 0.5));
                                graphics.RotateTransform((float)-45.0);
                                graphics.TranslateTransform((float)(-stringSize.Width * scale * 0.5),(float)(-stringSize.Height * scale * 0.5));
                                using (Font actualFont = new Font(fontName,fontSize * scale)) {
                                    RectangleF rect = new RectangleF(0,0,stringSize.Width * scale,stringSize.Height * scale);
                                    graphics.DrawString(text,actualFont,brush,rect,stringFormat);
                                }
                                graphics.AddToPageForeground(page,72,72);
                            }
                        }
                    }
                }
                documentProcessor.SaveDocument(resultFileName);
            }
        }

    }
}