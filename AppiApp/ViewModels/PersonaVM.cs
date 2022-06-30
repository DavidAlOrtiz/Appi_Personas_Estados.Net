using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppiApp.ViewModels
{
    public class PersonaVM
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Telefono { get; set; }
        public string Direcion { get; set; }
        public int IdEstado { get; set; }
        
    }
}