using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFcs_4_p186
{
    public partial class Form1 : Form
    {

        public class Elephant
        {
            public int privateSize;
            public string Name;
            public void WhoAmI()
            {
                MessageBox.Show("I'm " + Name + "and my earsize is: " + privateSize);
            }
        }

        Elephant hb;
        Elephant aj;

        public Form1()
        {
            InitializeComponent();
            hb=new Elephant()
            {
                privateSize=10, 
                Name="小黄孛"
            };
            aj = new Elephant()
            {
                privateSize = 10,
                Name = "小阿鸡"
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.我是:" + hb.Name + "鸡鸡" + hb.privateSize + "cm!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2.我是:" + aj.Name + "**" + aj.privateSize + "**!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant temp = new Elephant();
            temp = hb;
            hb = aj;
            aj = temp;
            MessageBox.Show("1.我是:" + hb.Name + "鸡鸡" + hb.privateSize + "cm!");
            MessageBox.Show("2.我是:" + aj.Name + "**" + aj.privateSize + "**!");

        }
    }
}
