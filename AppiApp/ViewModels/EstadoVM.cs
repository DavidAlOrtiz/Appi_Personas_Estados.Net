using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppiApp.ViewModels;

namespace AppiApp.ViewModels
{
    public class EstadoVM
    {
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public virtual ICollection<MunicipiosVm> VMs { get; set; }
    }
}