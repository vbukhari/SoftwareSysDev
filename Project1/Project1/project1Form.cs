﻿using System;
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

namespace Project1
{
    public partial class project1Form : Form
    {
        // creating instance of Series for histogram
        private Series series = new Series();
        public project1Form()
        {
            InitializeComponent();
            this.chart1.ChartAreas[0].AxisY.IntervalOffsetType = DateTimeIntervalType.Number;
            this.AutoScroll = true;
        }
        //Global variable for counting number of rolls of a die
        private static int NumRolls = 0;
        //private int nSeed = 0;
        //Go button function: when go click this function execute
        private void GoBtn_Click(object sender, EventArgs e)
        {
            int nRolls = 0;
            //bool result = int.TryParse(this.numRolls.Text.ToString(), out nRolls);
            //Check to see if textbox for number of rolls is empty
            if (string.IsNullOrEmpty(this.numRolls.Text) || string.IsNullOrWhiteSpace(this.numRolls.Text) || !int.TryParse(this.numRolls.Text.ToString(), out nRolls) || Regex.Matches(seednum.Text, @"[a-zA-Z]").Count !=0)
            {
                MessageBox.Show("Invalid input, Please Enter integer value for input!");   //Throw this message if empty
            }
            else
            {
                //Check if diplay each radio button is seletected
                //When display each is selected it enable continue button, disapble go button
                if (displayEach.Checked)
                {
                    this.continueRoll.Enabled = true;   //Enable the continue roll button
                    this.goButton.Enabled = false;      //Disable the go button
                    this.continueRoll.PerformClick();   //perform continue button
                }
                //else if (!int.TryParse(this.seednum.Text.ToString(), out nSeed))
                //{
                //    MessageBox.Show("Invalid input");   //Throw this message if empty
                //}
                else
                {
                    int? seed;  //create integer variable seed

                    //try initializing seed value from seed number textbox
                    try
                    {
                        seed = int.Parse(seednum.Text.ToString());
                    }
                    //initialize seed varibale to NULL if seed number textbox is empty
                    catch (Exception ex)
                    {
                        seed = null;
                    }



                    //Create die instance of class aDie
                    aDie die = new aDie(seed);

                    var ffg = new List<FirstFiveGames>();

                    int wins = 0;       // hold number of wins
                    int loses = 0;      // number of loses

                    int die1TotalSum = 0;
                    int die2TotalSum = 0;

                    // loop over number of games
                    int i = 0;
                    while ( i < nRolls )
                    {
                        List<string> temp = new List<string>();
                        while (true)
                        {
                            int _die1 = die.roll();
                            int _die2 = die.roll();

                            int sumDie = _die1 + _die2; // current sum

                            die1TotalSum += _die1;      // total die 1 roll sum
                            die2TotalSum += _die2;

                            if (sumDie == 7 || sumDie == 11)
                            {
                                // first 5 games
                                if (i < 5)
                                {
                                    temp.Add("You rolled " + _die1 +" and "+ _die2+" for a total of "+ sumDie +" You WIN!");
                                }

                                wins++;     // increase win by 1

                                // other stuff

                                // add items to list for graphs
                                // 

                                break;// go to next game
                            }
                            else if (sumDie == 2 || sumDie == 3 || sumDie == 12)
                            {
                                // first 5 games
                                if (i < 5)
                                {
                                    temp.Add("You rolled " + _die1 + " and " + _die2 + " for a total of " + sumDie + " You LOSE!");
                                }

                                loses++; // increase lose by 1

                                // end current game
                                break;
                            }
                            else if (sumDie == 9 || sumDie == 10 || sumDie == 4 || sumDie == 5 || sumDie == 6)
                            {
                                // first 5 games
                                if (i < 5)
                                {
                                    temp.Add("You rolled " + _die1 + " and " + _die2 + " for a total of " + sumDie + " Roll Again!");
                                }
                                // cont playing current game


                            }
                        }

                        if (i<5)
                            ffg.Add(new FirstFiveGames { rollList = temp });
                        // next game
                        i++;
                    }

                    StringBuilder sb = new StringBuilder();
                    for(int k = 0; k < ffg.Count(); k++)
                    {
                        // Game 1 Started
                        sb.Append("Game " + (k + 1) + " Started\n");
                        foreach (var j in ffg.ElementAt(k).rollList)
                        {
                            sb.Append(j+"\n");
                        }

                        // Game 1 Ended
                        sb.Append("Game " + (k + 1) + " Ended\n\n");
                    }

                    this.FirstFiveGames.Text = sb.ToString();


                    //create array of Faces
                    //int[] Faces = new int[7];
                    //generate random number with number of times that user specified in number of rolls textbox
                    //for (int i = 0; i < nRolls; ++i)//int.Parse(numRolls.Text.ToString()); ++i)
                    //{
                        //MessageBox.Show(die.roll().ToString());
                        //Use switch statement to increment each face with number of times its been roll
                    //    switch (die.roll())
                    //    {
                    //        case 1:
                    //            Faces[1]++;
                    //            break;
                    //        case 2:
                    //            Faces[2]++;
                    //            break;
                    //        case 3:
                    //            Faces[3]++;
                    //            break;
                    //        case 4:
                    //            Faces[4]++;
                    //            break;
                    //        case 5:
                    //            Faces[5]++;
                    //            break;
                    //        case 6:
                    //            Faces[6]++;
                    //            break;
                    //    }

                    //}
                    
                    //MessageBox.Show(" 1:" + face1.ToString() + " 2:" + face2.ToString() + " 3:" + face3.ToString() + " 4:" + face4.ToString() + " 5:" + face5.ToString() + " 6:" + face6.ToString());
                    
                    //generating column chart 

                    //this.chart1.Series.Remove(series);
                    //series = new Series();
                    //series.ChartType = SeriesChartType.Column;
                    //this.chart1.Series.Add(series);
                    //series.Name = "Number of Rolls";
                    //series.Points.AddXY("Face 1", Faces[1]);
                    //series.Points.AddXY("Face 2", Faces[2]);
                    //series.Points.AddXY("Face 3", Faces[3]);
                    //series.Points.AddXY("Face 4", Faces[4]);
                    //series.Points.AddXY("Face 5", Faces[5]);
                    //series.Points.AddXY("Face 6", Faces[6]);
                    //controlling Y value of column chart graph with face maximum value
                    //this.chart1.ChartAreas[0].AxisY.Maximum = Faces.Max();
                }
            }
        }
        //Clear button to clear each textbox and graph
        private void clearAll_Click(object sender, EventArgs e)
        {
            this.numRolls.Clear();
            this.chart1.Series.Clear();
            this.seednum.Clear();
        }

