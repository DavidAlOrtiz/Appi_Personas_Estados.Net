using AppiApp.Models;
using AppiApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppiApp.Servicio
{
    public class MunicipioService
    {
        public List<MunicipiosVm> EstadoList()
        {
            List<MunicipiosVm> list = new List<MunicipiosVm>();
            MunicipiosVm municipio;
            using (TareaErikEntities2 contexto = new TareaErikEntities2())
            {
                var p1 = contexto.Municipios;
                foreach (var p in p1)
                {
                    municipio = new MunicipiosVm
                    {
                        IdMunicipio = p.IdMunicipio,
                        Nombre = p.Nombre,
                        estadoM = new EstadoVM()
                        {
                            IdEstado =(int) p.IdEstado,
                            NombreEstado = p.Estado.NombreEstado
                        }
                    };
                    list.Add(municipio);
                }
            }
            return list;
        }
    }
}