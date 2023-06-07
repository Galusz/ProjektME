using Microsoft.AspNetCore.Mvc;
using Zadanie_ME.Repositories;

namespace Zadanie_ME.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProduktController : ControllerBase
    {

        private readonly IProduktRepository _produktRepository;

        private readonly ILogger<ProduktController> _logger;

        public ProduktController(ILogger<ProduktController> logger, IProduktRepository produktRepository)
        {
            _logger = logger;
            _produktRepository = produktRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produkt>> GetAllProducts()
        {
            var products = _produktRepository.GetAllProducts();
            return Ok(products);
        }

        [HttpPost]
        public ActionResult AddProduct(Produkt product)
        {
            _produktRepository.AddProduct(product);
            return Ok();
        }

    }
}