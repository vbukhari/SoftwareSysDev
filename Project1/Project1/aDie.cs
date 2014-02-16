/*
Authors: Vasim Bukhari
Project: Software System Dev. class project 1: a six faces dia application that generate graph according to 
 * results of number of time it rolls
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1
{
    class aDie
    {
        public int Low { get; set; }
        public int High { get; set; }
        public int? Seed { get; set; }  
        
        Random Rand;
        
        public aDie(int? seed) 
        {
            Seed = seed;
            setRange(1, 7);

            if (seed.HasValue)
                Rand = new Random(seed.Value);
            else
                Rand = new Random();
        }

        public void setRange(int l, int h)
        {
            Low = l;
            High = h;
        }


        public int roll() 
        {
            //int num = 0;
            //if (setSeed == null)
            //{
            //   // int seed = Interlocked.Increment(ref seedCounter);
            //    num = Rand.Next(setLow, setHigh);
            //}
            //else
            //{
            //    Rand = new Random(setSeed.Value);
            //}
            //int num = Rand.Next(setLow, setHigh);
            return Rand.Next(Low, High);
        }
    }
}
