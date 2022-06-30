using AppiApp.Models;
using AppiApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppiApp.Servicio
{
    public class PersonaServicio
    {
        public bool GuardarUsuarip(PersonaVM persona)
        {
            bool respuesta = false;
            try
            {
                using (TareaErikEntities2 contexto = new TareaErikEntities2())
                {
                    Persona personaDB = new Persona()
                    {
                        Nombre = persona.Nombre,
                        APaterno = persona.APaterno,
                        AMaterno = persona.AMaterno,
                        Telefono = persona.Telefono,
                        Direcion = persona.Direcion,
                        IdEstado = persona.IdEstado,
                    };
                    contexto.Persona.Add(personaDB);
                    contexto.SaveChanges();
                }
                respuesta = true;
            }catch (Exception ex)
            {
                
            }
            return respuesta;
        }

        public List<PersonaVM> PersonasList()
        {
            List<PersonaVM> list = new List<PersonaVM>();
            PersonaVM persona;
            using (TareaErikEntities2 contexto = new TareaErikEntities2())
            {
                var p1 = contexto.Persona;
                foreach (var p in p1)
                {
                    persona = new PersonaVM
                    {
                        IdPersona = p.IdPersona,
                        Nombre = p.Nombre,
                        APaterno=p.APaterno,
                        AMaterno=p.AMaterno,
                        Telefono = p.Telefono,
                        Direcion=p.Direcion,
                        IdEstado =(int) p.IdEstado
                    };
                    list.Add(persona);
                }
            }
            return list;
        }
    }
}