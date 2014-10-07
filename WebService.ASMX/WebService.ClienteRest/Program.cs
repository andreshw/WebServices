using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebService.ClienteRest.DataServices;
using Data;

namespace WebService.ClienteRest
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaDataServices dataServices = new PersonaDataServices();
            Persona nuevaPersona = new Persona() { Id = 4, Nombre = "Maria Laura", Edad = 9 };
            Persona persona = dataServices.GuardarPersona(nuevaPersona);
            //foreach (var persona in personas)
            //{
                Console.WriteLine(persona.Nombre);
            //}
            Console.ReadKey();
        }
    }
}
