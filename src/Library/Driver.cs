using System;
using TwitterUCU;

namespace UcuUber
{
    /// <summary>
    /// Esta clase se encarga de calcular la reputación tanto de un conductor como de un pasajero.
    /// </summary>
    public class Driver : Person
    {
        public int Capacity {get; set;}

        public Driver (int capacity, string name, string surname, string id, string phoneNumber, string userId )
        {
            this.Name = name;
            this.Surname = surname;
            this.Capacity = capacity;
            this.ID = id;
            this.PhoneNumber = phoneNumber;
            this.UserId = userId;
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("Nuevo conductor", @"PathToImage.png"));
        }
        
        public void AceptCall (Call call)
        {
            if (call.PassangersAmount>1 && this.Capacity>1)
            {
                Info.StartJorney(this, call);
            }
            else
            {
                Info.StartJorney(this, call);
            }  
        }

        public void RatePassanger(Passanger passanger, int rating)
        {
            passanger.Rating.EffectiveRating = passanger.Rating.AddRating(rating);
        }
    }
}