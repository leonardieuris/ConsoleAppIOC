using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CircleBis : ICircle
    {
        private readonly double _piGreco;

        public CircleBis(double PiGreco)
        {
            _piGreco = PiGreco;
        }

        public double Calculate(double r) => r * _piGreco;
    }
}
