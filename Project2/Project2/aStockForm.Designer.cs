namespace Project2
{
    partial class aStockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ticker_label = new System.Windows.Forms.Label();
            this.start_date_label = new System.Windows.Forms.Label();
            this.end_date_label = new System.Windows.Forms.Label();
            this.tickertextBox = new System.Windows.Forms.TextBox();
            this.startdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.goButton = new System.Windows.Forms.Button();
            this.dailyradioButton = new System.Windows.Forms.RadioButton();
            this.weeklyradioButton = new System.Windows.Forms.RadioButton();
            this.monthlyradioButton = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.candleStickChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candleStickChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ticker_label
            // 
            this.ticker_label.AutoSize = true;
            this.ticker_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticker_label.Location = new System.Drawing.Point(73, 50);
            this.ticker_label.Name = "ticker_label";
            this.ticker_label.Size = new System.Drawing.Size(72, 19);
            this.ticker_label.TabIndex = 0;
            this.ticker_label.Text = "Ticker:";
            // 
            // start_date_label
            // 
            this.start_date_label.AutoSize = true;
            this.start_date_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.Location = new System.Drawing.Point(43, 100);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.Size = new System.Drawing.Size(117, 19);
            this.start_date_label.TabIndex = 1;
            this.start_date_label.Text = "Start Date: ";
            // 
            // end_date_label
            // 
            this.end_date_label.AutoSize = true;
            this.end_date_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.Location = new System.Drawing.Point(61, 147);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.Size = new System.Drawing.Size(99, 19);
            this.end_date_label.TabIndex = 2;
            this.end_date_label.Text = "End Date: ";
            // 
            // tickertextBox
            // 
            this.tickertextBox.Location = new System.Drawing.Point(171, 51);
            this.tickertextBox.Name = "tickertextBox";
            this.tickertextBox.Size = new System.Drawing.Size(200, 20);
            this.tickertextBox.TabIndex = 3;
            this.tickertextBox.Text = "YHOO";
            // 
            // startdateTimePicker
            // 
            this.startdateTimePicker.Location = new System.Drawing.Point(171, 100);
            this.startdateTimePicker.Name = "startdateTimePicker";
            this.startdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startdateTimePicker.TabIndex = 4;
            this.startdateTimePicker.ValueChanged += new System.EventHandler(this.startdateTimePicker_ValueChanged);
            // 
            // enddateTimePicker
            // 
            this.enddateTimePicker.Location = new System.Drawing.Point(171, 147);
            this.enddateTimePicker.Name = "enddateTimePicker";
            this.enddateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.enddateTimePicker.TabIndex = 5;
            this.enddateTimePicker.ValueChanged += new System.EventHandler(this.enddateTimePicker_ValueChanged);
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(155, 249);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(142, 38);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // dailyradioButton
            // 
            this.dailyradioButton.AutoSize = true;
            this.dailyradioButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyradioButton.Location = new System.Drawing.Point(77, 203);
            this.dailyradioButton.Name = "dailyradioButton";
            this.dailyradioButton.Size = new System.Drawing.Size(72, 23);
            this.dailyradioButton.TabIndex = 7;
            this.dailyradioButton.TabStop = true;
            this.dailyradioButton.Text = "Daily";
            this.dailyradioButton.UseVisualStyleBackColor = true;
            this.dailyradioButton.CheckedChanged += new System.EventHandler(this.dailyradioButton_CheckedChanged);
            // 
            // weeklyradioButton
            // 
            this.weeklyradioButton.AutoSize = true;
            this.weeklyradioButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyradioButton.Location = new System.Drawing.Point(188, 203);
            this.weeklyradioButton.Name = "weeklyradioButton";
            this.weeklyradioButton.Size = new System.Drawing.Size(81, 23);
            this.weeklyradioButton.TabIndex = 8;
            this.weeklyradioButton.TabStop = true;
            this.weeklyradioButton.Text = "Weekly";
            this.weeklyradioButton.UseVisualStyleBackColor = true;
            this.weeklyradioButton.CheckedChanged += new System.EventHandler(this.weeklyradioButton_CheckedChanged);
            // 
            // monthlyradioButton
            // 
            this.monthlyradioButton.AutoSize = true;
            this.monthlyradioButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyradioButton.Location = new System.Drawing.Point(311, 203);
            this.monthlyradioButton.Name = "monthlyradioButton";
            this.monthlyradioButton.Size = new System.Drawing.Size(90, 23);
            this.monthlyradioButton.TabIndex = 9;
            this.monthlyradioButton.TabStop = true;
            this.monthlyradioButton.Text = "Monthly";
            this.monthlyradioButton.UseVisualStyleBackColor = true;
            this.monthlyradioButton.CheckedChanged += new System.EventHandler(this.monthlyradioButton_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(448, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(599, 237);
            this.dataGridView.TabIndex = 10;
            // 
            // candleStickChart
            // 
            chartArea1.Name = "ChartArea1";
            this.candleStickChart.ChartAreas.Add(chartArea1);
            this.candleStickChart.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Name = "Legend1";
            this.candleStickChart.Legends.Add(legend1);
            this.candleStickChart.Location = new System.Drawing.Point(47, 332);
            this.candleStickChart.Name = "candleStickChart";
            this.candleStickChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.candleStickChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.candleStickChart.Size = new System.Drawing.Size(1000, 312);
            this.candleStickChart.TabIndex = 11;
            this.candleStickChart.Text = "chart";
            this.candleStickChart.Enter += new System.EventHandler(this.goButton_Click);
            // 
            // aStockForm
            // 
            this.ClientSize = new System.Drawing.Size(1096, 673);
            this.Controls.Add(this.candleStickChart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.monthlyradioButton);
            this.Controls.Add(this.weeklyradioButton);
            this.Controls.Add(this.dailyradioButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.enddateTimePicker);
            this.Controls.Add(this.startdateTimePicker);
            this.Controls.Add(this.tickertextBox);
            this.Controls.Add(this.end_date_label);
            this.Controls.Add(this.start_date_label);
            this.Controls.Add(this.ticker_label);
            this.Name = "aStockForm";
            this.Text = "Yahoo! Finance ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candleStickChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ticker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton Daily;
        private System.Windows.Forms.RadioButton Weekly;
        private System.Windows.Forms.RadioButton Monthly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ticker_label;
        private System.Windows.Forms.Label start_date_label;
        private System.Windows.Forms.Label end_date_label;
        private System.Windows.Forms.TextBox tickertextBox;
        private System.Windows.Forms.DateTimePicker startdateTimePicker;
        private System.Windows.Forms.DateTimePicker enddateTimePicker;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.RadioButton dailyradioButton;
        private System.Windows.Forms.RadioButton weeklyradioButton;
        private System.Windows.Forms.RadioButton monthlyradioButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart candleStickChart;
    }
}

