using System;
using System.ComponentModel.DataAnnotations;

namespace invoice_web_MAPES.models
{

    public class invoice{

        public String Cliente {get; set;}
        
        public String producto {get; set;}

        [DataType(DataType.Date)]
        public DateTime Birth {get; set;}

        public String Cantidad {get; set;}

        public String SubTotal {get; set;}

        public String total {get; set;}

        public String random {get; set;}
        
    }

}