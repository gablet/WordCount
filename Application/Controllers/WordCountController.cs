using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;


namespace Application.Controllers
{
    [Route("/")]
    public class WordCountController : ControllerBase
    {
        private CounterService _counterService;
        
        public WordCountController(CounterService counterService)
        {
            _counterService = counterService;
        }

        [HttpPost("count")]
        public IActionResult Count([FromBody]string text) 
        {
            var result = _counterService.Count(text);
            return Ok(result);
        }
    }
}