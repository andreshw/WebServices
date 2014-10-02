using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    [Serializable]
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
