using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Activity2
{
    internal class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return  (celsius * (9/5)) + 32;
                
               // (0°C × 9 / 5) +32 = 32°F

        }        

    }
}
