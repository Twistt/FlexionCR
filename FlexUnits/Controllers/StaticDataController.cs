using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlexUnits.Models;

namespace FlexUnits.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaticDataController : Controller
    {
        //This should be loaded from a database not declared in-line
        public static List<Conversion> Conversions = new List<Conversion>() 
        {
            new Conversion{ Type= ConversionType.Temperature, UOM="Kelvin" },
            new Conversion{ Type= ConversionType.Temperature, UOM="Celsius" },
            new Conversion{ Type= ConversionType.Temperature, UOM="Fahrenheit" },
            new Conversion{ Type= ConversionType.Temperature, UOM="Rankine" },

            new Conversion{ Type= ConversionType.Volume, UOM="Liters" },
            new Conversion{ Type= ConversionType.Volume, UOM="Tablespoons" },
            new Conversion{ Type= ConversionType.Volume, UOM="Cubic-inches" },
            new Conversion{ Type= ConversionType.Volume, UOM="Cups" },
            new Conversion{ Type= ConversionType.Volume, UOM="Cubic-feet" },
            new Conversion{ Type= ConversionType.Volume, UOM="Gallons" },

        };
        //between Kelvin, Celsius, Fahrenheit, and Rankine
        //liters, tablespoons, cubic-inches, cups, cubic-feet, and gallons
        [HttpGet]
        public IEnumerable<Conversion> Get() => Conversions.OrderBy(o=>o.Type);
        
    }
}
