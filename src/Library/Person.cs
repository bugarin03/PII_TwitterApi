namespace UcuUber
{
    public abstract class Person
    {
        /// <summary>
        /// Nombre del empleador.
        /// </summary>
        /// <value></value>
        public string Name { get; set; }

        /// <summary>
        /// Cédula de identidad del empleador.
        /// </summary>
        /// <value>String que contiene 7 u 8 números, además de los puntos y guiones.</value>
        public string ID { get; set; }

        /// <summary>
        /// Número de ceular del empleador.
        /// </summary>
        /// <value>String de 9 caracteres.</value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Puntaje del empleador.
        /// </summary>
        /// <value>El promedio de los puntajes que le fueron asignados.</value>
        public Rating Rating { get; set; }
    }
}