namespace Factory.Entities
{
    public abstract class Planta
    {
        protected Planta(string especie, DateTime dtGerminacao)
        {
            Especie = especie;
            DtGerminacao = dtGerminacao;
        }

        public string Especie { get; protected set; }

        public DateTime DtGerminacao { get; protected set; }

        public DateTime DtEstimadaColheita { get; protected set; }

        public double LitrosDeAguaPorRega { get; protected set; }

        public abstract void CalculaRega();

        public abstract void CalculaColheita();
    }
}
