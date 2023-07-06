using AbstractFactory;

namespace DesignApps
{
    public class DesenhaCirculo
    {

        public void Desenhar()
        {
            Console.WriteLine("Abstract factory \n");

            ICirculoFactory circuloMalfeitoFactory = new CirculoMalFeitoESemNomeBonito();
            ICirculoFactory circuloMalfeitoComNomeBonitoFactory = new CirculoMalfeitoEComNomeBonito();

            var circuloMalFeito = circuloMalfeitoFactory.Desenhar();
            var circuloMalFeitoComNomeBonito = circuloMalfeitoComNomeBonitoFactory.Desenhar();



            Console.WriteLine($"{circuloMalFeito.Raio} | {circuloMalFeito.MalFeito}");
            Console.WriteLine($"{circuloMalFeitoComNomeBonito.Raio} | {circuloMalFeitoComNomeBonito.MalFeito}");
        }
    }
}
