using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class Magic8Ball : ControllerBase
    {
        private readonly Magic8Service _service;

        public Magic8Ball(Magic8Service service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = _service.GetResponse();
            return Ok(new { response });
        }
    }
}