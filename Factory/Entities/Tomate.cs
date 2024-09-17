
namespace Factory.Entities
{
    public class Tomate : Planta
    {
        public Tomate(string especie, DateTime dtGerminacao) : base(especie,dtGerminacao)
        {
            CalculaRega();
            CalculaColheita();
        }

        public override void CalculaRega()
        {
           LitrosDeAguaPorRega = 1.5;
        }

        public override void CalculaColheita()
        {
            DtEstimadaColheita = DtGerminacao.AddDays(100);
        }
    }
}
