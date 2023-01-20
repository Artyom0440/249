using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor.checkChangeColor(255, "r", this, checkBox1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor.checkChangeColor(255, "g", this, checkBox2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor.checkChangeColor(255, "b", this, checkBox3);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sI = listBox1.SelectedIndex;

            if (sI == 0)
            {
                ChangeColor.listChangeColor(255, "r", this);
            }
            if (sI == 1)
            {
                ChangeColor.listChangeColor(255, "g", this);
            }
            if (sI == 2)
            {
                ChangeColor.listChangeColor(255, "b", this);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor.radioChangeTextIco(this, radioButton1.Text, Properties.Resources.Icon1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor.radioChangeTextIco(this, radioButton2.Text, Properties.Resources._1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor.radioChangeTextIco(this, radioButton3.Text, Properties.Resources._2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sI = comboBox1.SelectedIndex;

            if(sI == 0)
            {
                ChangeColor.comboChangeTextIco(this, "text1", Properties.Resources._3);
            }
            if (sI == 1)
            {
                ChangeColor.comboChangeTextIco(this, "text2", Properties.Resources._4);
            }
            if (sI == 2)
            {
                ChangeColor.comboChangeTextIco(this, "text3", Properties.Resources._5);
            }
        }
    }
}
