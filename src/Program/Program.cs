using System;
using System.Threading.Tasks;
using UcuUber;

namespace TwitterUCU
{
    class Program
    {
        static void Main(string[] args)
        {
            Info Lists =  Info.Data;
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("New Employee 2! ",@"bill2.jpg"));
            var twitterDirectMessage = new TwitterMessage();
            Console.WriteLine(twitterDirectMessage.SendMessage("Hola!", "1396065818"));
            Driver Pepe = new Driver(4, "Pepe", "Gonzales", "Supra", "5874139-5", "094587458", "123456789", "buen conductor", @"PII_TwitterApi\src\Imagenes\descargar.jpg", Lists);
            Passanger Gonzalo = new Passanger( "Gonzalo", "Domingez", "5874139-5", "094587458", "123456789", @"PII_TwitterApi\src\Imagenes\descargar.jpg", Lists);
            Call trip = Gonzalo.Call(Lists, "Feria", 2);
            Pepe.AceptCall(Lists,trip);
            Pepe.SuccessfulTrip(Lists,trip);
        }
    }
}