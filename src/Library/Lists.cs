using System.Collections.Generic;
using System.Collections;
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

        public  void Movement (Driver driver, Passanger passanger )
        {
            
        }
    }
}