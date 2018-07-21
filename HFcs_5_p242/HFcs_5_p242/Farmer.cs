using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFcs_5_p242
{
    class Farmer
    {
        private int bagsOfFood;
        public int foodMultiplier;
        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                bagsOfFood = foodMultiplier * NumberOfCows;             
            }
        }
        public int BagsOfFood
        {                  
            get
            {
                return bagsOfFood;
            }
            set {
                
            }
        }
      
    }
    
}
