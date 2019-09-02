using System;
using Microsoft.AspNetCore.Mvc;
using Invoice_web_2.Models;

namespace Invoice_web_2.Controllers
{

    public class HomeController : Controller
    {

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Console.WriteLine("Index");
            return View();
        }

       
        [HttpPost]
        public IActionResult calculo(Invoice invoice)
        {
            Console.WriteLine("calculo");

            Random random = new Random();
            int num = random.Next();
            invoice.Num = num;

            int subt = invoice.producto * invoice.cantidad; 
            invoice.SubTotal = subt;

            double total = Math.Round(subt * 1.18, 2);
            invoice.Total = total;
            _context.Add(invoice);
            _context.SaveChanges();
            return View(invoice);
        }
    }

}