using System;
using Microsoft.AspNetCore.Mvc;
using company_web.models;

namespace company_web.controllers
{
    public class HomeController:Controller{

        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();

        }
        public IActionResult calcular(Producto product){
            Console.WriteLine("calcular");
            
            double precio = double.Parse(product.price);
            double precioT;

            if((product.tProduccion)=="0.30"){
                if((product.categoria)=="0.05"){
                    precioT=precio*1.35;
                }else{
                    precioT=precio*1.33;
                }
            }else{
                if((product.categoria)=="0.05"){
                    precioT=precio*1.15;
                }else{
                    precioT=precio*1.13;
                }
            }

            product.precioImp = precioT;
            return View(product);
        }      
    }
}