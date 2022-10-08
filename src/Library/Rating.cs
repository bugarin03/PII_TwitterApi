using System;
using System.Collections.Generic;

namespace UcuUber
{
    /// <summary>
    /// Esta clase se encarga de calcular la reputación tanto de un conductor como de un pasajero.
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Tiene la suma de todos los puntajes que le dieron a alguien.
        /// </summary>
        /// <value></value>
        public int RatingsSum { get; set; }

        /// <summary>
        /// Indica la cantidad total de veces que se puntuó a alguien.
        /// </summary>
        /// <value></value>
        public int TotalRatings { get; set; }

        /// <summary>
        /// Indica la reputación, calculada como el promedio entre los distintos puntajes que se le asignaron.
        /// </summary>
        /// <value></value>
        public double EffectiveRating { get; set; }

        /// <summary>
        /// Método constructor de la clase Rating.
        /// </summary>
        public Rating()
        {
            this.RatingsSum = 0;
            this.TotalRatings = 0;
            this.EffectiveRating = 0;
        }

        /// <summary>
        /// Método para agregar un puntaje a una persona.
        /// </summary>
        /// <param name="rating">El puntaje a asignar.</param>
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