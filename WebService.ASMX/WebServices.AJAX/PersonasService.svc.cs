using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Data;

namespace WebServices.AJAX
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PersonasService
    {
        [OperationContract]
        //[WebGet(ResponseFormat=WebMessageFormat.Xml)]
        [WebGet(ResponseFormat = WebMessageFormat.Xml)]
        public Persona[] ObtenerPersonas()
        {
            PersonaDataService personaDataService = new PersonaDataService();
            return personaDataService.ObtenerPersonas();
        }

        [OperationContract]
        [WebGet]
        public Persona ObtenerPersonaPorId(int id)
        {
            PersonaDataService personaDataService = new PersonaDataService();
            return personaDataService.OntenerPersonaPorId(id);
        }

        [OperationContract]
        [WebInvoke]
        public void GuardarPersona(Persona persona)
        {
            PersonaDataService personaDataService = new PersonaDataService();
            personaDataService.GuardarPersona(persona);
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
