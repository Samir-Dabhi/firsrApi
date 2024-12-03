using firsrApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Security.AccessControl;

namespace firsrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly StateRepository _stateRepository;
        public StateController(StateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        [HttpGet]
        public ActionResult GetAllState() {
            DataTable table = new DataTable();
            table = _stateRepository.GetAllStates();
            return Ok(JsonConvert.SerializeObject(table));
        }
    }
}
