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
using System.Globalization;

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
            string workingDir = "C:\\DEV\\STOCKDATA\\DAILY\\";
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
            string workingDir = "C:\\DEV\\STOCKDATA\\DAILY\\";

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

        /// <summary>
        /// Retrieve weekly or monthly candlestick data from previously 
        /// downloaded daily data file
        /// </summary>
        /// <param name="pt">Specify to synthesize weekly or monthly</param>
        /// <returns>Returns aStock for the provided resolution</returns>
        public aStock generateOtherPeriod(aPeriodType pt)
        {
            //Create a new aStock object to return
            aStock newstock = new aStock(startingDate, endingDate, PeriodType);

            //Check to see whether we are converting to monthly resolution or 
            //weekly resolution based on what was passed in as pt
            if ( pt.ToString() == "MONTHLY" )
            {
                //Create a query that groups everything in candlestick by year and then
                //further groups those elements by month
                var queryMonthly =
                    from cs in candlestick
                    group cs by cs.StartingDate.Year into yearGroup
                    from monthGroup in
                        (from cs in yearGroup
                         group cs by cs.StartingDate.Month)
                    group monthGroup by yearGroup.Key;

                //Iterate over each member using three nested for loops 
                foreach (var outerGroup in queryMonthly)
                {
                    foreach (var innerGroup in outerGroup)
                    {
                        //Declare variables that we must find in order to create new candlesticks
                        //and set open to first day's open, close to last day's close, date to
                        //first day's date.
                        decimal newOpen = innerGroup.First().Open;
                        decimal newClose = innerGroup.Last().Close;
                        decimal newHigh = 0;
                        decimal newLow = 2000000; //arbitrary value set for newLow
                        DateTime newDate = innerGroup.First().StartingDate;
                        double newVolume = 0;

                        //Iterate through each separate candlestick to find the lowest low and
                        //highest high
                        foreach (var cStick in innerGroup)
                        {
                            newVolume += cStick.Volume;
                            if (cStick.Low < newLow)
                            {
                                newLow = cStick.Low;
                            }
                            if (cStick.High > newHigh)
                            {
                                newHigh = cStick.High;
                            }
                        }

                        //Create a new candlestick and add it to the newStock Candlestick list
                        aCandlestick newStick = new aCandlestick(newOpen, newClose, newHigh, newLow, newDate, newVolume);
                        newstock.Candlestick.Add(newStick);
                    }
                }
            }
            else //assume that WEEKLY is the desired resolution
            {
                // Gets the Calendar instance associated with a CultureInfo.
                CultureInfo myCI = new CultureInfo("en-US");
                Calendar myCal = myCI.Calendar;

                // Gets the DTFI properties required by GetWeekOfYear.
                CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
                DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

                //Create a query that groups everything in candlestick by week of the year
                var queryWeekly =
                    from cs in candlestick
                    group cs by cs.StartingDate.Year into yearGroup
                    from weekGroup in
                        (from cs in yearGroup
                         group cs by myCal.GetWeekOfYear(cs.StartingDate, myCWR, myFirstDOW))
                    group weekGroup by yearGroup.Key;  
               
                
                //Iterate through each member using three nested for loops
                foreach (var OuterGroup in queryWeekly)
                {
                    foreach (var innerGroup in OuterGroup)
                    {

                        //Declare variables that we must find in order to create new candlesticks
                        //and set open to first day's open, close to last day's close, date to
                        //first day's date.
                        decimal newOpen = innerGroup.First().Open;
                        decimal newClose = innerGroup.Last().Close;
                        decimal newHigh = 0;
                        decimal newLow = 2000000; //arbitrary value set for newLow
                        DateTime newDate = innerGroup.First().StartingDate;
                        double newVolume = 0;

                        //Iterate through each separate candlestick to find the lowest low and
                        //highest high
                        foreach (var cStick in innerGroup)
                        {
                            newVolume += cStick.Volume;
                            if (cStick.Low < newLow)
                            {
                                newLow = cStick.Low;
                            }
                            if (cStick.High > newHigh)
                            {
                                newHigh = cStick.High;
                            }
                        }

                        //Create a new candlestick and add it to the newStock Candlestick list
                        aCandlestick newStick = new aCandlestick(newOpen, newClose, newHigh, newLow, newDate, newVolume);
                        newstock.Candlestick.Add(newStick);

                    }
                }               

            }

            return newstock;
        }
    }
}
