using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models.deserializar
{   
 
    public class Image
    {
        public int Id { get; set; }

        
        public string URL { get; set; }

        
        public string X { get; set; }

        
        public string Y { get; set; }
    }
}