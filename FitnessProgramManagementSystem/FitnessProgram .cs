using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {
        private string FitnessProgramId { get; set; }
        private string Title { get; set; }
        private string Duration { get; set; }
        private string Price { get; set; }

        public FitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            FitnessProgramId = fitnessProgramId;
            Title = title;
            Duration = duration;
            Price = price;
        }

        public override string ToString() 
        {
            return $"FitnessProgramId:{FitnessProgramId} Title: {Title} Duration: {Duration} Price: {Price} ";
        }
    }
}
