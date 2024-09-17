using Factory.Domain;
using Factory.Factory;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    [ApiController]
    [Route("api")]
    public class PlantasController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public PlantasController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [HttpGet(Name = "BuscaPlanta")]
        public string BuscaPlanta(string especie, DateTime dtGerminacao)
        {
                Planta pimenta = new(especie, _serviceProvider);
                return pimenta.BuscaPlanta(especie, dtGerminacao);
            
        }
    }
}
