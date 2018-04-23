using DevExpress.Pdf;
using System.Drawing;

namespace DrawAPI {
    class Program {
        static void Main(string[] args) {
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.CreateEmptyDocument();
                PdfPage page = documentProcessor.AddNewPage(PdfPaperSize.A4);
                Draw(page);
                documentProcessor.SaveDocument("..\\..\\Result.pdf");
            }
        }

        static void Draw(PdfPage page) {
            using (PdfGraphics graphics = new PdfGraphics()) {
                using (Bitmap image = new Bitmap("..\\..\\Northwind.png")) {
                    float width = image.Width;
                    float height = image.Height;
                    graphics.DrawImage(image, new RectangleF(100, 100, width / 2, height / 2));
                }
                SolidBrush black = (SolidBrush)Brushes.Black;
                using (Font font1 = new Font("Segoe UI", 32, FontStyle.Bold)) {
                    graphics.DrawString("Andrew Fuller", font1, black, 300, 90);
                }
                using (Font font2 = new Font("Segoe UI", 20)) {
                    graphics.DrawString("Vice President, Sales", font2, black, 300, 145);
                }
                using (Font font3 = new Font("Segoe UI", 14)) {
                    graphics.DrawString("(206) 555-9482", font3, black, 300, 200);
                    graphics.DrawString("andrew.f@example.com", font3, black, 300, 230);
                }
                graphics.FillRectangle(black, new RectangleF(305, 138, 285, 3));
                graphics.AddToPageForeground(page);
            }
        }
    }
}
