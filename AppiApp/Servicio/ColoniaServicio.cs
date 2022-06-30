using AppiApp.Models;
using AppiApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppiApp.Servicio
{
    public class ColoniaServicio
    {
        public List<ColoniaVM> ColoniaList()
        {
            List<ColoniaVM> list = new List<ColoniaVM>();
            ColoniaVM colonia;
            using (TareaErikEntities2 contexto = new TareaErikEntities2())
            {
                var p1 = contexto.Colonia;
                foreach (var p in p1)
                {
                    colonia = new ColoniaVM
                    {
                        IdColonia = p.IdColonia,
                        Nombre = p.nombre,
                        MunicipiosVmV = new MunicipiosVm()
                        {
                            IdMunicipio = (int)p.idMunicipio,
                            Nombre = p.Municipios.Nombre
                        } 
                    };
                    list.Add(colonia);
                }
            }
            return list;
        }
    }
}