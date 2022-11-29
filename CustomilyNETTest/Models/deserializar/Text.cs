using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models.deserializar
{
  
    public class Text
    {
        public int Id { get; set; }
        public string Content { get; set; }   
        public string X { get; set; }        
        public string Y { get; set; }
    }
}