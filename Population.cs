using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
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