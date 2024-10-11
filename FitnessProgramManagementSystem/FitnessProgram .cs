using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {
        public string FitnessProgramId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Price { get; set; }
        public int TotalFitnessPrograms { get; set; }

        public FitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            FitnessProgramId = fitnessProgramId;
            Title = title;
            Duration = duration;
            Price = price;
            TotalFitnessPrograms++ ;

        }

        public override string ToString() 
        {
            return $"FitnessProgramId:{FitnessProgramId} Title: {Title} Duration: {Duration} Price: {Price} ";
        }
    }
}
