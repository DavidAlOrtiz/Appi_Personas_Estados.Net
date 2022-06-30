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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [AllowAnonymous]
    [RoutePrefix("app/Municipios")]
    public class MunicipioController : ApiController
    {
        MunicipioService municipioService = new MunicipioService();
        [HttpGet]
        [Route("get")]
        public List<MunicipiosVm> Index()
        {
            return municipioService.EstadoList();
        }
    }
}
