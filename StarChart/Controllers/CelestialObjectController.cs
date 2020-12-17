using System;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using StarChart.Data;
using StarChart.Models;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        
        [HttpGet("{id:int}", Name = "GetById")]
        public OkObjectResult GetById(int id)
        {
            var celestialObjectId = new CelestialObject().Id;
            if (celestialObjectId == id)
            {
                return Ok(id);
            }

            return new OkObjectResult(StatusCodes.Status404NotFound);
        }
    }
}
