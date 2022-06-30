using AppiApp.Models;
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
    [RoutePrefix("app/usuario")]
    public class UsuarioController : ApiController
    {
        Estados esta = new Estados();
        PersonaServicio servicio = new PersonaServicio();

        [HttpGet]
        [Route("getEstados")]
        public List<EstadoVM> Index()
        {
            return esta.EstadoList();
        }

        [HttpGet]
        [Route("getUsurios")]
        public List<PersonaVM> getUsuarios()
        {

            return servicio.PersonasList();
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult CreatePersona(PersonaVM persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            servicio.GuardarUsuarip(persona);
            return Ok(persona);

        }
    }
}
