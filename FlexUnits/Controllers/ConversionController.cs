using FlexUnits.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexUnits.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversionController : ControllerBase
    {

        private readonly ILogger<ConversionController> _logger;

        //we inject the logger (we dont know what the implementation will be yet - DB, file, api, etc) 
        public ConversionController(ILogger<ConversionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public decimal Get(string fromUOM, string toUOM, decimal Value)
        {
            if (fromUOM == toUOM) return Math.Round(Value,1);
            //It seems like we should use the COALESCE operator here but we are invoking 2 different functions from/to
            var res = Conversion.Conversions.Where(c => c.Item1 == fromUOM && c.Item2 == toUOM).FirstOrDefault();
            if (res != null) return res.Item3.Invoke(Value);
            if (res == null) res = Conversion.Conversions.Where(c => c.Item1 == toUOM && c.Item2 == fromUOM).FirstOrDefault();
            if (res != null) return res.Item4.Invoke(Value);
            // Fall through option if we cant find a conversion
            return 0;

        }


    }
}
