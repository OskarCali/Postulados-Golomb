using System.Collections.Generic;
using Postulados_Golomb.Models;

namespace Postulados_Golomb.Functions
{
    internal class Postulates
    {
        public List<int> AnalisisP1 { get; set; }
        public List<List<Element>> AnalisisP2 { get; set; }

        public void postulado(int num, string text, int bin = 5)
        {
            switch (num)
            {
                case 1:
                    var p1 = new Postulate1();
                    AnalisisP1 = p1.analisis(text);
                    break;
                case 2:
                    var p2 = new Postulate2();
                    AnalisisP2 = p2.analisis(text, bin);
                    break;
                case 3:
                    break;
            }
        }
    }
}