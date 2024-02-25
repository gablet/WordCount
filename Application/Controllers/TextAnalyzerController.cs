using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("analyzer")]
    public class TextAnalyzerController : ControllerBase
    {
        public TextAnalyzer _textAnalyzer;
        private readonly ILogger<TextAnalyzerController> _logger;

        public TextAnalyzerController(TextAnalyzer textAnalyzer, ILogger<TextAnalyzerController> logger)
        {
            _textAnalyzer = textAnalyzer;
            _logger = logger;
        }

        [HttpPost("/word/frequency")]
        public async Task<IActionResult> CountWordFrequency([FromBody] string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                _logger.LogInformation("Bad Request: Invalid text input");
                return BadRequest();
            }

            var result = await _textAnalyzer.CountWordFrequency(text);
            return Ok(result);
        }
    }
}