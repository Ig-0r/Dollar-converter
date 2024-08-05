using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDolarReal
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double Converter(double cot, double quantia)
        {
            double total = cot * quantia;
            return total + total * (IOF / 100.0);
        }



    }
}
