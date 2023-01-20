using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    class ChangeColor
    {
        static int r = 0;
        static int g = 0;
        static int b = 0;

        static public void checkChangeColor(int a, string type, Form1 fm1, CheckBox cb)
        {
            if(type == "r" & cb.Checked == true)
            {
                r = a;
                fm1.BackColor = System.Drawing.Color.FromArgb(r,g,b);
            }
            else if(type == "r" & cb.Checked == false)
            {
                r = 0;
                fm1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            }

            if (type == "g" & cb.Checked == true)
            {
                g = a;
                fm1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            }
            else if (type == "g" & cb.Checked == false)
            {
                g = 0;
                fm1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            }

            if (type == "b" & cb.Checked == true)
            {
                b = a;
                fm1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            }
            else if (type == "b" & cb.Checked == false)
            {
                b = 0;
                fm1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            }
        }
        static public void listChangeColor(int a, string type, Form1 fm1)
        {
            if(type == "r")
            {
                r = a;
                g = 0;
                b = 0;
         
                fm1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            }
            if (type == "g")
            {
                r = 0;
                g = a;
                b = 0;
                fm1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            }
            if (type == "b")
            {
                r = 0;
                g = 0;
                b = a;
                fm1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            }
        }
        static public void radioChangeTextIco(Form fm1, string txt, System.Drawing.Icon ico)
        {
            fm1.Text = txt;
            fm1.Icon = ico;
        }
        static public void comboChangeTextIco(Form fm1, string txt, System.Drawing.Icon ico)
        {
            fm1.Text = txt;
            fm1.Icon = ico;
        }
    }
}
