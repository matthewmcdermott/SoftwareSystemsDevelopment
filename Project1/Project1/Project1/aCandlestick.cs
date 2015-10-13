using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class aCandlestick
    {
        /// <summary>
        /// Fields
        /// </summary>
        public decimal open;
        public decimal high;
        public decimal low;
        public decimal close;
        public double volume;
        public DateTime startingDate;

        /// <summary>
        /// Properties, all read only
        /// </summary>
        decimal Open { get; private set; }
        decimal High { get; private set; }
        decimal Low { get; private set; }
        decimal Close { get; private set; }
        double Volume { get; private set; }
        DateTime StartingDate { get; private set; }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public aCandlestick()
        {
            open = 0;
            high = 0;
            low = 0;
            close = 0;
            volume = 0;
            startingDate = DateTime.Now;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="inOpen"></param>
        /// <param name="inHigh"></param>
        /// <param name="inLow"></param>
        /// <param name="inClose"></param>
        /// <param name="inVolume"></param>
        /// <param name="inStartingDate"></param>
        public aCandlestick(decimal inOpen, decimal inHigh, decimal inLow, decimal inClose,
            double inVolume, DateTime inStartingDate)
        {
            open = inOpen;
            high = inHigh;
            low = inLow;
            close = inClose;
            volume = inVolume;
            startingDate = inStartingDate;
        }

        

    }
}
