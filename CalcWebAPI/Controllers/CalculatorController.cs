using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcWebAPI.Business;
using CalcWebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] CalcModel calcModel)
        {
            CalcBus calc = new CalcBus();
            return Ok(calc.Calculation(calcModel));
        }
    }
}