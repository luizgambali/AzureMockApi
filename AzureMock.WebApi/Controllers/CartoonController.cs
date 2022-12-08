using AzureMock.WebApi.Data;
using AzureMock.WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace AzureMock.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartoonController : ControllerBase
    {
        private readonly ILogger<CartoonController> _logger;

        public CartoonController(ILogger<CartoonController> logger)
        {
            _logger = logger;

            _logger.LogInformation("Creating instance for CartoonController");
        }

        [HttpGet]
        public IEnumerable<Characters> GetAll()
        {
            _logger.LogInformation("Request for GetAll()");

            return CharactersRepository.GetAll();
        }
    }
}
