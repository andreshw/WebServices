using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Data;

namespace WebService.ASMX
{
    /// <summary>
    /// Summary description for PersonasService
    /// </summary>
    [WebService(Namespace = "http://andreshw.servicios.persona.org/", Name = "Servicio personas v1.0", Description = "Presenta el crud basico para la entidad Persona.")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PersonasService : System.Web.Services.WebService
    {
        private PersonaDataService _dataService;

        public PersonasService()
        {
            this._dataService = new PersonaDataService();
        }

        [WebMethod]
        public Persona[] ConsultarPersonas()
        {
            return _dataService.ObtenerPersonas();
        }

        [WebMethod]
        public Persona ConsultarPersonaPorId(int id)
        {
            return _dataService.OntenerPersonaPorId(id);
        }
    }
}
