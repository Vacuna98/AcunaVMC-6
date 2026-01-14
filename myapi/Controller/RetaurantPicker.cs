using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPicker : ControllerBase
    {
        private readonly RestaurantPickerService _service;

        public RestaurantPicker(RestaurantPickerService service)
        {
            _service = service;
        }

        [HttpGet("{category}")]
        public IActionResult Get(string category)
        {
            
            if (string.IsNullOrEmpty(category))
            return BadRequest ("Category is required");

            return Ok(_service.PickRestaurant(category));
        }



    }
}