using Microsoft.AspNetCore.Mvc;

namespace TravelApi.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DestinationsController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        public string Get() => ".Net Core Web API Version 1";
    }
}

namespace TravelApi.Controllers.v2
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    public class Destinations2Controller : ControllerBase
    {
        //[MapToApiVersion("2.0")]
        //[HttpGet]
        //public string Get() => ".Net Core Web API Version 2";
    }
}