﻿namespace Project1
{
    partial class project1Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numRolls = new System.Windows.Forms.TextBox();
            this.seednum = new System.Windows.Forms.TextBox();
            this.displayEach = new System.Windows.Forms.RadioButton();
            this.diplayAll = new System.Windows.Forms.RadioButton();
            this.goButton = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.continueRoll = new System.Windows.Forms.Button();
            this.FirstFiveGames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MyDie Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Die Rolls: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seed Number: ";
            // 
            // numRolls
            // 
            this.numRolls.Location = new System.Drawing.Point(166, 72);
            this.numRolls.Name = "numRolls";
            this.numRolls.Size = new System.Drawing.Size(41, 20);
            this.numRolls.TabIndex = 3;
            // 
            // seednum
            // 
            this.seednum.Location = new System.Drawing.Point(140, 113);
            this.seednum.Name = "seednum";
            this.seednum.Size = new System.Drawing.Size(41, 20);
            this.seednum.TabIndex = 4;
            // 
            // displayEach
            // 
            this.displayEach.AutoSize = true;
            this.displayEach.Location = new System.Drawing.Point(59, 161);
            this.displayEach.Name = "displayEach";
            this.displayEach.Size = new System.Drawing.Size(108, 17);
            this.displayEach.TabIndex = 5;
            this.displayEach.TabStop = true;
            this.displayEach.Text = "Display Each Roll";
            this.displayEach.UseVisualStyleBackColor = true;
            // 
            // diplayAll
            // 
            this.diplayAll.AutoSize = true;
            this.diplayAll.Location = new System.Drawing.Point(59, 197);
            this.diplayAll.Name = "diplayAll";
            this.diplayAll.Size = new System.Drawing.Size(99, 17);
            this.diplayAll.TabIndex = 6;
            this.diplayAll.TabStop = true;
            this.diplayAll.Text = "Display All Rolls";
            this.diplayAll.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(26, 241);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(96, 42);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(56, 303);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(151, 37);
            this.clearAll.TabIndex = 8;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(270, 50);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(600, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // continueRoll
            // 
            this.continueRoll.Enabled = false;
            this.continueRoll.Location = new System.Drawing.Point(140, 241);
            this.continueRoll.Name = "continueRoll";
            this.continueRoll.Size = new System.Drawing.Size(96, 42);
            this.continueRoll.TabIndex = 10;
            this.continueRoll.Text = "Continue Rolling";
            this.continueRoll.UseVisualStyleBackColor = true;
            // 
            // FirstFiveGames
            // 
            this.FirstFiveGames.AutoSize = true;
            this.FirstFiveGames.Location = new System.Drawing.Point(23, 378);
            this.FirstFiveGames.Name = "FirstFiveGames";
            this.FirstFiveGames.Size = new System.Drawing.Size(0, 13);
            this.FirstFiveGames.TabIndex = 11;
            // 
            // project1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 666);
            this.Controls.Add(this.FirstFiveGames);
            this.Controls.Add(this.continueRoll);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.diplayAll);
            this.Controls.Add(this.displayEach);
            this.Controls.Add(this.seednum);
            this.Controls.Add(this.numRolls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "project1Form";
            this.Text = "MyDie - Roll it On!";
            this.Load += new System.EventHandler(this.project1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numRolls;
        private System.Windows.Forms.TextBox seednum;
        private System.Windows.Forms.RadioButton displayEach;
        private System.Windows.Forms.RadioButton diplayAll;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button continueRoll;
        private System.Windows.Forms.Label FirstFiveGames;
    }
}