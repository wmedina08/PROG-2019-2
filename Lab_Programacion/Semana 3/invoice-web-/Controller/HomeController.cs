using System;
using Microsoft.AspNetCore.Mvc;
using invoice_web_.models;

namespace invoice_web_.controller
{

    public class HomeController:Controller{


        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }
        
        // POST: Home/RegistrarFan
        [HttpPost]
        public IActionResult calculo (Invoice invoice){
            Console.WriteLine("calculo");
            Random random= new Random();
            int prod=invoice.producto;
            int cant=invoice.cantidad;
            int subt=prod*cant;
            double total=subt*1.18;
            invoice.SubTotal=subt;
            invoice.total=total;
            invoice.random=""+random;
            return View(invoice);
        }
    }

}