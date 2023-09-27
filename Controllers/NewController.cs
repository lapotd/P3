using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewController : ControllerBase
    {
        private readonly Transient transient;
        private readonly Scoped scoped;
        private readonly Singleton singleton;

        public NewController(Scoped scoped, Transient transient, Singleton singleton)
        {
            this.scoped = scoped;
            this.transient = transient;
            this.singleton = singleton;
        }

        [HttpGet]
        [Route("Number")]
        public string Number()
        {
            return $"scoped: {scoped.randomNumber}, transient: {transient.randomNumber}, singleton: {singleton.randomNumber}";
        }

        [HttpGet]
        [Route("GetNumber")]
        public ActionResult<string> Number(int number)
        {
            if (number < 50)
            {
                return Ok(number.ToString());
            }
            else
            {
                return BadRequest($"Number too high!! number: {number}");
            }
        }
    }
}