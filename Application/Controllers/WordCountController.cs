using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;


namespace Application.Controllers
{
    [Route("/")]
    public class WordCountController : ControllerBase
    {
        public CounterService _counterService;
        private readonly ILogger<WordCountController> _logger;

        public WordCountController(CounterService counterService, ILogger<WordCountController> logger)
        {
            _counterService = counterService;
            _logger = logger;
        }

        [HttpPost("count")]
        public async Task<IActionResult> Count([FromBody] string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                _logger.LogInformation("Bad Request: Invalid text input");
                return BadRequest();
            }

            var result = await _counterService.Count(text);
            return Ok(result);
        }
    }
}