using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Increment : IIncrement
    {
        private readonly int _parameter;

        public Increment(int parameter)
        {
            _parameter = parameter;
        }


        public double Result(double value) => value + _parameter;
    }
}
