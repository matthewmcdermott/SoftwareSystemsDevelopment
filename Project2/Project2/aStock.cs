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

namespace Project2
{
    public class aStock
    {
        //Fields
        private List<aCandlestick> Candlestick;
        private DateTime StartingDate;
        private DateTime EndingDate;
        

        public enum aPeriodType { DAILY, WEEKLY, MONTHLY }
        private aPeriodType myPeriodType;

        //Properties
        aPeriodType PeriodType
        {
            get { return myPeriodType; }
        }
        public List<aCandlestick> candlestick
        {
            get { return Candlestick; }
        }
        public DateTime startingDate
        {
            get { return StartingDate; }
        }
        public DateTime endingDate
        {
            get { return EndingDate; }
        }

        /// <summary>
        /// Constructor with three parameters
        /// </summary>
        /// <param name="inStart">starting date</param>
        /// <param name="inEnd">ending date</param>
        /// <param name="period">resolution</param>
        public aStock(DateTime inStart, DateTime inEnd, aPeriodType period)
        {
            StartingDate = inStart;
            EndingDate = inEnd;
            myPeriodType = period;
            Candlestick = new List<aCandlestick>();
        }

        //Methods

        /// <summary>
        /// Read stock information from a Yahoo! Finance
        /// API url that returns a CSV file
        /// We save the CSV file to a temporary folder
        /// and then read it back into aStock object
        /// </summary>
        /// <param name="URL">API Call URL</param>
        public void ReadFromURL(string URL)
        {
            //Declare the working directory to save files
            string workingDir = "C:\\DEV\\STOCKDATA\\" +
                PeriodType.ToString() + "\\";
            string tempFileName = "C:\\DEV\\STOCKDATA\\temp";

            //Create directory to store csv files
            Directory.CreateDirectory(workingDir);

            //Open WebClient object and download CSV file
            WebClient webClient = new WebClient();
            webClient.DownloadFile(URL, tempFileName);

            //Read the data back in to aStock object
            ReadFromFile(tempFileName);
        }

        /// <summary>
        /// Read stock information from a CSV file and store it
        /// in aStock object.
        /// </summary>
        /// <param name="filename">The name of the CSV file</param>
        public void ReadFromFile(string filename)
        {
            //Create StreamReader object to read in data
            StreamReader reader = new StreamReader(filename);

            //Store heading information into a string array
            string[] heading = reader.ReadLine().Split(',');

            while(!reader.EndOfStream)
            {
                //read in lines of information
                string[] rows = reader.ReadLine().Split(',');

                //Create an aCandlestick object to hold data and add it 
                //to Candlestick list
                aCandlestick cStick = new aCandlestick(Convert.ToDecimal(rows[1]),
                    Convert.ToDecimal(rows[4]), Convert.ToDecimal(rows[2]),
                    Convert.ToDecimal(rows[3]), Convert.ToDateTime(rows[0]),
                    Convert.ToDouble(rows[5]));
                Candlestick.Add(cStick);
            }
            //Reverse the order of the Candlestck list
            Candlestick.Reverse();
        }

        /// <summary>
        /// Function to save aStock information to a file
        /// We will save data as a CSV file in the filepath
        /// "C:\DEV\STOCKDATA" with a directory referring to
        /// either Daily, Weekly, or Monthly
        /// </summary>
        /// <param name="filename">Name of the file to output</param>
        public void SaveToFile(string filename)
        {
            //Declare the working directory to save files
            string workingDir = "C:\\DEV\\STOCKDATA\\" + 
                PeriodType.ToString() + "\\";

            //Create directory to store csv files
            Directory.CreateDirectory(workingDir);

            //Create StringBuilder object to write information to 
            //output file
            StringBuilder csv = new StringBuilder();

            //Add titles to StringBuilder object
            string titles = string.Format("{0},{1},{2},{3},{4},{5}","Date", "Open", 
                                "High", "Low", "Close", "Volume");
            csv.AppendLine(titles);

            //Add candlestick information to StringBuilder object
            for (int i = 0; i < Candlestick.Count; ++i )
            {
                DateTime d = Candlestick[i].StartingDate;
                decimal o = Candlestick[i].Open;
                decimal c = Candlestick[i].Close;
                decimal h = Candlestick[i].High;
                decimal l = Candlestick[i].Low;
                double v = Candlestick[i].Volume;

                string newLine = string.Format("{0},{1},{2},{3},{4},{5}",
                    d,o,h,l,c,v);
                csv.AppendLine(newLine);
            }
            
            //Write StringBuilder object to the CSV file
            File.WriteAllText(workingDir + filename + ".csv", csv.ToString());
        }
    }
}
