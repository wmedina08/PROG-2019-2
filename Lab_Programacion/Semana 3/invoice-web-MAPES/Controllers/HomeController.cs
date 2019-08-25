using System;
using Microsoft.AspNetCore.Mvc;
using invoice_web_MAPES.models;

namespace invoice_web_MAPES.controllers
{

    public class HomeController:Controller{


        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }
        
        // POST: Home/Registrar
        [HttpPost]
        public IActionResult Registrar(invoice invoice){
            Console.WriteLine("Registrar");
            Random rmd = new Random();

            int numero= rmd.Next();
            
            int can = int.Parse(invoice.Cantidad);
            int pro = int.Parse(invoice.producto);

            int sub = can*pro;

            double to = sub*1.18;

            invoice.SubTotal= ""+sub;
            invoice.total =""+to;
            invoice.random = ""+numero;

            return View(invoice);
        }
    }

}