using Factory.Factory;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Factory.Domain
{
    public class Planta
    {
        IPlantaFactory _plantaFactory;
        public Planta([ServiceKey] string serviceKey,IServiceProvider provider)
        {
            _plantaFactory = provider.GetRequiredKeyedService<IPlantaFactory>(serviceKey.ToLower());
        } 
        public string BuscaPlanta(string especie, DateTime dtGerminacao)
        {
           var planta =  _plantaFactory.CriaPlanta(especie,dtGerminacao);
            return $"Data prevista de colheita é {planta.DtEstimadaColheita} , sendo necessário relizar de {planta.LitrosDeAguaPorRega} litros";
        }
    }
}
