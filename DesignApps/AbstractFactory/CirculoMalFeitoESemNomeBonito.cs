using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CirculoMalFeitoESemNomeBonito : ICirculoFactory
    {
        public Circulo Desenhar()
        {
            return new Circulo { Raio = 3, MalFeito = true, NomeBonito = false };
        }
    }
}
