using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models
{
    
    public class Page
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Image> Images { get; set; }
        public List<Text> Texts { get; set; }
    }
}