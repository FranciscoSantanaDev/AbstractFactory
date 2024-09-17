using Factory.Entities;

namespace Factory.Factory
{
    public interface IPlantaFactory
    {
        Planta CriaPlanta(string especie, DateTime dtGerminacao);
    }
}
