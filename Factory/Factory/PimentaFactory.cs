using Factory.Entities;

namespace Factory.Factory
{
    public class PimentaFactory : IPlantaFactory
    {
        public Planta CriaPlanta(string especie, DateTime dtGerminacao)
        {
           return new Pimenta(especie, dtGerminacao);
        }
    }
}
