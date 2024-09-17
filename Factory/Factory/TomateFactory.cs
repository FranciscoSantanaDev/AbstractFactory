using Factory.Entities;

namespace Factory.Factory
{
    public class TomateFactory : IPlantaFactory
    {
        public Planta CriaPlanta(string especie, DateTime dtGerminacao)
        {
           return new Tomate(especie, dtGerminacao);
        }
    }
}
