using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcWebAPI.Business;
using CalcWebAPI.Model;
using Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;

namespace CalcWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromServices]IServiceProvider provider, 
            [FromBody] CalcModel calcModel)
        {
            ILogSingleton log = provider.GetService<ILogSingleton>();
                
            CalcBus calc = new CalcBus();
            return Ok(calc.Calculation(calcModel, log));
        }
    }
}