using firsrApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Data;
using System.Text.Json.Serialization;

namespace firsrApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly CityRepository _cityRepository;
        public CityController(CityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        [HttpGet]
        public IActionResult GetAllCities()
        {
            DataTable table = new DataTable();
            table = _cityRepository.GetAllCities();
            return Ok(JsonConvert.SerializeObject(table));
        }
    }
}
