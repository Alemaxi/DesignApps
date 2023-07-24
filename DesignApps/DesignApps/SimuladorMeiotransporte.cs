using Domain.MeiosDeTransporte;
using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignApps
{
    public class SimuladorMeiotransporte
    {
        readonly Bicicleta bicicleta;
        readonly Carro carro;
        readonly Moto moto;

        public SimuladorMeiotransporte()
        {
            bicicleta = SimuladorDeMeioDeTransporte.GerarBicicleta();
            carro = SimuladorDeMeioDeTransporte.GerarCarro();
            moto = SimuladorDeMeioDeTransporte.GerarMoto();
        }

        public void ExibirMeiosDeTransporte()
        {
            Console.WriteLine("Carros simulados com Factory Method \n");
            Console.WriteLine(bicicleta.ToString());
            Console.WriteLine(carro.ToString());
            Console.WriteLine(moto.ToString());
        }
    }
}
