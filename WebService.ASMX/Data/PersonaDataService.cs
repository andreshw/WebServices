using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class PersonaDataService
    {
        private List<Persona> _personas;

        public Persona[] Personas
        {
            get
            {
                if (_personas == null)
                {
                    _personas = new List<Persona>();

                    _personas.Add(new Persona { Id = 1, Nombre = "Mary", Edad = 32 });
                    _personas.Add(new Persona { Id = 2, Nombre = "Andres", Edad = 32 }); 
                }
                return _personas.ToArray();
            }
        }

        public Persona[] ObtenerPersonas()
        {
            return this.Personas;
        }

        public Persona OntenerPersonaPorId(int id)
        {
            Persona[] personas = this.ObtenerPersonas();
            Persona persona = personas.FirstOrDefault(p => p.Id.Equals(id));
            return persona;
        }

        public void GuardarPersona(Persona persona)
        {
            Persona[] personas = this.ObtenerPersonas();
            this._personas.Add(persona);
        }
    }
}
