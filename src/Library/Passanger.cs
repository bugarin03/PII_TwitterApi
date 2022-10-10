namespace UcuUber
{
    /// <summary>
    /// Esta clase se encarga de calcular la reputación tanto de un conductor como de un pasajero.
    /// </summary>
    public class Passanger : Person
    {
        public Passanger (string name, string surname, string id, string phoneNumber, string userId)
        {
            this.Name = name
            this.Surname = surname
            this.ID = id
            this.PhoneNumber = phoneNumber
            this.UserId = userId
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("Nuevo pasagero", @"PathToImage.png"));
        }
       public void Call(string destination, int passangersAmount)
       {
            Call trip = new Call (this, destination, passangersAmount);
            Info.Notification(passangersAmount)
       }

       public void RateDriver(Driver driver, int rating)
        {
            driver.Rating.EffectiveRating = driver.Rating.AddRating(rating);
        }
    }
}