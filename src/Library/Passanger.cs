using System;
using System.Collections.Generic;
using System.Collections;
using TwitterUCU;
using CognitiveCoreUCU;
namespace UcuUber
{
    /// <summary>
    /// Esta clase se encarga de calcular la reputación tanto de un conductor como de un pasajero.
    /// </summary>
    public class Passanger : Person
    {
        public Passanger (string name, string surname, string id, string phoneNumber, string userId, string image, Info data)
        {
            this.Name = name;
            this.Surname = surname;
            this.ID = id;
            this.PhoneNumber = phoneNumber;
            this.UserId = userId;
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter($"Nuevo pasajero:\n {Name} ", @$"{Image}"));
            data.NewPassanger(this);
            if (FoundFace(image))
            {
                Console.WriteLine("Tiene una cara muy bonita, es aceptado!");
            }
            else
            {
                Console.WriteLine("No hemos encontrado su hermosa cara, le hemos reasignado una foto");
                this.Image = @"..\Imagenes\guest.png"; 
            }
        }
       public Call Call(Info data, string destination, int passangersAmount)
       {
            Call trip = new Call (this, destination, passangersAmount);
            data.Notification(trip);
            return trip;
       }
       public void RateDriver(Driver driver, int rating)
        {
            driver.Rating.EffectiveRating = driver.Rating.AddRating(rating);
        }
         public bool FoundFace(string image)
        {
            CognitiveFace cog = new CognitiveFace(true, System.Drawing.Color.GreenYellow);
            cog.Recognize(@$"{image}");
            if (cog.FaceFound)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}