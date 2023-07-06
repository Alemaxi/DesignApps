using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Circulo
    {
        public int Raio { get; set; }
        public bool MalFeito { get; set; }
        public bool NomeBonito { get; set; }

        public int Diametro()
        {
            return Raio * 2;
        }
    }
}
