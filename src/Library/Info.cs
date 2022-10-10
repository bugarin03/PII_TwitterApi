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

        public List<Passanger> Passangers { get; set; } = new List<Passanger>();

        public void Notification (int passangersAmount)
        {
            if (passangersAmount==1)
            {
                foreach (Driver driver in FreeNormalDrivers)
                {
                    var twitter = new TwitterMessage();
                    twitter.SendMessage("Nuevo viaje disponible", driver.UserId);
                }
            }
            else
            {
                foreach (Driver driver in FreePoolDrivers)
                {
                    var twitter = new TwitterMessage();
                    twitter.SendMessage("Nuevo viaje disponible", driver.UserId);
                }
            }
        }
        public void StartJorney (Driver driver, Passanger passanger )
        {


            if (driver.Capacity==1)
            {
                FreeNormalDrivers.Remove(driver);
                BusyNormalDrivers.Add(driver);
            }
            else
            {
                FreePoolDrivers.Remove(driver);
                BusyPoolDrivers.Add(driver);
            }

            Passangers.Add(passanger);

        }
        public  void FinishJorney (Driver driver, Passanger passanger )
        {
            if (driver.Capacity==1)
            {
                FreeNormalDrivers.Add(driver);
                BusyNormalDrivers.Remove(driver);
            }
            else
            {
                FreePoolDrivers.Add(driver);
                BusyPoolDrivers.Remove(driver);
            }

            Passangers.Remove(passanger);

        }
    }
}