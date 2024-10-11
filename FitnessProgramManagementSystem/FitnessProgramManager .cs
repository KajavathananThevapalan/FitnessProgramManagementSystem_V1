using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgramManager
    {
        public List<FitnessProgram> FitnessProgramsList;

        public FitnessProgramManager()
        {
            FitnessProgramsList = new List<FitnessProgram>();
        }


        public void CreateFitnessProgram()
        {
            Console.WriteLine("Enter the FitnessProgram ID :");
            var FitnessProgramId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Title :");
            var Title = Console.ReadLine();

            Console.WriteLine("Enter the Duration :");
            var Duration = Console.ReadLine();

            var Price = ValidateFitnessProgramPrice();

            var FitnessProgram = new FitnessProgram()
            {
                FitnessProgramId = FitnessProgramId,
                Title = Title,
                Duration = Duration,
                Price = Price
            };

            this.FitnessProgramsList.Add(FitnessProgram);
            Console.WriteLine("Fitness Program Added Successfully");

        }

        public void ReadFitnessPrograms()
        {
            if (FitnessProgramsList != null)
            {
                foreach (var FitnessProgram in FitnessProgramsList)
                {
                    Console.WriteLine(FitnessProgram.ToString());
                }
            }else
            {
                Console.WriteLine("Data empty");
            }

        }


        public void UpdateFitnessProgram()
        {
            Console.WriteLine("Enter the FitnessProgram ID to be updated :");
            var FitnessProgramId = int.Parse(Console.ReadLine());
            var FindFitnessProgram = this.FitnessProgramsList.Where(p => p.FitnessProgramId == FitnessProgramId).FirstOrDefault();
            if (FindFitnessProgram != null)
            {

                Console.WriteLine("Enter the Title :");
                var nTitle = Console.ReadLine();

                Console.WriteLine("Enter the Duration :");
                var nDuration = Console.ReadLine();

                var nPrice = ValidateFitnessProgramPrice();

                var nFitnessProgram = new FitnessProgram()
                {
                    FitnessProgramId = FitnessProgramId,
                    Title = nTitle,
                    Duration = nDuration,
                    Price = nPrice
                };
                this.FitnessProgramsList.Remove(FindFitnessProgram);
                this.FitnessProgramsList.Add(nFitnessProgram);
                Console.WriteLine("Fitness Program Updated Successfully");
            }
            else
            {
                Console.WriteLine("Invalid FitnessProgram ID");
            }


        }

        public void DeleteFitnessProgram()
        {
            Console.WriteLine("Enter the FitnessProgram ID to be deleted :");
            var FitnessProgramId = int.Parse(Console.ReadLine());
            var FindFitnessProgram = this.FitnessProgramsList.Where(p => p.FitnessProgramId == FitnessProgramId).FirstOrDefault();
            if (FindFitnessProgram != null)
            {
                this.FitnessProgramsList.Remove(FindFitnessProgram);
                Console.WriteLine("Fitness Program Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Invalid FitnessProgram ID");
            }
        }

        public decimal ValidateFitnessProgramPrice()
        {
            decimal init = 0;
            while (true) 
            {
                Console.WriteLine("Enter the Price :");
                var Price = decimal.Parse(Console.ReadLine());
                if (Price > 0) 
                {
                    init = Price;
                    return init;
                }
                Console.WriteLine("Invalid Price.Please Reenter Price... ");
            }
            
        }
    }
}
