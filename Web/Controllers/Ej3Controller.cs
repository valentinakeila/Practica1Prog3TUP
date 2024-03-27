﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string name, [FromQuery] int edad)
        {

            return $"Te llamas {name} y tienes {edad} años.";
        }
    }
}