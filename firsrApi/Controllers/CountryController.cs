using firsrApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;

namespace firsrApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryRepository _cityRepository;
        public CountryController(CountryRepository cityRepository)
        {
            Console.WriteLine("constructor called");
            _cityRepository = cityRepository;
        }
        [HttpGet]
        public IActionResult getAllCountry()
        {
            DataTable table = new DataTable();
            table = _cityRepository.GetAllCountries();
            return Ok(JsonConvert.SerializeObject(table));
        }
    }
}
