using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Transient transient;
        private readonly Scoped scoped;
        private readonly Singleton singleton;


        public WeatherForecastController(Singleton singleton, Scoped scoped, Transient transient)
        {
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
        }

        [HttpGet]
        [Route("Number")]
        public string Number()
        {
            return $"scoped: {scoped.randomNumber}, transient: {transient.randomNumber}, singleton: {singleton.randomNumber}";

        }
    }
}