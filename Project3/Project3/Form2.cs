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

namespace Project2
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Take data passed from FrmMain(Form1) in order to  display the
        /// chart on this second form
        /// </summary>
        /// <param name="inStock">aStock object</param>
        /// <param name="stockName">Stock name, string</param>
        public void LoadInfo(aStock inStock, string stockName)
        {

            //Create DataTables to hold the data for binding purposes
            DataTable dataTable = new DataTable();

            //Add column names to dataTable
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Open");
            dataTable.Columns.Add("High");
            dataTable.Columns.Add("Low");
            dataTable.Columns.Add("Close");
            dataTable.Columns.Add("Volume");
            

            for (int i = 0; i < inStock.candlestick.Count; ++i )
            {
                //Create DataRow to add to DataTable
                DataRow row = dataTable.NewRow();

                row[0] = inStock.candlestick[i].StartingDate.ToShortDateString();
                row[1] = inStock.candlestick[i].Open;
                row[2] = inStock.candlestick[i].High;
                row[3] = inStock.candlestick[i].Low;
                row[4] = inStock.candlestick[i].Close;
                row[5] = inStock.candlestick[i].Volume;

                //Only use dates that are within the selected date range
                DateTime dtDate = inStock.candlestick[i].StartingDate;
                if (inStock.startingDate <= dtDate && dtDate <= inStock.endingDate)
                {
                    dataTable.Rows.Add(row);
                }
                    
            }
            //Set source for chart to be the created dataTable
            chrtStockData.DataSource = dataTable;

            //Set titles and text for each series
            chrtStockData.Series[0].XValueMember = "Date";
            chrtStockData.Series[0].YValueMembers = "High,Low,Open,Close";
            chrtStockData.Series[0].Name = stockName;
            chrtStockData.Series[0].LegendText = stockName;
            chrtStockData.Series[1].XValueMember = "Date";
            chrtStockData.Series[1].YValueMembers = "Volume";
            chrtStockData.Series[1].LegendText = "Volume";
            
            //Bind all the data to the chart
            chrtStockData.DataBind();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void chrtStockData_Click(object sender, EventArgs e)
        {

        }



        
    }
}
