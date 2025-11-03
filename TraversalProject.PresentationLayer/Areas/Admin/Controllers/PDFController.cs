using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class PDFController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PDFReports/StaticPDFReport.pdf");

            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, stream);

                document.Open();
                Paragraph paragraph = new Paragraph("Traversal Rezervasyon Sistemine Hoşgeldiniz");
                document.Add(paragraph);
                document.Close();
            }

            return File("/PDFReports/StaticPDFReport.pdf", "application/pdf", "StaticPDFReport.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PDFReports/StaticCustomerReport.pdf");
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, stream);

                document.Open();

                Paragraph title = new Paragraph("Traversal Müşteri Raporu");
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                document.Add(new Paragraph("\nRapor Tarihi: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm")));
                document.Add(new Paragraph("----------------------------------------------------"));
                document.Add(new Paragraph("\n"));

                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.AddCell("ID");
                table.AddCell("Ad");
                table.AddCell("Soyad");
                table.AddCell("Ülke");
                table.AddCell("Şehir");

                table.AddCell("1");
                table.AddCell("Ahmet");
                table.AddCell("Yılmaz");
                table.AddCell("Türkiye");
                table.AddCell("İstanbul");

                table.AddCell("2");
                table.AddCell("John");
                table.AddCell("Doe");
                table.AddCell("USA");
                table.AddCell("New York");

                table.AddCell("3");
                table.AddCell("Elif");
                table.AddCell("Demir");
                table.AddCell("Almanya");
                table.AddCell("Berlin");

                document.Add(table);

                document.Close();
            }
            return File("/PDFReports/StaticCustomerReport.pdf", "application/pdf", "StaticCustomerReport.pdf");
        }


    }
}
