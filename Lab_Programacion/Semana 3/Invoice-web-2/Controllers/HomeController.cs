using System;
using Microsoft.AspNetCore.Mvc;
using Invoice_web_2.Models;

namespace Invoice_web_2.Controllers
{

    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            Console.WriteLine("Index");
            return View();
        }

        // POST: Home/RegistrarFan
        [HttpPost]
        public IActionResult calculo(Invoice invoice)
        {
            Console.WriteLine("calculo");

            Random random = new Random();
            int num = random.Next();
            invoice.Num = num;

            int subt = invoice.producto * invoice.cantidad; ;
            invoice.SubTotal = subt;

            double total = subt * 1.18;
            invoice.Total = total;

            return View(invoice);
        }
    }

}