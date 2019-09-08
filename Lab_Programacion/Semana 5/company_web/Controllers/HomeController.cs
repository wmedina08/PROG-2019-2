using System;
using Microsoft.AspNetCore.Mvc;
using company_web.Models;

namespace company_web.Controllers
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
        public IActionResult calculo(Producto product)
        {
            Console.WriteLine("calculo");
            
            Double precioT;
            Double porcentCat=0;
            Double porcentProd=0;
            if(product.categoria=="Camioneta"){
                porcentCat=0.05;
            }else if(product.categoria=="Automovil"){
                porcentCat=0.03;
            }
            if(product.Production=="Nacional"){
                porcentProd=0.1;
            }else if(product.Production=="Extranjero"){
                porcentProd=0.3;
            }
            precioT=precioImp(porcentCat,porcentProd,product);
            product.PriceImp = precioT;
             _context.Add(product);
            _context.SaveChanges();
            return View(product);
        }
        public double precioImp(double cat,double produccion,Producto product){
            double precio;
            precio=product.Price*(1+cat)*(1+produccion);
            return precio;
        }
    }

}