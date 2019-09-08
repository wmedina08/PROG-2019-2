using System;
using Microsoft.AspNetCore.Mvc;
using company_web_2.models;

namespace company_web_2.controllers
{
    public class HomeController:Controller{

        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();

        }
       
        public IActionResult calcular(Producto product){
            Console.WriteLine("calcular");
            
            Double precioT;

            if((product.tProduccion)=="0.30"){
                if((product.categoria)=="0.05"){
                    precioT=product.Price*1.35;
                }else{
                    precioT=product.Price*1.33;
                }
            }else{
                if((product.categoria)=="0.05"){
                    precioT=product.Price*1.15;
                }else{
                    precioT=product.Price*1.13;
                }
            }

            product.precioImp = precioT;
            return View(product);
        }      
    }
}