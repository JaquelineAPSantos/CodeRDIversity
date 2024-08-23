﻿using Microsoft.AspNetCore.Mvc;

namespace TermometroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TermometroController : ControllerBase
    {
        public class Temperatura
        {
            public string CalcularTemperatura(double temp, string unidade)
            {
                var temper = ConvertToCelsius(temp, unidade);

                if (temper <= 0)
                    return "Congelando";

                if (temper > 0 && temper < 15)
                    return "Frio";

                if (temper >= 15 && temper < 21) 
                    return "Fresquinho";

                if (temper >= 21 && temper < 28)
                    return "Calor";

                if (temper >= 28)
                    return "Derretendo";

                return "Temperatura inválida!";
            }

            private double ConvertToCelsius(double temp, string unidade)
            {
                switch (unidade.ToUpper())
                {
                    case "C":
                        return temp;

                    case "F":
                        return (temp - 32) * 5 / 9;

                    case "K":
                        return temp - 273.15;

                    default:
                        throw new Exception("Unidade de temperatura não existente!");
                }
            }
        }

        [HttpGet(Name = "GetTemperature")]
        public IActionResult Get(double temp, string unidade)
        {
            var temperatura = new Temperatura();
            var resultado = temperatura.CalcularTemperatura(temp, unidade);
            return Ok(resultado);
        }
    }
}
