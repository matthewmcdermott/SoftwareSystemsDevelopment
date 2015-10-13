namespace Project1
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTicker = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelDateRange = new System.Windows.Forms.Label();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Location = new System.Drawing.Point(13, 9);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(37, 13);
            this.labelTicker.TabIndex = 0;
            this.labelTicker.Text = "Ticker";
            this.labelTicker.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(92, 9);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(26, 13);
            this.labelRes.TabIndex = 1;
            this.labelRes.Text = "Res";
            // 
            // labelDateRange
            // 
            this.labelDateRange.AutoSize = true;
            this.labelDateRange.Location = new System.Drawing.Point(158, 9);
            this.labelDateRange.Name = "labelDateRange";
            this.labelDateRange.Size = new System.Drawing.Size(62, 13);
            this.labelDateRange.TabIndex = 2;
            this.labelDateRange.Text = "DateRange";
            // 
            // chartStock
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chartStock.ChartAreas.Add(chartArea1);
            this.chartStock.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chartStock.Legends.Add(legend1);
            this.chartStock.Location = new System.Drawing.Point(16, 29);
            this.chartStock.Name = "chartStock";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chartStock.Series.Add(series1);
            this.chartStock.Series.Add(series2);
            this.chartStock.Size = new System.Drawing.Size(790, 461);
            this.chartStock.TabIndex = 3;
            this.chartStock.Text = "chartStock";
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 502);
            this.Controls.Add(this.chartStock);
            this.Controls.Add(this.labelDateRange);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelTicker);
            this.Name = "FormChart";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label labelDateRange;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
    }
}