/* VASIMRAZA H. BUKHARI 
 * Software System Development - Project 2
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project2
{
    public partial class aStockForm : Form
    {
        //Ticker 
        //variable to store starting date
        private string startDate;
        //varibale to store ending date
        private string endDate;
        //variable to store string for daily, weekly, or monthly radio button
        private string dwmRadio;
        //variable to store lowest stock
        private double lowest = double.MaxValue;
        //variable to store highest stock
        private double highest = double.MinValue;
        //generating series for candlestick chart
        private Series candleStickSeries = new Series();


        public aStockForm()
        {
            InitializeComponent();

            //setting starting max date (Today)'s date - 2 days
            startdateTimePicker.MaxDate = DateTime.Today.AddDays(-1);
            //setting ending max date (Today)'s date
            enddateTimePicker.MaxDate = DateTime.Today;
            //Determine if its a weekend, if weekend it set back to weekdays
            if (startdateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday || enddateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                startdateTimePicker.Value = startdateTimePicker.Value.AddDays(-1);
                enddateTimePicker.Value = enddateTimePicker.Value.AddDays(-1);
            }
            else if (startdateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday || enddateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                startdateTimePicker.Value = startdateTimePicker.Value.AddDays(-2);
                enddateTimePicker.Value = enddateTimePicker.Value.AddDays(-2);
            }
            //fixed single line border for aStockForm form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this allow user to use enter key for go button
            this.AcceptButton = this.goButton;
        }

        private void startdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //set startDate to starttimepicker of date string representaton
            startDate = this.startdateTimePicker.Value.ToShortDateString();
            //Compare startDate with endDate
            //if datetime compare return < 0, it change enddateTimepicker value to startdateTimePicker value
            if (DateTime.Compare(this.enddateTimePicker.Value, this.startdateTimePicker.Value) < 0) 
            {
                this.enddateTimePicker.Value = this.startdateTimePicker.Value.AddDays(1);
            }   
            //if its a weekend change startdateTimePicker value to preveious weekdays
            if (startdateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday) 
            {
                startdateTimePicker.Value = startdateTimePicker.Value.AddDays(-1);
            }
            else if (startdateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                startdateTimePicker.Value = startdateTimePicker.Value.AddDays(-2);
            }
        }

        private void enddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //set endDate to endtimepicker of date string representaton
            endDate = enddateTimePicker.Value.ToShortDateString();
            //Compare startDate with endDate
            //if datetime compare return < 0, it change enddateTimepicker value to startdateTimePicker value
            if (DateTime.Compare(this.enddateTimePicker.Value, this.startdateTimePicker.Value) < 0)
            {
                this.enddateTimePicker.Value = this.startdateTimePicker.Value.AddDays(-1);
            }
            //if its a weekend change startdateTimePicker value to preveious weekdays
            if (enddateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                enddateTimePicker.Value = enddateTimePicker.Value.AddDays(-1);
            }
            else if (enddateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                enddateTimePicker.Value = enddateTimePicker.Value.AddDays(-2);
            }
        }
        //If Daily Radio button selected, this method will be called
        private void dailyradioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.dwmRadio = "d";
        }
        //If Weekly Radio button selected, this method will be called
        private void weeklyradioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.dwmRadio = "w";
        }
        //If Monthly Radio button selected, this method will be called
        private void monthlyradioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.dwmRadio = "m";
        }
        //This method execute when Go Button Clicked
        private void goButton_Click(object sender, EventArgs e)
        {
            //First it check if ticket textbox is null or with empty space
            if (String.IsNullOrWhiteSpace(tickertextBox.Text))
            {
                MessageBox.Show("Please Enter Valid Ticker. (Ticker is either Null or empty WhiteSpace)");
                goto err;
            }
            //Split the starting date and set it to startDateSplit string array 
            string[] startDateSplit = startDate.Split('/');
            //Parse the first index of startDateSplit string array to integer and set startingMonth
            int startingMonth;
            int.TryParse(startDateSplit[0], out startingMonth);
            //Split the ending date and set it to endDateSplit string array
            string[] endDateSplit = endDate.Split('/');
            //Parse the first index of endDateSplit string array to integer and set endingMonth
            int endingMonth;
            int.TryParse(endDateSplit[0], out endingMonth);

            //now using starting and ending date, find stock detail of ticker
            //setup the url of ticker from yahoo finance 
            string url = "http://ichart.finance.yahoo.com/table.csv?s=" + tickertextBox.Text + "&a=" + (startingMonth - 1).ToString()
                + "&b=" + startDateSplit[1] + "&c=" + startDateSplit[2] + "&d=" + (endingMonth - 1).ToString() + "&e=" + endDateSplit[1]
                + "&f=" + endDateSplit[2] + dwmRadio + "&ignore=.csv";
            //MessageBox.Show(url);
            //temporary string variable to store result from yahoo finance
            string data = null;
            //store each line
            string[] rows = null;
            //trying reading from yahoo finance url
            try
            {
                WebClient wc = new WebClient(); //Created instance of WebClient
                data = wc.DownloadString(url);  //Download data as string from url 
                rows = data.Split('\n');
                //MessageBox.Show(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //check to see if rows is empty or null
            if (rows == null)
            {
                MessageBox.Show("No Data found for " + tickertextBox.Text + ". (Please check the name or date of ticker!)");
                goto err;
            }

            //date List variable to store all dates
            var dateData = new List<DateTime>();
            //open List variable to store all open data 
            var openData = new List<double>();
            //high List varriable to store all high data
            var highData = new List<double>();
            //low List variable to store all low data
            var lowData = new List<double>();
            //close List variable to store all close data
            var closeData = new List<double>();
            //volume List variable to store all volume data
            var volumeData = new List<Int32>();
            //Adj_close List variable to store all Adj Close data
            var adjCloseData = new List<double>();

            //Initially clear all list if there is any data in them
            openData.Clear();
            highData.Clear();
            lowData.Clear();
            closeData.Clear();
            volumeData.Clear();
            adjCloseData.Clear();

            //Create and Initialize new instance of the List<aCandlestick> class
            List<aCandlestick> acandleStick = new List<aCandlestick>();
            for (int i = 0; i < rows.Length - 1; i++) 
            {
                if (i != 0) 
                {
                    //Split each rows where it seperated by comma
                    string[] stockData = rows[i].Split(',');
                    //Convert to string to correcnt formate
                    dateData.Add(Convert.ToDateTime(stockData[0])); 
                    openData.Add(Convert.ToDouble(stockData[1]));
                    highData.Add(Convert.ToDouble(stockData[2]));
                    lowData.Add(Convert.ToDouble(stockData[3]));
                    closeData.Add(Convert.ToDouble(stockData[4]));
                    volumeData.Add(Convert.ToInt32(stockData[5]));
                    
                    //Adding data to instance of List<aCandlestick> class
                    acandleStick.Add(new aCandlestick(Convert.ToDateTime(stockData[0]), Convert.ToDecimal(stockData[1]),
                        Convert.ToDecimal(stockData[2]), Convert.ToDecimal(stockData[3]), Convert.ToDecimal(stockData[4]),
                        Convert.ToInt32(stockData[5]), Convert.ToDecimal(stockData[6])));

                }
            }

            //calculating highest and lowest stock
            lowest = lowData.Min();
            highest = highData.Max();

            //adding to datagidview from acandleStick 
            dataGridView.DataSource = acandleStick;

            dataGridView.AutoResizeColumn(0);
            dataGridView.AutoResizeColumn(1);
            dataGridView.AutoResizeColumn(2);
            dataGridView.AutoResizeColumn(3);
            dataGridView.AutoResizeColumn(4);
            dataGridView.AutoResizeColumn(5);
                        
            diplayCandlestickChart(dateData, openData, highData, lowData, closeData);


        err:
            Console.WriteLine();
        }

        private void diplayCandlestickChart(List<DateTime> dateData, List<double> openData, List<double> highData, List<double> lowData, List<double> closeData) 
        {
            //Initialy clear the chart if any object
            this.candleStickChart.Series.Remove(candleStickSeries);
            //Creating new series and candlestick chart
            candleStickSeries = new Series();
            candleStickSeries.ChartType = SeriesChartType.Candlestick;
            candleStickChart.Series.Add(candleStickSeries);
            //set Axis according to high and low value
            this.candleStickChart.ChartAreas[0].AxisY.Minimum = lowest;
            this.candleStickChart.ChartAreas[0].AxisY.Maximum = highest;

            //int temp = openData.Count()-1;
            for (int i = openData.Count() - 1; i >= 0; i--)
            {
                candleStickSeries.Points.AddXY(dateData[i], openData[i], highData[i], lowData[i], closeData[i]);
            }
            
            this.candleStickChart.Series[0].XValueType = ChartValueType.Date;
            this.candleStickChart.Series[0].Color = Color.DarkBlue;

            this.candleStickChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            this.candleStickChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            this.candleStickSeries.BorderWidth = 1;
            this.candleStickChart.Series[0].CustomProperties = "MaxPixelPointWidth=20";
            this.candleStickChart.Series[0].ToolTip = "High:#VALY1, Low:#VALY2, Open:#VALY3, Close:#VALY4";

            this.candleStickChart.Series[0]["PriceUpColor"] = "Green";
            // pricedownsolor
            this.candleStickChart.Series[0]["PriceDownColor"] = "Red";

        }
    }
}
