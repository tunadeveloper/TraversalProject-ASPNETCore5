using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace TraversalProject.PresentationLayer.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Deneme1");
            workSheet.Cells[1, 1].Value = "Rota";
            workSheet.Cells[1, 2].Value = "Rehber";
            workSheet.Cells[1, 1].Value = "Kontenjan";

            workSheet.Cells[2, 1].Value = "Gürcistan Batum";
            workSheet.Cells[2, 2].Value = "Tunahan Cengiz";
            workSheet.Cells[2, 3].Value = "50";
            return View();
        }
    }
}
