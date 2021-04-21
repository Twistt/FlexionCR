using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexUnits.Models
{
    public class Conversion
    {
        public ConversionType Type { get; set; }
        public string UOM { get; set; }

        //This will be a static propertly and will NOT be copied to each instance.
        //It should definately come from a DB not inline =(
        public static List<Tuple<string, string, Func<decimal, decimal>, Func<decimal, decimal>>> Conversions =
            new List<Tuple<string, string, Func<decimal, decimal>, Func<decimal, decimal>>>()
        {
            //--------------------------------Temperature---------------------------//
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Kelvin", "Celsius", 
                /*from*/ (value) => { return value - 273.15m;}, 
                /*to*/   (value) => { return value + 273.15m;}),

            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Kelvin", "Fahrenheit", 
                /*from*/ (value) => {return ((value - 273.15m)* 1.8m)+ 32.0m;},
                /*to*/   (value) => {return ((value - 273.15m)* 1.8m)+ 32.0m;}),

            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Kelvin", "Rankine", 
                /*from*/ (value) => {return ((value - 273.15m)* 1.8m)+ 32.0m;},
                /*to*/   (value) => {return ((value - 273.15m)* 1.8m)+ 32.0m;}),

            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Fahrenheit", "Celsius", 
                /*from*/ (value) => {return (value - 32m) /1.8m;},
                /*to*/   (value) => {return (value * 1.8m)+32;}),

            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Fahrenheit", "Rankine", 
                /*from*/ (value) => {return (value - 32m) +491;}, //this could be simplified but we are preserving the formula
                /*to*/   (value) => {return (value - 491m)+32;}),

            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Rankine", "Celsius", 
                /*from*/ (value) => {return (value - 491m) /1.8m;},
                /*to*/   (value) => {return (value * 1.8m)+491;}),
            //--------------------------------VOLUME---------------------------//
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Liters", "Tablespoons", 
                /*from*/ (value) => {return value * 67.628m;},
                /*to*/   (value) => {return value / 67.628m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Liters", "Cubic-inches", 
                /*from*/ (value) => {return value * 61.024m;},
                /*to*/   (value) => {return value / 61.024m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Liters", "Cups", 
                /*from*/ (value) => {return value * 4.2268m;},
                /*to*/   (value) => {return value / 4.2268m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Liters", "Cubic-feet", 
                /*from*/ (value) => {return value * 0.035315m;},
                /*to*/   (value) => {return value / 0.035315m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Liters", "Gallons", 
                /*from*/ (value) => {return value * 0.26417m;},
                /*to*/   (value) => {return value / 0.26417m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Tablespoons", "Cubic-inches", 
                /*from*/ (value) => {return value * 0.90234m;},
                /*to*/   (value) => {return value / 0.90234m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Tablespoons", "Cups", 
                /*from*/ (value) => {return value * 0.062500m;},
                /*to*/   (value) => {return value / 0.062500m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Tablespoons", "Cups", 
                /*from*/ (value) => {return value * 0.062500m;},
                /*to*/   (value) => {return value / 0.062500m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Tablespoons", "Cubic-feet", 
                /*from*/ (value) => {return value * 0.00052219m;},
                /*to*/   (value) => {return value / 0.00052219m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Tablespoons", "Gallons", 
                /*from*/ (value) => {return value * 0.0039062m;},
                /*to*/   (value) => {return value / 0.0039062m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Cubic-inches", "Gallons", 
                /*from*/ (value) => {return value * 0.0039062m;},
                /*to*/   (value) => {return value / 0.0039062m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Cups", "Cubic-feet", 
                /*from*/ (value) => {return value * 0.0083550m;},
                /*to*/   (value) => {return value / 0.0083550m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Cups", "Gallons", 
                /*from*/ (value) => {return value * 0.062500m;},
                /*to*/   (value) => {return value / 0.062500m;}),
            Tuple.Create<string, string, Func<decimal, decimal>, Func<decimal, decimal>>("Cubic-feet", "Gallons", 
                /*from*/ (value) => {return value * 0.13368m;},
                /*to*/   (value) => {return (value * value * value) * 7.4805m;}),
        };
    }


    public enum ConversionType
    {
        Volume,
        Temperature
    }
}

