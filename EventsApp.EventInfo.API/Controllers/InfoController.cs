using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventInfo.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventsApp.EventInfo.API.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private IEventInfoService _service;
        public InfoController(IEventInfoService service){
            _service = service;
        }
        [HttpGet("all")]
        public IActionResult GetEvents()
        {
            var result= _service.GetAllEvents();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetEvent(int id)
        {
            var result = _service.GetEvent(id);
            return Ok(result);
        }
        [Route("country/{id}")]
        [HttpGet()]
        public IActionResult GetEventsByCountry(int id)
        {
            var result = _service.GetAllEventsByCountry(id);
            return Ok(result);
        }

    }
}