using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuessIt : ControllerBase
    {
        private readonly GuessItService _service;

        public GuessIt(GuessItService service)
        {
            _service = service;
        }

        [HttpGet("easy/{guess}")]
        public IActionResult Easy(int guess)
        {
            if (guess < 1 || guess >10)
            return BadRequest("Must be a guess between 1 and 10");

            return Ok(_service.CheckGuess(guess, 1, 10, "Easy"));
        }

        [HttpGet("medium/{guess}")]
        public IActionResult Medium(int guess)
        {
            if(guess < 1 || guess > 50)
            return BadRequest("Must be a guess between 1 and 50");

            return Ok(_service.CheckGuess(guess, 1, 50, "Medium"));
        }

        [HttpGet("hard/{guess}")]
        public IActionResult Hard(int guess)
        {
            if (guess < 1 || guess > 100)
            return BadRequest("Must be a guess between 1 and 100");

            return Ok(_service.CheckGuess(guess, 1, 100, "Hard"));
        
        }
    }
}