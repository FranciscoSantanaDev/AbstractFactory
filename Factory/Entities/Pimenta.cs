namespace Factory.Entities
{
    public class Pimenta : Planta
    {
        public Pimenta(string especie, DateTime dtGerminacao) : base(especie, dtGerminacao)
        {
            CalculaRega();
            CalculaColheita();
        }

        public override void CalculaRega()
        {
            LitrosDeAguaPorRega = 0.8;
        }

        public override void CalculaColheita()
        {
            DtEstimadaColheita = DtGerminacao.AddDays(70);
        }
    }
}
