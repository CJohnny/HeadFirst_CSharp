using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFcs_5_p242
{
    public partial class Form1 : Form
    {
        Farmer farmer = new Farmer() { foodMultiplier=20,BagsOfFood=20};
       
        public Form1()
        {
            InitializeComponent();
            //Farmer farmer = new Farmer();
            //farmer.foodMultiplier = 20:
        }

        private void button1_Click(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
            //MessageBox.Show("需要 "+farmer.BagsOfFood+"包饲料");
            Console.WriteLine("需要 {0} 包饲料", farmer.BagsOfFood);
        }
    }
}
