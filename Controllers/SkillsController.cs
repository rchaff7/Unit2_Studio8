using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html =
                "<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn:</h2>" +
                "<ol>" +
                    "<li>C#</li>" +
                    "<li>JavaScript</li>" +
                    "<li>Python</li>" +
                "</ol>";

            return Content(html, "text/html");
        }

        [HttpGet]
        [HttpPost]
        [Route("form")]
        public IActionResult Form(string date = null, string progress1="", string progress2="", string progress3="")
        {
            string html;
            if (date == null)
            {
                html =
                    "<form method='post' action='form'>" +
                        "Date:<br>" +
                        "<input type='date' name='date' required><br>" +
                        "C#:<br>" +
                        "<select name='progress1'>" +
                            "<option value='Learning basics'>Learning basics</option>" +
                            "<option value='Making apps'>Making apps</option>" +
                            "<option value='Master coder'>Master coder</option>" +
                        "</select><br>" +
                        "JavaScript:<br>" +
                        "<select name='progress2'>" +
                            "<option value='Learning basics'>Learning basics</option>" +
                            "<option value='Making apps'>Making apps</option>" +
                            "<option value='Master coder'>Master coder</option>" +
                        "</select><br>" +
                        "Python:<br>" +
                        "<select name='progress3'>" +
                            "<option value='Learning basics'>Learning basics</option>" +
                            "<option value='Making apps'>Making apps</option>" +
                            "<option value='Master coder'>Master coder</option>" +
                        "</select><br>" +
                        "<input type='submit' value='Submit'>" +
                    "</form>";
            }
            else
            {
                html =
                    "<h1>" + date + "</h1>" +
                    "<ol>" +
                        "<li>C#: " + progress1 +
                        "<li>JavaScript: " + progress2 +
                        "<li>Python: " + progress3 +
                    "</ol>";
            }

            return Content(html, "text/html");
        }
    }
}
