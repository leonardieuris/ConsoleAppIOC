using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp1
{
    public class Circle
    {
        private readonly double _piGreco;

        public Circle(IConfiguration configuration)
        {
            _piGreco = double.Parse(configuration["PiGreco"]);
        }

        public double Calculate(double r) => r * _piGreco;
    }
}
