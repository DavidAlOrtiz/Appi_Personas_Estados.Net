using AppiApp.Models;
using AppiApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppiApp.Servicio
{
    public class Estados
    {
        public List<EstadoVM> EstadoList()
        {
            List<EstadoVM> list = new List<EstadoVM>();
            EstadoVM estado;
            using (TareaErikEntities2 contexto = new TareaErikEntities2())
            {
                var p1 = contexto.Estado;
                foreach (var p in p1)
                {
                    estado = new EstadoVM
                    {
                        IdEstado = p.IdEstado,
                        NombreEstado = p.NombreEstado,
                    };
                    list.Add(estado);
                }
            }
            return list;
        }
    }
}