        private void project1Form_Load(object sender, EventArgs e)
        {

        }
        //creating static array for faces 
        //static int[] _Faces = new int[7];
        //Continue button to roll die one time
        //private void continueRoll_Click(object sender, System.EventArgs e)
        //{
        //    //disable number of rolls textbox while number of rolls perform each time
        //    this.numRolls.Enabled = false;
        //    //seed intger variable for users seed number enter 
        //    int? seed;
        //    //try initializing seed value from seed number textbox
        //    try
        //    {
        //        seed = int.Parse(seednum.Text.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        seed = null;
        //    }

        //    //Create die instance of class aDie
        //    aDie die = new aDie(seed);
        //    //creating column chart 
        //    this.chart1.Series.Remove(series);
        //    series = new Series();
        //    series.ChartType = SeriesChartType.Column;
        //    this.chart1.Series.Add(series);

        //        //MessageBox.Show(die.roll().ToString());
        //        //Use switch statement to increment each face with number of times its been roll
        //        switch (die.roll())
        //        {
        //            case 1:
        //                _Faces[1]++;
        //                break;
        //            case 2:
        //                _Faces[2]++;
        //                break;
        //            case 3:
        //                _Faces[3]++;
        //                break;
        //            case 4:
        //                _Faces[4]++;
        //                break;
        //            case 5:
        //                _Faces[5]++;
        //                break;
        //            case 6:
        //                _Faces[6]++;
        //                break;
        //        }

        //        series.Name = "Number of Rolls";
        //        series.Points.AddXY("Face 1", _Faces[1]);
        //        series.Points.AddXY("Face 2", _Faces[2]);
        //        series.Points.AddXY("Face 3", _Faces[3]);
        //        series.Points.AddXY("Face 4", _Faces[4]);
        //        series.Points.AddXY("Face 5", _Faces[5]);
        //        series.Points.AddXY("Face 6", _Faces[6]);
                
        //        NumRolls++;
        //        //controlling Y value of column chart graph with face maximum value
        //        this.chart1.ChartAreas[0].AxisY.Maximum = _Faces.Max();
        //        //initialize everything backto initial value when number of rolls finishes
        //        if (NumRolls == int.Parse(this.numRolls.Text.ToString()))
        //        {
        //            NumRolls = 0;
        //            Array.Clear(_Faces, 0, _Faces.Length);
        //            this.numRolls.Enabled = true;
        //            this.continueRoll.Enabled = false;
        //            this.goButton.Enabled = true;
        //            //this.numRolls.Clear();
        //        }

        //}


    }

}

