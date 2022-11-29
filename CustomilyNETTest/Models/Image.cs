using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models
{   
 
    public class Image
    {
        public int Id { get; set; }

        
        public string URL { get; set; }

        
        public decimal X { get; set; }

        
        public decimal Y { get; set; }
    }
}