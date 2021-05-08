using CoreWebAPI.Models;
using CoreWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;

        public CitiesController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<City>> GetCities()
        {
            return await _cityRepository.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCities(int id)
        {
            return await _cityRepository.Get(id);
        }
    }
}
