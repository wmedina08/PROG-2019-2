using System;
using System.ComponentModel.DataAnnotations;

namespace Invoice_web_2.Models
{
    public class Invoice{

        public String cliente {get; set;}
        public int producto {get; set;}
        public int cantidad {get; set;}

        public double SubTotal {get; set;}

        public double Total {get; set;}

        public int Num {get; set;}

        [DataType(DataType.Date)]
        public DateTime fecha {get; set;}

    }
}
