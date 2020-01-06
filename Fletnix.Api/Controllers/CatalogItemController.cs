using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Fletnix.Model;
using Fletnix.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fletnix.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CatalogItemController : ControllerBase
    {
        private readonly ICatalogService _catalogService;

        public CatalogItemController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(CatalogItem[]), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get()
        {
            var items = _catalogService.GetMovies();
            return Ok(items.ToArray());
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult CreateNewItem(CatalogItem item)
        {
            return Created("", new CatalogItem());
        }
    }
}
