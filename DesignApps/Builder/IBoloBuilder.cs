using Domain.Bolo;

namespace Builder
{
    public interface IBoloBuilder
    {
        public void FazerMassa();
        public void Rechear();
        public void Confeitar();
        public Bolo ObterBolo { get; }
    }
}
