using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Data;

namespace WebServices.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonasService" in code, svc and config file together.
    public class PersonasService : IPersonasService
    {
        private PersonaDataService personaDataService;

        public PersonasService()
        {
            personaDataService = new PersonaDataService();
        }

        public Persona[] ObtenerPersonas()
        {
            return personaDataService.ObtenerPersonas();
        }

        public Persona ObtenerPersonaPorId(int id)
        {
            return personaDataService.OntenerPersonaPorId(id);
        }


        public void GuardarPersona(Persona persona)
        {
            this.personaDataService.GuardarPersona(persona);
        }
    }
}
