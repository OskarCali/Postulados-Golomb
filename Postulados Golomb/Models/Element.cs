namespace Postulados_Golomb.Models
{
    public class Element
    {
        /// <summary>
        ///     Constructor de Element
        /// </summary>
        /// <param name="name"></param>
        public Element(string name)
        {
            Name = name;
            Coincidences = 0;
        }

        /// <summary>
        ///     Propiedad Nombre del Element
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Propiedad Coincidences del Element
        /// </summary>
        public int Coincidences { get; set; }
    }
}