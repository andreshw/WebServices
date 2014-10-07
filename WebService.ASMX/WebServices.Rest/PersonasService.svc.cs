using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Data;

namespace WebServices.Rest
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PersonasService
    {
        private PersonaDataService personasDataService;

        public PersonasService()
        {
            personasDataService = new PersonaDataService();
        }

        [OperationContract]
        [WebGet(UriTemplate = "/ObtenerPersonas", ResponseFormat = WebMessageFormat.Json)]
        public Persona[] ObtenerPersonas()
        {
            return personasDataService.ObtenerPersonas();
        }

        [WebGet(ResponseFormat=WebMessageFormat.Json, UriTemplate="/Personas/{id}")]
        public Persona ObtenerPersonaPorId(string id)
        {
            return personasDataService.OntenerPersonaPorId(Convert.ToInt32(id));
        }

        [OperationContract]
        [WebInvoke(Method="POST", UriTemplate="/Persona", ResponseFormat = WebMessageFormat.Json)]
        public Persona GuardarPersona(Persona persona)
        {
            personasDataService.GuardarPersona(persona);
            persona.Edad = 0;
            return persona;
        }
    }
}
