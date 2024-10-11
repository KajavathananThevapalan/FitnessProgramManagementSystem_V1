using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var FitnessProgram1 = new FitnessProgram("1", "Weight Lifting", "4 months", "1000.00");
            //Console.WriteLine(FitnessProgram1.ToString());
            

            Menu();
            Console.ReadLine();

        }

        public static void Menu()
        {
            var manager = new FitnessProgramManager();

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("----------------------FitnessProgram Management System: -------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("1. Add a FitnessProgram");
            Console.WriteLine("2. View All FitnessPrograms");
            Console.WriteLine("3. Update a FitnessProgram");
            Console.WriteLine("4. Delete a FitnessProgram");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option:");
            var UserInput = Console.ReadLine();

            switch (UserInput) {
                case "1":
                    Console.Clear();
                    manager.CreateFitnessProgram();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    manager.ReadFitnessPrograms();
                    Menu();
                    break;
                case "3":
                    Console.Clear();
                    manager.UpdateFitnessProgram();
                    Menu();
                    break;
                case "4":
                    Console.Clear();
                    manager.DeleteFitnessProgram();
                    Menu();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Thank You!!! Come Again!!!");
                    return;
                default:
                    Menu();
                    break;

            }
        }
    }
}
