using System;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;
using StarChart.Models;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // GET
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return new EmptyResult();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return new EmptyResult();
        }

        [HttpGet]
        public IActionResult GetById()
        {
            return new EmptyResult();
        }

        [HttpGet]
        public IActionResult GetByName()
        {
            return new EmptyResult();
        }


        public CelestialObjectController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
    }
}
