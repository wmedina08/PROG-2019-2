using System;
using System.ComponentModel.DataAnnotations;

namespace invoice_web_.models
{
    public class Invoice{

        public String cliente {get; set;}
        public int producto {get; set;}
        public int cantidad {get; set;}

        public double SubTotal {get; set;}

        public double total {get; set;}

        public String random {get; set;}

        [DataType(DataType.Date)]
        public DateTime fecha {get; set;}

    }
}
