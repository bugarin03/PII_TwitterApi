namespace UcuUber
{
    /// <summary>
    /// Esta clase se encarga de calcular la reputación tanto de un conductor como de un pasajero.
    /// </summary>
    public class Driver : Person
    {
        public int Capacity {get; set;}

        public void RatePassanger(Passanger passanger, int rating)
        {
            passanger.Rating.EffectiveRating = passanger.Rating.AddRating(rating);
        }
    }
}