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
        public string Bio {get; set;}

        public Driver (int capacity, string name, string surname, string id, string phoneNumber, string userId, string bio, string image )
        {
            this.Name = name;
            this.Surname = surname;
            this.Capacity = capacity;
            this.ID = id;
            this.PhoneNumber = phoneNumber;
            this.UserId = userId;
            this.Bio = bio;
            this.Image = image;
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter($"Nuevo conductor: \nBienvenido a nuestra comunidad {Name} \n {Bio}",  @$"{image}"));
        }
        
        public void AceptCall (Info data, Call call)
        {
            data.StartJorney(this, call);
        }

        public void RatePassanger(Passanger passanger, int rating)
        {
            passanger.Rating.EffectiveRating = passanger.Rating.AddRating(rating);
        }
    }
}