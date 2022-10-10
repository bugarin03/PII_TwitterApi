using System;

namespace UcuUber
{
    public class Call
    {
        public int PassangersAmount {get; set;}
        public Passanger Passanger {get; set;}
        public string Destination {get; set;}

        public Call (Passanger pasanger, string destination, int passangersAmount)
        {
            this.Passanger = pasanger;
            this.Destination = destination;
            this.PassangersAmount = passangersAmount;  
        }
    }
}