using Domain.Bolo;

namespace Builder
{
    public class SimplesMaracujaAmericanoBuilder : IBoloBuilder
    {
        Bolo bolo = new Bolo();

        public void FazerMassa()
        {
            bolo.Massa = MassaEnum.simples;
        }

        public void Rechear()
        {
            bolo.Recheio = RecheioEnum.maracujá;
        }

        public void Confeitar()
        {
            bolo.Confeito = ConfeitoEnum.pastaAmericana;
        }

        public Bolo ObterBolo => bolo;
    }
}
