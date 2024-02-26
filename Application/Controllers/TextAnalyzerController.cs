using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("analyzer")]
    public class TextAnalyzerController : ControllerBase
    {
        public TextAnalyzer _textAnalyzer;

        public TextAnalyzerController(TextAnalyzer textAnalyzer)
        {
            _textAnalyzer = textAnalyzer;
        }

        [HttpPost("/word/frequency")]
        public IActionResult CountWordFrequency([FromBody] string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return BadRequest();
            }

            var substrings = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (substrings.Length == 0)
            {
                return BadRequest();
            }

            var result = _textAnalyzer.CountWordFrequency(substrings);
            return Ok(result);
        }
    }
}