using System;

namespace UcuUber
{
    public class Call
    {
        public int PassangersAmount;
        public Passanger Passanger;
        public string Destination;

        public Call (Passanger pasanger, string destination, int passangersAmount)
        {
            this.Passanger = pasanger;
            this.Destination = destination;
            this.PassangersAmount = passangersAmount;  
        }
    }
}