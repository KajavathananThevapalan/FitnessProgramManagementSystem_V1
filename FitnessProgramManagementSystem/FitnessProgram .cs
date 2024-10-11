﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {
        public FitnessProgram() { }
        public int FitnessProgramId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
        public int TotalFitnessPrograms { get; set; }

        public FitnessProgram(int fitnessProgramId, string title, string duration, decimal price)
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

        public virtual DisplayFitnessProgramInfo(

        )
    }
}
