using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppiApp.ViewModels
{
    public class MunicipiosVm
    {
        public int IdMunicipio { get; set; }
        public string Nombre { get; set; }
        public virtual EstadoVM estadoM { get; set; }
        public virtual ICollection<ColoniaVM> coloniavm { get; set; }
    }
}