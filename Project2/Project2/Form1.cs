using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //Retrieve stock ticker from combobox on form1
            var stockTicker = cmboBoxTicker.SelectedItem;

            //handle empty stock ticker
            if (stockTicker == null)
            {
                MessageBox.Show("You Must Select a Stock Ticker", "Action Required",
                    MessageBoxButtons.OK);
                return;
            }

            //get resolution from radio buttons
                string resolution = "";
                aStock.aPeriodType period = (aStock.aPeriodType)Enum.Parse(typeof(aStock.aPeriodType), "MONTHLY");
                if (rdoBtnDaily.Checked)
                {
                    resolution = "d";
                    period = (aStock.aPeriodType)Enum.Parse(typeof(aStock.aPeriodType), "DAILY");
                    
                }
                else if (rdoBtnWeekly.Checked)
                {
                    resolution = "w";
                    period = (aStock.aPeriodType)Enum.Parse(typeof(aStock.aPeriodType), "WEEKLY");
                }
                else if (rdoBtnMonthly.Checked)
                {
                    resolution = "m";
                    period = (aStock.aPeriodType)Enum.Parse(typeof(aStock.aPeriodType), "MONTHLY");
                }
                else
                {
                    MessageBox.Show("Select a Resolution", "Action Required",
                        MessageBoxButtons.OK);
                    return;
                }

                //Create aStock object
                aStock currentStock = new aStock(dtTmPckrStartDate.Value, dtTmPckrEndDate.Value, period);

            if (rdoBtnDownload.Checked)
            {
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
                    dtTmPckrEndDate.Value.Month.ToString() + "&e=" + 
                    dtTmPckrEndDate.Value.Date.ToString("dd") + "&f=" + 
                    dtTmPckrEndDate.Value.Year.ToString() + "&g=" +
                    resolution + fileFormat;

                //Read stock data from the URL and then save it to a file in 
                //proper directory
                currentStock.ReadFromURL(url);
                currentStock.SaveToFile(stockTicker.ToString());

                //Message box to show it was successful
                MessageBox.Show("Data Downloaded Successfully!", "Success!",
                        MessageBoxButtons.OK);
            }
            else if(rdoBtnDisplay.Checked)
            {
                

                //Declare the working directory to save files
                string fileName = "C:\\DEV\\STOCKDATA\\" +
                period.ToString() + "\\" + stockTicker.ToString() + ".csv";

                //verify the appropriate file exists
                if (!(File.Exists(fileName)))
                {
                    MessageBox.Show("Please Download the Data First",
                        "Action Required", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    //Create new form of class Form2 and make it modeless
                    Form2 newform = new Form2();
                    newform.Owner = this;

                    //Read data into the stock from the file
                    currentStock.ReadFromFile(fileName);

                    //send information to the new form to display
                    newform.LoadInfo(currentStock, stockTicker.ToString());

                    //Display Text on window caption
                    string text = stockTicker.ToString() + ", " +
                    period.ToString() + ", " +
                    dtTmPckrStartDate.Value.ToString("m/d/yyyy") +
                    " - " + dtTmPckrEndDate.Value.ToString("m/d/yyy");

                    newform.Text = text;

                    //Display the form
                    newform.Show();
                }

            }

        }
    }
}
