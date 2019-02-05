using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyResftfullApp.Controllers
{
    public class CotizacionController : ApiController
    {
        // GET: Cotizacion/DOLAR
        [Route("Cotizacion/{moneda}")]
        public string Get(string moneda)
        {
            if (ModelState.IsValid)
            {
                StrategyType type = StrategyType.Parse(moneda);
                // Do something with the product (not shown).

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}
