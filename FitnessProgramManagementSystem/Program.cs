using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FitnessProgram1 = new FitnessProgram("1", "Weight Lifting", "4 months", "1000.00");
            Console.WriteLine(FitnessProgram1.ToString());
            Console.ReadLine();
        }
    }
}
