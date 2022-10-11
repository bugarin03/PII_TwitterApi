using System;

namespace UcuUber
{
    public class Call
    {
        public int PassengersAmount {get; set;}
        public Passenger Passenger {get; set;}
        public string Destination {get; set;}

        public Call (Passenger passenger, string destination, int passengersAmount)
        {
            this.Passenger = passenger;
            this.Destination = destination;
            this.PassengersAmount = passengersAmount;  
        }
    }
}