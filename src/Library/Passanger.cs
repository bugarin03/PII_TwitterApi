namespace UcuUber
{
    /// <summary>
    /// Esta clase se encarga de calcular la reputación tanto de un conductor como de un pasajero.
    /// </summary>
    public class Passanger : Person
    {
       public void Call()
       {
            
       }

       public void RateDriver(Driver driver, int rating)
        {
            driver.Rating.EffectiveRating = driver.Rating.AddRating(rating);
        }
    }
}