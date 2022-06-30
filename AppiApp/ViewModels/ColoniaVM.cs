using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppiApp.ViewModels
{
    public class ColoniaVM
    {
        public int IdColonia { get; set; }
        public string Nombre { get; set; }

        public virtual MunicipiosVm MunicipiosVmV { get; set; }
    }
}