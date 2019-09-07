using System;
using Microsoft.AspNetCore.Mvc;
using company_web.models;

namespace company_web.controllers
{
    public class HomeController:Controller{

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();

        }
        public IActionResult calcular(producto product){
            Console.WriteLine("calcular");
            double impTprodu=product.tProduccion*product.precio;
            double impProd=impTprodu*product.categoria;
            product.precioImp=impProd;
            return View(product);
        }      
    }
}