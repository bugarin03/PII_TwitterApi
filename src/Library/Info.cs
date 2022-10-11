using System.Collections.Generic;
using System.Collections;
using TwitterUCU;
namespace UcuUber
{
    public class Info
    {
        private static Info data;
        private Info()
        {

        }

        public static Info Data
        {
            get
            {
                if (data == null)
                {
                    data = new Info();
                }
                return data;
            }
        }

        public List<Driver> FreeNormalDrivers { get; set; } = new List<Driver>();

        public List<Driver> FreePoolDrivers { get; set; } = new List<Driver>();

        public List<Driver> BusyNormalDrivers { get; set; } = new List<Driver>();

        public List<Driver> BusyPoolDrivers { get; set; } = new List<Driver>();

        public List<Passenger> Passengers { get; set; } = new List<Passenger>();

        public List<Passenger> PassengersOnBoard { get; set; } = new List<Passenger>();

        public List<Call> NormalCalls { get; set; } = new List<Call>();

        public List<Call> PoolCalls { get; set; } = new List<Call>();

        public void Notification(Call call)
        {
            if (call.PassengersAmount == 1)
            {
                foreach (Driver driver in FreeNormalDrivers)
                {
                    NormalCalls.Add(call);
                    var twitter = new TwitterMessage();
                    twitter.SendMessage("Nuevo viaje disponible", driver.UserId);
                }
            }
            else
            {
                foreach (Driver driver in FreePoolDrivers)
                {
                    PoolCalls.Add(call);
                    var twitter = new TwitterMessage();
                    twitter.SendMessage("Nuevo viaje disponible", driver.UserId);
                }
            }
        }

        public void NewDriver(Driver driver)
        {
            if (driver.Capacity == 1)
            {
                FreeNormalDrivers.Add(driver);
            }
            else
            {
                FreePoolDrivers.Add(driver);
            }
        }

        public void NewPassanger(Passenger passenger)
        {
            Passengers.Add(passenger);
        }
        public void StartJourney(Driver driver, Call call)
        {
            if (driver.Capacity == 1)
            {
                NormalCalls.Remove(call);
                FreeNormalDrivers.Remove(driver);
                BusyNormalDrivers.Add(driver);
                 var twitter = new TwitterMessage();
                twitter.SendMessage("Su conductor esta en camino", call.Passenger.UserId);
            }
            else
            {
                PoolCalls.Remove(call);
                FreePoolDrivers.Remove(driver);
                BusyPoolDrivers.Add(driver);
                var twitter = new TwitterMessage();
                twitter.SendMessage("Su conductor esta en camino", call.Passenger.UserId);
            }

            PassengersOnBoard.Add(call.Passenger);

        }
        public void FinishJourney(Driver driver, Call call)
        {
            if (driver.Capacity == 1)
            {
                FreeNormalDrivers.Add(driver);
                BusyNormalDrivers.Remove(driver);
            }
            else
            {
                FreePoolDrivers.Add(driver);
                BusyPoolDrivers.Remove(driver);
            }

            PassengersOnBoard.Remove(call.Passenger);
        }
    }
}