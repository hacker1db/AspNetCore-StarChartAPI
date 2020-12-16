using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    public class CelestialObjectController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        // GET
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return new EmptyResult();
        }

        public CelestialObjectController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
