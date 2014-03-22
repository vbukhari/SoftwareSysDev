/* VASIMRAZA H. BUKHARI 
 * Software System Development - Project 2
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class aCandlestick
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public int Volume { get; set; }
        public decimal Adj_close { get; set; }

        public aCandlestick(DateTime date, decimal open, decimal high, decimal low, decimal close, Int32 volume, decimal adj_close)
        {
            this.Date = date;
            this.Open = open;
            this.High = high;
            this.Close = close;
            this.Low = low;
            this.Volume = volume;
            this.Adj_close = adj_close;
        }
    }
}
