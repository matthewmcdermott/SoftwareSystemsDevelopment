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
    public class aCandlestick
    {

        /// <summary>
        /// Fields of aCandlestick class
        /// </summary>
        private decimal open;
        private decimal close;
        private decimal high;
        private decimal low;
        private DateTime startingDate;
        private double volume;

        /// <summary>
        /// Properties of aCandlestick class
        /// </summary>
        public decimal Open
        {
            get { return open; }
        }
        public decimal Close
        {
            get { return close; }
        }
        public decimal High
        {
            get { return high; }
        }
        public decimal Low
        {
            get { return low; }
        }
        public DateTime StartingDate
        {
            get { return startingDate; }
        }
        public double Volume
        {
            get { return volume; }
        }       

        /// <summary>
        /// Constructor with no parameters
        /// All fields are initialized to zero
        /// </summary>
        public aCandlestick()
        {
            open = 0;
            close = 0;
            high = 0;
            low = 0;
            startingDate = DateTime.Now;
            volume = 0;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="inOpen"></param>
        /// <param name="inClose"></param>
        /// <param name="inHigh"></param>
        /// <param name="inLow"></param>
        /// <param name="inDate"></param>
        /// <param name="inVolume"></param>
        public aCandlestick(decimal inOpen, decimal inClose, decimal inHigh,
            decimal inLow, DateTime inDate, double inVolume)
        {
            open = inOpen;
            close = inClose;
            high = inHigh;
            low = inLow;
            startingDate = inDate;
            volume = inVolume;
        }


    }
}
