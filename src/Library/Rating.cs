using System;
using System.Collections.Generic;

namespace UcuUber
{
   
    public class Rating
    {
     
        public int RatingsSum { get; set; }

      
        public int TotalRatings { get; set; }

        
        public double EffectiveRating { get; set; }

       
        public Rating()
        {
            this.RatingsSum = 0;
            this.TotalRatings = 0;
            this.EffectiveRating = 0;
        }

       
        public double AddRating(int rating)
        {
            if (rating >= 1 && rating <= 5)
            {
                this.RatingsSum += rating;
                this.TotalRatings++;
                return RatingsSum / TotalRatings;
            }

            else
            {
                Console.WriteLine("Error: el puntaje debe estar entre 1 y 5.");
                return EffectiveRating;
            }
        }
    }
}