using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class PersonaDataService
    {
        public Persona[] ObtenerPersonas()
        {
            Persona[] personas = new Persona[2];

            personas[0] = new Persona { Id = 1, Nombre = "Mary", Edad = 32 };
            personas[1] = new Persona { Id = 2, Nombre = "Andres", Edad = 32 };

            return personas;
        }

        public Persona OntenerPersonaPorId(int id)
        {
            Persona[] personas = this.ObtenerPersonas();
            Persona persona = personas.FirstOrDefault(p => p.Id.Equals(id));
            return persona;
        }
    }
}
