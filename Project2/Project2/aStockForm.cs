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
        

        //varibale for storing starting date
        private string startDate;
        //variable for storing ending date
        private string endDate;
        //variable for storing to display daily, weekly, or monthly chart 
        private string dwm;
        //variable for storing low stock
        double lowest = double.MaxValue;
        //variable for storing high stock
        double highest = double.MinValue; 
        //variable for storing average
        double average = 0;
        //variable for storing the sum 
        int sum = 0;
        //Creating new Series for chart
        private Series series = new Series();


        public aStockForm()
        {
            InitializeComponent();
            //Starting Date
            //This sets maximum date to current date (Today)
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(-2);
            //This determine if its weekend
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-2);
            }
            //Ending Date
            //This sets maximum date to current date (Today)
            dateTimePicker2.MaxDate = DateTime.Today;
            //This determine if its weekend
            if (dateTimePicker2.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                dateTimePicker2.Value = dateTimePicker2.Value.AddDays(-1);
            }
            else if (dateTimePicker2.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                dateTimePicker2.Value = dateTimePicker2.Value.AddDays(-2);
            }
            //Determine Form boarder style according to max and min value
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AcceptButton = button1;
            highest = double.MinValue; lowest = double.MaxValue;

        }

        private void aStockForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lowest = double.MaxValue;
            highest = double.MinValue;
            //This check if the ticket TextBox is empty or Null
            if (String.IsNullOrWhiteSpace(ticker.Text)) 
            {
                MessageBox.Show("Ticker is Empty"); goto end; 
            }
            //This set value for high and low
            this.low.Text = "Low: ";
            this.high.Text = "High: ";
            //This splits the starting date
            string[] start_temp = startDate.Split('/');
            //This splits the ending date
            string[] end_temp = endDate.Split('/');
            int startMonth; int.TryParse(start_temp[0], out startMonth);
            int endMonth; int.TryParse(end_temp[0], out endMonth); 

            //This finds the stock
            string url = "http://ichart.finance.yahoo.com/table.csv?s=" + ticker.Text + "&a=" + (startMonth - 1).ToString() +
                "&b=" + start_temp[1] + "&c=" + start_temp[2] + "&d=" + (endMonth - 1).ToString() + "&e=" + end_temp[1] + "&f=" + end_temp[2] + "&g=" + dwm + "&ignore=.csv";
            //varibale reads results from yahoo finance 
            string result = null;
            //store each line
            string[] line = null;

            try
            {
                //Creating instance of Webclient  
                WebClient client = new WebClient();
                //Storing downloaded string to result
                result = client.DownloadString(url);
                // split at new line
                line = result.Split('\n');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //variable to store high stock
            var highStock = new List<double>();
            //variable to store low stock
            var lowStock = new List<double>();
            //Open stock
            var open = new List<double>();
            // close stock
            var close = new List<double>();
            //variable to store date
            var date = new List<DateTime>();
            // variabel to store volume
            var volume = new List<Int32>();

            //This will clear all 
            highStock.Clear(); lowStock.Clear(); open.Clear(); close.Clear();

            //Creating instance of aCandlestick class List 
            List<aCandlestick> candlestick = new List<aCandlestick>(); 
            //Check if line is null, it skip the line
            if (line == null) { goto skip; }
            //Loop through the line to add to aCandlestick class list
            for (int i = 0; i < line.Length - 1; i++)
            {
                if (i == 0) { }
                else
                {
                    string[] stock = line[i].Split(',');
                    date.Add(Convert.ToDateTime(stock[0]));
                    open.Add(Convert.ToDouble(stock[1]));
                    highStock.Add(Convert.ToDouble(stock[2]));
                    lowStock.Add(Convert.ToDouble(stock[3]));
                    close.Add(Convert.ToDouble(stock[4]));
                    volume.Add(Convert.ToInt32(stock[5]));          
                    candlestick.Add(new aCandlestick(Convert.ToDateTime(stock[0]), Convert.ToDecimal(stock[1]),Convert.ToDecimal(stock[2]), 
                                                Convert.ToDecimal(stock[3]), Convert.ToDecimal(stock[4]), Convert.ToInt32(stock[5]), Convert.ToDecimal(stock[6])));
                }
            }

            //Finds the highest stock 
            highest = highStock.Max();
            //Finds the lowest stock
            lowest = lowStock.Min();
            //Finds the average close stock
            average = close.Average();
            //Finds round average to 2 decimal place
            average = Math.Round(average,2);
            //Finds the Sum of volume
            sum = volume.Sum();
            //Finds up Days
            var UpDays = candlestick.Where(x => x.Close > x.Open).ToList();
            //Add data to data to dataGridview1
            dataGridView1.DataSource = candlestick;

            //Add data to green sticks to updays
            dataGridView2.DataSource = UpDays;

            //Auto resize datagridview1
            dataGridView1.AutoResizeColumn(0);
            dataGridView1.AutoResizeColumn(1);
            dataGridView1.AutoResizeColumn(2);
            dataGridView1.AutoResizeColumn(3);
            dataGridView1.AutoResizeColumn(4);
            dataGridView1.AutoResizeColumn(5);

            //Auto resize datagridview2
            dataGridView2.AutoResizeColumn(0);
            dataGridView2.AutoResizeColumn(1);
            dataGridView2.AutoResizeColumn(2);
            dataGridView2.AutoResizeColumn(3);
            dataGridView2.AutoResizeColumn(4);
            dataGridView2.AutoResizeColumn(5);
            // update high stock
            this.high.Text += highest;
            // update low stock
            this.low.Text += lowest;
            // update avarage
            this.Average.Text += average;
            // update sum of volume
            this.volSum.Text += sum; 
            // plot candle stick
            plotChart(date,highStock, lowStock, open, close);
            //goto clause to skip line
            skip:
            // display error message
            if (line == null) {
                this.high.Text += "0";
                this.low.Text += "0";
                MessageBox.Show("Error Can not Found!\n Enter Valid Ticker or Valid Date"); 
            }
            //goto clause if the ticker is found empty
        end:
            int temp = 0;
        }


        private void plotChart(List<DateTime> date, List<double> high, List<double> low, List<double> open, List<double> close)
        {
            // remove series object from chart
            this.chart1.Series.Remove(series);
            // create new series object
            series = new Series();
            // add candlestick chart
            series.ChartType = SeriesChartType.Candlestick;
            // add series to chart
            this.chart1.Series.Add(series);
            //set lowest value
            this.chart1.ChartAreas[0].AxisY.Minimum = lowest;
            // set highest value
            this.chart1.ChartAreas[0].AxisY.Maximum = highest;

            // add data into chart
            for (int i = open.Count() - 1; i >= 0; i--)
            {
                series.Points.AddXY(date[i], high[i], low[i], open[i], close[i]);
            }
            // add series into chart
            this.chart1.Series[0].XValueType = ChartValueType.Date;
            // set color
            this.chart1.Series[0].Color = Color.DarkBlue;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            this.series.BorderWidth = 1; // set width 
            this.chart1.Series[0].CustomProperties = "MaxPixelPointWidth=20";
            this.chart1.Series[0].ToolTip = "High:#VALY1, Low:#VALY2, Open:#VALY3, Close:#VALY4";
            // priceupcolor
            this.chart1.Series[0]["PriceUpColor"] = "Green";
            // pricedownsolor
            this.chart1.Series[0]["PriceDownColor"] = "Red";
        }

        //starting date method
        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            // get selected date
            startDate = this.dateTimePicker1.Value.ToShortDateString();
            // compare start date and end date
            int compare = DateTime.Compare(this.dateTimePicker2.Value, this.dateTimePicker1.Value);
            //if compare return -1 then set end date to start date
            if (compare < 0)
            {
                this.dateTimePicker2.Value = this.dateTimePicker1.Value.AddDays(1);
            }

            // detect if its weekend
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-2);
            }
        }
        //Ending date method
        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            // get selected date
            endDate = this.dateTimePicker2.Value.ToShortDateString();
            // compare start date and end date
            int compare = DateTime.Compare(this.dateTimePicker2.Value, this.dateTimePicker1.Value);
            // compare is -1 then set start date -1 date
            if (compare < 0)
            {
                this.dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-1);
            }

            // detect if its weekend
            if (dateTimePicker2.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                dateTimePicker2.Value = dateTimePicker2.Value.AddDays(-1);
            }
            else if (dateTimePicker2.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                dateTimePicker2.Value = dateTimePicker2.Value.AddDays(-2);
            }
        }

        //if user select weekly radio button
        private void Weekly_CheckedChanged(object sender, EventArgs e)
        {
            dwm = "w";
        }
        //If user select monthly radio button
        private void Monthly_CheckedChanged(object sender, EventArgs e)
        {
            dwm = "m";
        }
        //if user select daily raido button
        private void Daily_CheckedChanged(object sender, EventArgs e)
        {
            dwm = "d";
        }

    }
}
