using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomilyNETTest.Context;
using System.Text.Json;
using Newtonsoft.Json;

namespace CustomilyNETTest.LogicaNegocio
{
       
    public class Page
    {
        dbContexttest db = new dbContexttest();

        public Models.Page agregarPagina(String value) {

            Models.Page _paginajson = JsonConvert.DeserializeObject<Models.Page>(value);



            db.Page.Add(_paginajson);
            db.SaveChanges();

            return _paginajson;
        }

        public List< Models.Page> ObtenerPaginPorCordenadas(decimal x, decimal y)
        {

            return db.Page.Include("Images").Include("Texts").Where(p => p.Images.Where(im => im.X >= x && im.Y >= y).Count() == p.Images.Count()).ToList();

        }

    }
}