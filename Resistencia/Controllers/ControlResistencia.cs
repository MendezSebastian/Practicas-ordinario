namespace Name.Controllers
{
    using System;
    using Resistencia.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ControllerController : ControllerBase
    {
        [HttpGet]
        [Route("Calcular/{Banda1}/{Banda2}/{Banda3}/{Banda4}")]
        public IActionResult Getop(string B1,string B2,string B3,string B4)
        {
            var resultado = new Result();
            resultado.Banda_1(B1);
            resultado.Banda_2(B2);
            resultado.Banda_3(B3);
            resultado.Banda_gold(B4);
            resultado.operacion();
            return Ok(resultado.operacion());
        }
    }
}