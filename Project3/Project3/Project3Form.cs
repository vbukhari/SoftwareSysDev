using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace Project3
{
    public partial class Project3Form : Form
    {
        public Project3Form()
        {
            InitializeComponent();
            this.chart1.ChartAreas[0].AxisY.IntervalOffsetType = DateTimeIntervalType.Number;
            this.AutoScorll = true;
        }


        private void goButton_Click(object sender, EventArgs e)
        {
            int numGames = 0;

            if (string.IsNullOrEmpty(this.nGames.Text) || string.IsNullOrWhiteSpace(this.nGames.Text) || !int.TryParse(this.nGames.Text.ToString(), out numGames) || Regex.Matches(seednum.Text, @"[a-zA-Z]").Count != 0)
            {
                MessageBox.Show("Invalid input, Please Enter integer value for input!");   //Throw this message if empty
            }
            else 
            {
                int? seed;
                try
                {
                    seed = int.Parse(seednum.Text.ToString());
                }
                catch(Exception ex)
                {
                    seed = null;
                }
                //Create die instance of class aDie
                aDie die = new aDie(seed);
                var ffg = new List<FirstFiveGame>();

                int wins = 0;   //holds number of wins
                int loses = 0;  //holds number of loses

                int die1TotalSum = 0; //holds total sum of die1
                int die2TotalSum = 0; //holds total sum of die2

                int i = 0;
                while (i < numGames) 
                {
                    List<string> temp = new List<string>();
                    while (true)
                    {
                        int _die1 = die.roll();
                        int _die2 = die.roll();
                        int sumDie = _die1 + _die2; //Current sum

                        die1TotalSum += _die1;
                        die2TotalSum += _die2;
                        
                    }
                }

            }
        }
    }
}
