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
    class aStock : aCandlestick 
    {
        /// <summary>
        /// Fields
        /// </summary>
        List<aCandlestick> Candlestick;
        enum aPeriodType PeriodType {DAILY, WEEKLY, MONTHLY};
        DateTime StartingDate;
        DateTime EndingDate;

        aStock(DateTime inStartingDate, DateTime inEndingDate, string inRes)
        {
            StartingDate = inStartingDate;
            EndingDate = inEndingDate;
            
        }

        /// <summary>
        /// Read the data from a CSV file source
        /// Parameters: filename - CSV file containing data
        /// </summary>
        /// <param name="filename"></param>
        void ReadFromFile(string filename) 
        {
            readData(filename);
        }

        /// <summary>
        /// Read the data from a URL source
        /// Parameters: URL - source of information
        /// </summary>
        /// <param name="URL"></param>
        void ReadFromURL(string URL)
        {
            readData(URL);          
        }


        /// <summary>
        /// Heper function to read data from a source and store it in
        /// aStock type
        /// Parameters: source - a string specifying location of data
        /// </summary>
        /// <param name="source"></param>
        void readData(string source)
        {
            //Open StreamReader to read in CSV information
            StreamReader reader = new StreamReader(source);

            //Create aCandlestick object to save the information to
            aCandlestick cStick = new aCandlestick();

            //Store heading information into a string array
            string[] heading = reader.ReadLine().Split(',');

            //Iterate through rows until we reach the end of the file
            while (!reader.EndOfStream)
            {
                //read in lines of information
                string[] rows = reader.ReadLine().Split(',');

                //Check if the dates are between given dates
                //then add to a DataRow and add that row
                //to the DataTable
                DateTime dtStart = DateTime.Parse(rows[0]);
                if (dtStart > StartingDate && dtStart < EndingDate)
                {
                    //iterate through values in current row
                    for (int i = 0; i < heading.Length; ++i)
                    {
                        //save value to correct field of candlestick object
                        switch (i)
                        {
                            case 1:
                                cStick.open = Convert.ToDecimal(rows[i]);
                                break;
                            case 2:
                                cStick.high = Convert.ToDecimal(rows[i]);
                                break;
                            case 3:
                                cStick.low = Convert.ToDecimal(rows[i]);
                                break;
                            case 4:
                                cStick.close = Convert.ToDecimal(rows[i]);
                                break;
                            case 5:
                                cStick.volume = Convert.ToDouble(rows[i]);
                                break;
                            default:
                                MessageBox.Show("The data was not read properly.",
                                    "Action Required", MessageBoxButtons.OK);
                                break;

                        }
                    }
                    //Add the aCandlestick object to the list of Candlesticks 
                    //in aStock at the end.  We will later straighten out
                    //the order of the list
                    Candlestick.Add(cStick);
                }
            }
            //Fixes the order of the list of aCandlestick objects
            Candlestick.Reverse();    
        }


        /// <summary>
        /// Saves the data held in aStock object to a CSV file
        /// </summary>
        /// <param name="filename"></param>
        void SaveToFile(string filename)
        {
            //Constant variable for objects members
            const int MEMBERS = 6;

            //Create StreamWriter object to write data to a file
            StreamWriter writer = new StreamWriter();

            //Iterate through rows until the Candlestick list is empty
            for (int row = 0; row < Candlestick.Count; ++row )
            {
                //Iterate through columns in each row
                //and place them in the correct row in
                //the CSV file
                for (int column = 0; column < MEMBERS; ++column)
                {
                    writer.Write(Candlestick[column]);
                }
                writer.WriteLine();
            }

        }
    }
}
