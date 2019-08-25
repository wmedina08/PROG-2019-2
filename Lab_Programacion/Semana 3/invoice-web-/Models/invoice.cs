using System;
using System.ComponentModel.DataAnnotations;

namespace invoice_web_.models
{
    public class Invoice{

        public String cliente {get; set;}
        public int producto {get; set;}
        public int cantidad {get; set;}


        [DataType(DataType.Date)]
        public DateTime fecha {get; set;}

    }
}
