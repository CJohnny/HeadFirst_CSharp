using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFcs_4_p130
{
  

    public partial class Form1 : Form
    {
        float startingMileage;
        float endingMileage;
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("起始里程不应大于结束里程");
            }
            else
            {
                milesTraveled = (double)numericUpDown2.Value - (double)numericUpDown1.Value;
                amountOwed = reimburseRate * milesTraveled;
                label4.Text = "￥" + amountOwed;
            }

            //decimal mydecimalvalue = 10;
            //int myintvalue = (int)mydecimalvalue;

            //messagebox.show("the myintvalue is" + myintvalue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //milesTraveled = (double)numericUpDown2.Value - (double)numericUpDown1.Value;
            label5.Text = milesTraveled + "KM";

            //MessageBox.Show("Kilos traveled:" + milesTraveled);
        }
    }
}
