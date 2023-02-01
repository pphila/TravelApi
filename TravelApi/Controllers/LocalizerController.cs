// using Microsoft.AspNetCore.Mvc;
// using TravelApi.Models;

// namespace TravelApi.Controllers.v1
// {
//     [ApiController]
//     [Route("api/v{version:apiVersion}/[controller]")]
//     [ApiVersion("1.0")]
//     public class DestinationsController : ControllerBase
//     {
//         [MapToApiVersion("1.0")]
//         [HttpGet]
//         public string Get(Destination Destination) => $"Controller = {GetType().Country}\nVersion = {travelApi}";
//     }
// }

// namespace TravelApi.Controllers.v2
// {
//     [ApiController]
//     [Route("api/v{version:apiVersion}/[controller]")]
//     [ApiVersion("2.0")]
//     public class Destinations2Controller : ControllerBase
//     {
//         //[MapToApiVersion("2.0")]
//         //[HttpGet]
//         //public string Get() => ".Net Core Web API Version 2";
//     }
// }