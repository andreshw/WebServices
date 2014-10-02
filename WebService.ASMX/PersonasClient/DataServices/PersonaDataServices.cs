using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonasClient.PersonaWebService;

namespace PersonasClient.DataServices
{
    public class PersonaDataServices
    {
        private Serviciopersonasv10SoapClient clientePersonas;

        public PersonaDataServices()
        {
            clientePersonas = new Serviciopersonasv10SoapClient();
        }

        public Persona[] ConsultarPersonas()
        {
            return clientePersonas.ConsultarPersonas();
        }

        public Persona ConsultarPersonaPorId(int id)
        {
            return clientePersonas.ConsultarPersonaPorId(id);
        }
    }
}
