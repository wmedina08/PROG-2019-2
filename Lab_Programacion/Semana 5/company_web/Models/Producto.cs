using System;
using System.ComponentModel.DataAnnotations;

namespace company_web.models
{
    public class producto{
        public int ID { get; set; }
        public String product {get;set;}
        public double categoria {get;set;}
        public double tProduccion {get;set;}
        public double precio {get;set;}
        public double precioImp {get;set;}

    }
}