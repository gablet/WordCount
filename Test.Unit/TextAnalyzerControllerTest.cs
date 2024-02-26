using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Controllers;
using Application.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Test.Unit
{
    public class TextAnalyzerControllerTest
    {
        [Fact]
        public void TestControllerOk()
        {
            var analyzer = new TextAnalyzer();
            var controller = new TextAnalyzerController(analyzer);
            string text = "Dog Cat Rat Dog Monkey Lion Rat";

            var result = controller.CountWordFrequency(text);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void TestControllerEmptyStringBadRequest()
        {
            var analyzer = new TextAnalyzer();
            var controller = new TextAnalyzerController(analyzer);
            string text = "";

            var result = controller.CountWordFrequency(text);

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void TestControllerOnlySpacesBadRequest()
        {
            var analyzer = new TextAnalyzer();
            var controller = new TextAnalyzerController(analyzer);
            string text = "   ";

            var result = controller.CountWordFrequency(text);

            Assert.IsType<BadRequestResult>(result);
        }
    }
}