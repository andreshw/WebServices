using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonasClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DataServices.PersonaDataServices dataServices = new DataServices.PersonaDataServices();
            var personas = dataServices.ConsultarPersonas();
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.Nombre);
            }
            Console.ReadKey();
        }
    }
}
