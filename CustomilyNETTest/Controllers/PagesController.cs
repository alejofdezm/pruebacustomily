using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web.UI;
using System.Web.Mvc;


namespace CustomilyNETTest.Controllers
{
    public class PagesController : ApiController
    {
        LogicaNegocio.Page manejoDePaginas = new LogicaNegocio.Page();
        // GET api/values
        public IEnumerable<CustomilyNETTest.Models.Page> Get()
        {

            return null;            
        }

        // GET api/values/5
        
        public IList< Models.Page> Get(decimal x, decimal y) 
        {
            
            return manejoDePaginas.ObtenerPaginPorCordenadas(x, y); 
        }

        // POST api/values
        public Models.Page Post([FromBody] string value)
        {

            return manejoDePaginas.agregarPagina(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
