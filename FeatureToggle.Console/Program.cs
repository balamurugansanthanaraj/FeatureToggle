using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine("ADD :: "+result);
            result = calculator.Sub(2,1);
            System.Console.WriteLine("SUB :: " + result);
            System.Console.ReadKey();
        }
    }
}
