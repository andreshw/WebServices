using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Data;

namespace WebServices.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPersonasService" in both code and config file together.
    [ServiceContract]
    public interface IPersonasService
    {
        [OperationContract]
        Persona[] ObtenerPersonas();

        [OperationContract]
        Persona ObtenerPersonaPorId(int id);

        [OperationContract]
        void GuardarPersona(Persona persona);
    }
}
