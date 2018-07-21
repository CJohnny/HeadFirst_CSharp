using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFcs_6_p253
{
    class BirthdatParty
    {
        private int numberOfPeople;
        private double costOfDecorations;
        private int cakeSize;
        private string cakeWriting;
        private const double costOfFoodPerPerson=25;
        private bool fancyDecoration;

        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecoration);
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }
        public double CostOfDecorations
        {
            get
            {
                return costOfDecorations;
            }
            set
            {
                costOfDecorations = value;
            }
        }
        public int CakeSize
        {
            get
            {
                return cakeSize;
            }
            set
            {
                cakeSize = value;
            }
        }
        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength;
                if (CakeSize==8)
                {
                    maxLength = 16;
                }
                else
                {
                    maxLength = 40;
                }
                if (value.Length > maxLength)
                {
                    MessageBox.Show("要写的字太多了！超出了"+CakeSize+"号蛋糕的规定！");
                    if (maxLength > this.cakeWriting.Length)
                    {
                        maxLength = this.cakeWriting.Length;
                        this.cakeWriting = cakeWriting.Substring(0, maxLength);
                    }
                }
                else
                {
                    this.cakeWriting = value;
                }
            }
        }

        public BirthdatParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecoration = fancyDecorations;
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecoration);
        }
        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }
        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecoration = fancy;
            if (fancy)
                CostOfDecorations = NumberOfPeople * 15 + 50;
            else
                CostOfDecorations = NumberOfPeople * 7.5 + 30;
        }
        public decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (costOfFoodPerPerson * NumberOfPeople);
        }

    }
}
