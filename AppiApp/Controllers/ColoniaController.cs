using AppiApp.Servicio;
using AppiApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppiApp.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    [AllowAnonymous]
    [RoutePrefix("app/colonia")]
    public class ColoniaController : ApiController
    {
        ColoniaServicio servicioColonia = new ColoniaServicio();
        [HttpGet]
        [Route("get")]
        public List<ColoniaVM> Index()
        {
            return servicioColonia.ColoniaList();
        }
    }
}
