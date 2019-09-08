using System;
using System.ComponentModel.DataAnnotations;

namespace company_web.Models
{
    public class Producto{

        public int ID { get; set; }
        public String producto {get; set;}
        public String categoria {get; set;} 
        public String Production {get; set;} 

        public Double Price {get; set;}

        public Double PriceImp {get; set;}
    }
}
