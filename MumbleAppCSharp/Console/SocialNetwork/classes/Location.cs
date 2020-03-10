using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Location : IDebug
    {
        private double Longitude;
        private double Latitude;
        private string LastKnownLongitude;
        private string LastKnownLatitude;
        private bool Debug = true;

        public Location()
        {

            if (Debug) Console.WriteLine("Log[Location]: Entered Default Constructor: Location()");

            this.Longitude = Random(0, 100);
            this.Latitude = Random(0, 100);
        }

        public double Random(int min, int max)
        {

            if (Debug) Console.WriteLine("Log[Location]: Entered Method: Random()");

            Random r = new Random();
            int rInt = r.Next(min, max); //for ints
            int range = max;
            double rDouble = r.NextDouble() * range; //for doubles
            return rDouble;
        }

        public void SetLongitude()
        {

            if (Debug) Console.WriteLine("Log[Location]: Setting up Longitude");

            this.Longitude = Random(0, 100);
        }
        public double GetLongitude()
        {

            if (Debug) Console.WriteLine("Log[Location]: Getting Longitude");

            return this.Longitude;
        }

        public void SetLatitude()
        {

            if (Debug) Console.WriteLine("Log[Location]: Setting Latitude");

            this.Latitude = Random(0, 100);
        }
        public double GetLatitude()
        {

            if (Debug) Console.WriteLine("Log[Location]: Getting Latitude");

            return this.Latitude;
        }


        public void SetDebug(bool option)
        {
            this.Debug = option;
        }
    }
}
