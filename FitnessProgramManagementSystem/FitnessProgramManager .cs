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
        public List<FitnessProgram> FitnessProgramList;

        public FitnessProgramManager() {
            
            FitnessProgramList = new List<FitnessProgram>();

        }

        public void CreateFitnessProgram()
        {
            Console.WriteLine("Enter the FitnessProgramId :");
            var FitnessProgramId = Console.ReadLine();

            Console.WriteLine("Enter the Title :");
            var Title = Console.ReadLine();

            Console.WriteLine("Enter the Duration :");
            var Duration = Console.ReadLine();

            var Price = ValidateFitnessProgramPrice();

            var fitnessProgram = new FitnessProgram()
            {
                FitnessProgramId = FitnessProgramId,
                Title = Title,
                Duration = Duration,
                Price = Price
            };

            FitnessProgramList.Add.fitnessProgram;

            Console.WriteLine("FitnessProgram Added Successfully...");
        }

        public  ReadFitnessPrograms( )
        {

            foreach(var fitnessProgram in FitnessProgramList)
            {
                return $" FitnessProgramId: {FitnessProgramId} Title: {Title} Duration: {Duration} Price: {Price}" ;
            }

        }


        public  void UpdateFitnessProgram()
        {
            Console.WriteLine("Enter the FitnessProgramId :");
            var nFitnessProgramId = Console.ReadLine();
            var FindFitnessProgram = FitnessProgramList.Where(f => f.FitnessProgramId == nFitnessProgramId).FirstOrDefault();

            if (FindFitnessProgram != null)
            {
                Console.WriteLine("Enter the Title :");
                var nTitle = Console.ReadLine();

                Console.WriteLine("Enter the Duration :");
                var nDuration = Console.ReadLine();

                var Price = ValidateFitnessProgramPrice();

                var nfitnessProgram = new FitnessProgram()
                {
                    FitnessProgramId = nFitnessProgramId,
                    Title = nTitle,
                    Duration = nDuration,
                    Price = nPrice
                };
                FitnessProgramList.Remove.nfitnessProgram;

                Console.WriteLine("FitnessProgram Updated Successfully...");

            }
            else
            {

                Console.WriteLine("Invalid FitnessProgramId :");

            }

        }

        public  void DeleteFitnessProgram()
        {
            Console.WriteLine("Enter the FitnessProgramId :");
            var FitnessProgramId = Console.ReadLine();
            var FindFitnessProgram = FitnessProgramList.Find(f => f.FitnessProgramId == FitnessProgramId).FirstOrDefault();
             
            if (FindFitnessProgram == null)
            {
                Console.WriteLine("FitnessProgram Deleted Successfully...");
            }
            else
            {

                Console.WriteLine("Invalid FitnessProgramId :");

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
