using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignApps
{
    public class EmpresaXPTO
    {
        Executivo executivoA;
        Executivo executivoB;

        public EmpresaXPTO() 
        {
            executivoA = new Executivo();
            executivoA.Nome = "Executivo A";
            executivoA.Resultados = 500.25f;
            executivoA.Descendentes.Add(new LiderEstratégico
            {
                Nome = "Lider estratégico",
                Resultados = 445,
                Descendentes = new List<ICalculadoraDeResultados>
                 {
                     new LiderTatico
                     {
                         Nome = "Lider tático",
                         Resultados = 255,
                         Descendentes = new List<ICalculadoraDeResultados>
                         {
                             new Operario
                             {
                                 Nome = "Operário",
                                 Resultados = 323f
                             }
                         }
                     }
                 }
            });

            executivoB = new Executivo();
            executivoB.Nome = "Executivo B";
            executivoB.Resultados = 366.25f;
            executivoB.Descendentes.Add(new LiderEstratégico
            {
                Nome = "Lider estratégico",
                Resultados = 200,
                Descendentes = new List<ICalculadoraDeResultados>
                 {
                     new LiderTatico
                     {
                         Nome = "Lider tático",
                         Resultados = 700,
                         Descendentes = new List<ICalculadoraDeResultados>
                         {
                             new Operario
                             {
                                 Nome = "Operário",
                                 Resultados = 323f
                             }
                         }
                     }
                 }
            });
        }

        public void CalcularResultados()
        {
            Console.WriteLine("Composite");
            Console.WriteLine("\n");

            Console.WriteLine($"Nome: {executivoA.Nome} | Resultados: {executivoA.CalclarResultados()}");
            Console.WriteLine($"Nome: {executivoB.Nome} | Resultados: {executivoB.CalclarResultados()}");
        }
    }
}
