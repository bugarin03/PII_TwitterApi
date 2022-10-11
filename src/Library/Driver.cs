using System;
using TwitterUCU;
using CognitiveCoreUCU;

namespace UcuUber
{
    /// <summary>
    /// Esta clase se encarga de calcular la reputación tanto de un conductor como de un pasajero.
    /// </summary>
    public class Driver : Person
    {
        public string Car { get; set; }
        public int Capacity { get; set; }
        public string Bio { get; set; }

        public Driver(int capacity, string name, string surname, string car, string id, string phoneNumber, string userId, string bio, string image, Info data)
        {
            this.Name = name;
            this.Surname = surname;
            this.Car = car;
            this.Capacity = capacity;
            this.ID = id;
            this.PhoneNumber = phoneNumber;
            this.UserId = userId;
            this.Bio = bio;
            this.Image = image;

            if (FoundFace(image))
            {
                Console.WriteLine("Tiene una cara muy bonita, es aceptado!");
            }
            else
            {
                Console.WriteLine("No hemos encontrado su hermosa cara o no esta sonriendo, le hemos reasignado una foto");
                this.Image = @"PII_TwitterApi\src\Imagenes\logo_ucu_200x102.jpg";
            }

            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter($"Nuevo conductor: \nBienvenido a nuestra comunidad {Name} \n {Bio}", $"{Image}"));
            data.NewDriver(this);
        }

        public void AceptCall(Info data, Call call)
        {
            data.StartJourney(this, call);
        }

        public void SuccessfulTrip(Info data, Call call)
        {
            data.FinishJourney(this, call);
        }

        public void RatePassenger(Passenger passanger, int rating)
        {
            passanger.Rating.EffectiveRating = passanger.Rating.AddRating(rating);
        }

        public bool FoundFace(string image)
        {
            CognitiveFace cog = new CognitiveFace(true, System.Drawing.Color.GreenYellow);
            cog.Recognize($"{image}");
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}