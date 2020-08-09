using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Flight
    {
        public string FlightDate { get; set; }
        public string TailNum { get; set; }
        public int FlightNum { get; set; }
        public string OriginCityName { get; set; }
        public string OriginStateName { get; set; }
        public string DestCityName { get; set; }
        public string DestStateName { get; set; }
        public string DepTime { 
            get 
            {
                if (DepTime.Length < 4)
                {
                    DepTime = $"0{DepTime}";
                }

                return DepTime.Insert(2, ":");
            }

            set { }
        }
        public string ArrTime 
        {
            get
            {
                if (ArrTime.Length < 4)
                {
                    ArrTime = $"0{DepTime}";
                }

                return ArrTime.Insert(2, ":");
            }

            set { }
        }
        public double Cancelled { get; set; }
        public double AirTime { get; set; }
        public double Distance { get; set; }

    }
}
