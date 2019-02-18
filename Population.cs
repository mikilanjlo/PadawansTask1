using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
                throw new ArgumentException("Initial Population Cannot Be Less Or Equals Zero");
            if (currentPopulation <= 0)
                throw new ArgumentException("current Population Cannot Be Less Or Equals Zero");
            int years = 0;
            percent = percent / 100;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation = (int)(initialPopulation + (initialPopulation * percent) + visitors);
                years++;
            }
            return years;
        }
    }
}