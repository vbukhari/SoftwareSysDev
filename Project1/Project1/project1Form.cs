using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class project1Form : Form
    {
        public project1Form()
        {
            InitializeComponent();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            int? seed;
            try
            {
                seed = int.Parse(seednum.Text.ToString());
            }
            catch (Exception ex)
            {
                seed = null;
            }
            aDie die = new aDie(seed);
            int face1 = 0; int face2 = 0; int face3 = 0; int face4 = 0; int face5 = 0; int face6 = 0;
            for (int i = 0; i < int.Parse(numRolls.Text.ToString()); ++i)
            {
                //MessageBox.Show(die.roll().ToString());
                switch (die.roll()) 
                {
                    case 1:
                        face1++;
                        break;
                    case 2:
                        face2++;
                        break;
                    case 3:
                        face3++;
                        break;
                    case 4:
                        face4++;
                        break;
                    case 5:
                        face5++;    
                        break;  
                    case 6:
                        face6++;
                        break;

                }
            }
            MessageBox.Show(" 1:" + face1.ToString() + " 2:" + face2.ToString() + " 3:" + face3.ToString() + " 4:" + face4.ToString() + " 5:" + face5.ToString() + " 6:" + face6.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wprin");
        }
    }
}
