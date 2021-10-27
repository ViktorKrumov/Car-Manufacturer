using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}
