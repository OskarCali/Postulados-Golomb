namespace Postulados_Golomb.Models
{
    public class Element
    {
        public Element(string name)
        {
            Name = name;
            Coincidences = 0;
        }

        public string Name { get; set; }
        public int Coincidences { get; set; }
    }
}