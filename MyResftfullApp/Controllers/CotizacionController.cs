using MyRestfullApp.Core.Currency;
using MyRestfullApp.Core.Excpetions;
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
        public IHttpActionResult Get(string moneda)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CurrencyStrategyManager manager = new CurrencyStrategyManager();
                    StrategyType type = manager.GetStrategyType(moneda);
                    ICurrencyStrategy strategy = manager.GetStrategy(type);

                    Price cotizacion = strategy.GetPrice();

                    return Json(cotizacion);
                }
            }
            catch (ParameterException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }

            return BadRequest();
        }
    }
}
