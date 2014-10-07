using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace WebService.ClienteRest.DataServices
{
    public class PersonaDataServices
    {
        public Persona[] ObtenerPersonas()
        {
            string url = "http://localhost:60893/PersonasService.svc/obtenerPersonas";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            Stream newStream = null;
            using (WebResponse response = request.GetResponse())
            {
                newStream = response.GetResponseStream();
                var serializador = new DataContractJsonSerializer(typeof(Persona[]));
                return (Persona[])serializador.ReadObject(newStream);
            }
        }

        public Persona ObtenerPersonaPorId(int id)
        {
            string url = string.Format("http://localhost:60893/PersonasService.svc/Personas/{0}", id.ToString());
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            using (WebResponse response = request.GetResponse())
            {
                var serializador = new DataContractJsonSerializer(typeof(Persona));
                return (Persona)serializador.ReadObject(response.GetResponseStream());
            }
        }

        public Persona GuardarPersona(Persona persona)
        {
            string url = "http://localhost:60893/PersonasService.svc/Persona";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            var serializador = new DataContractJsonSerializer(typeof(Persona));
            var requestStream = request.GetRequestStream();
            serializador.WriteObject(requestStream, persona);
            requestStream.Close();
            using (WebResponse response = request.GetResponse())
            {
                return (Persona)serializador.ReadObject(response.GetResponseStream());
            }

        }
    }
}
