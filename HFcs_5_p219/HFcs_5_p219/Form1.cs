using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFcs_5_p219
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty = new DinnerParty() { numberOfPeople=5};
        public Form1()
        {
            InitializeComponent();
            dinnerParty.CalculateCostDecorations(fancyBox.Checked);
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
            
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {
            double cost=dinnerParty.CalculateCost(healthyBox.Checked);
            label3.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();

        }
    }
}
