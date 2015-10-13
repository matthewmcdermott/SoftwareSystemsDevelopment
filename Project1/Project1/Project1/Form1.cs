using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the Go! button is clicked, it will either download new data or
        /// display the current data.
        /// If data is downloaded it is stored in the fileName variable's value.
        /// If data is displayed it is put in a candlestick chart by date as 
        /// specified in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            //retrieve stock ticker from combobox
            var stockTicker = comboBoxStockTicker.SelectedItem;

            //handle empty stock ticker
            if (stockTicker == null)
            {
                MessageBox.Show("You Must Select a Stock Ticker", "Action Required",
                    MessageBoxButtons.OK);
                return;
            }

            //retrieve start date and end date information from datepickers
            string startMonth = (dateTimePickerStart.Value.Month - 1).ToString();
            string startDate = dateTimePickerStart.Value.Date.ToString("dd");
            string startYear = dateTimePickerStart.Value.Year.ToString();
            string endMonth = (dateTimePickerEnd.Value.Month - 1).ToString();
            string endDate = dateTimePickerEnd.Value.Date.ToString("dd");
            string endYear = dateTimePickerEnd.Value.Year.ToString();
            
            //get resolution from radio buttons
            string resolution = "";
            string res = ""; //stored variable for future use with webClient
            if (radioButtonDaily.Checked)
            {
                resolution = "d";
                res = "Daily";
            }
            else if (radioButtonWeekly.Checked)
            {
                resolution = "w";
                res = "Weekly";
            }
            else if (radioButtonMonthly.Checked)
            {
                resolution = "m";
                res = "Monthly";
            }
            else
            {
                MessageBox.Show("Select a Resolution", "Action Required",
                    MessageBoxButtons.OK);
                return;
            }

            //declare working directory and file name
            const string workingDir = "C:\\DEV\\STOCKDATA\\";
            string fileName = workingDir + res + "\\" +
                    stockTicker + ".csv";

            //create an aStock object to hold data based on form
            aStock currentStock = new aStock(dateTimePickerStart.Value,
                                            dateTimePickerEnd.Value,
                                            res);

            //Perform Action based on action selected
            if (radioButtonDownloadData.Checked)
            {
                //retrieve stock ticker from combobox
                stockTicker = comboBoxStockTicker.SelectedItem;

                //handle empty stock ticker
                if (stockTicker == null)
                {
                    MessageBox.Show("You Must Select a Stock Ticker", "Action Required",
                        MessageBoxButtons.OK);
                    return;
                }

                //Build URL to pull data from the Yahoo! Finance api
                //using protocol + stock ticker + start date + end date
                // + file format     
                const string protocol = "http://ichart.yahoo.com/table.csv?s=";

                //constant string to hold the csv format information
                const string fileFormat = "&ignore=.csv";

                //combine all information to form the full url to request data 
                //from Yahoo! Finance api
                //Note: We always download from 1/1/1900 to the given date
                // however, we can display less than that later.
                string url = protocol + stockTicker + "&a=1&b=1&c=1900&d=" +
                    endMonth + "&e=" + endDate + "&f=" + endYear + "&g=" +
                    resolution + fileFormat;

                //Create directory to store csv files
                Directory.CreateDirectory(workingDir + res);

                string myStringWebResource = null;

                //download csv file and store to filename
                WebClient webClient = new WebClient();
                myStringWebResource = url + fileName;
                webClient.DownloadFile(myStringWebResource, fileName);
            }
            else if (radioButtonDisplayData.Checked)
            {
                //retrieve stock ticker from combobox
                stockTicker = comboBoxStockTicker.SelectedItem;

                //handle empty stock ticker
                if (stockTicker == null)
                {
                    MessageBox.Show("You Must Select a Stock Ticker", "Action Required",
                        MessageBoxButtons.OK);
                    return;
                }
                //verify the appropriate file exists
                if (!(File.Exists(fileName)))
                {
                    MessageBox.Show("Please Download the Data First", "Action Required",
                    MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    //Create Datatable and import CSV data to it
                    DataTable dataTable = readCSVtoDataTable(fileName, dateTimePickerStart, 
                        dateTimePickerEnd);

                    //Set DataSource and ValueMembers to appropriate chart headers
                    chartStockData.DataSource = dataTable;
                    chartStockData.Series[0].XValueMember = "Date";
                    
                    chartStockData.Series[0].YValueMembers = "High,Low,Open,Close";

                    //Bind all information to chart
                    chartStockData.DataBind();                                        
                }
            }
            else
            {
                MessageBox.Show("Select an Action to Perform",
                    "Action Required", MessageBoxButtons.OK);
                return;
            }
        }

        private void chartStockData_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxStockTicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

    

