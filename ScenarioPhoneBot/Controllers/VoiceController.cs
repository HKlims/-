using Microsoft.AspNetCore.Mvc;
using Twilio.TwiML;

namespace ScenarioPhoneBot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoiceController : ControllerBase
    {
        private readonly ScenarioManager _scenarioManager = new ScenarioManager();

        [HttpPost]
        public IActionResult HandleCall([FromForm]string SpeechResult)
        {
            var response = new VoiceResponse();
            string reply = _scenarioManager.GetReply(SpeechResult ?? string.Empty);
            response.Say(reply);
            response.Listen();
            return Content(response.ToString(), "text/xml");
        }
    }
}
