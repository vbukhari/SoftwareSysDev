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
        //properties
        public int Low { get; set; }    //low value propoerty
        public int High { get; set; }   //high value 
        public int? Seed { get; set; }  //store seed number
        //creating instance of random class
        Random Rand;
        //Constructor for Die class
        public aDie(int? seed) 
        {
            Seed = seed;     //set the seed value
            setRange(1, 7);  //set range, minimum and max value for random
            //check seed value to select correct constructor type for random
            if (seed.HasValue)
                Rand = new Random(seed.Value);  //Random constructor with seed value 
            else
                Rand = new Random();            //Random constructor without seed value
        }
        //setRange function sets the low and high value for random number generator
        public void setRange(int l, int h)
        {
            Low = l;
            High = h;
        }

        //roll function generate the random number between low and high value
        public int roll() 
        {
            return Rand.Next(Low, High);
        }
    }
}
