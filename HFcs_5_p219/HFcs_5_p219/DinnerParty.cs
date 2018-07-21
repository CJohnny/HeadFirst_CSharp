using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFcs_5_p219
{
     class DinnerParty
    {
        const int costOfFoodPerPerson = 25;

        //public int numberOfPeople;
        public double costOfBeveragesPerPerson;
        public double costOfDecoreations=0;
        private int numberOfPeople;
        private bool fancyDecorations=true;
        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostDecorations(fancyDecorations);
            }
        }
        public void SetHealthyOption(bool healthyoption)
        {
            if (healthyoption)
            {
                costOfBeveragesPerPerson = 5.00;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00;

            }
        }
        public void CalculateCostDecorations(bool fancy)
        {
            fancyDecorations = fancy;
                if (fancy)
                {
                    costOfDecoreations=numberOfPeople*15+50;
                }
                else
                {
                    costOfDecoreations = numberOfPeople * 7.5 + 30;
                }
        }
        public double CalculateCost(bool healthy)
        {
            double totalCost = costOfDecoreations + ((costOfBeveragesPerPerson + costOfFoodPerPerson) * numberOfPeople);
            if (healthy)
            {
                return totalCost *= 0.95;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
