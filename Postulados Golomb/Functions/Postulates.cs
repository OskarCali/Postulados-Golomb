using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postulados_Golomb.Functions
{
    class Postulates
    {
        public List<int> AnalisisP1 { get; set; }

        public void postulado(int num, string text, int bin = 5)
        {
            switch (num)
            {
                case 1:
                    Postulate1 p1 = new Postulate1();
                    AnalisisP1 = p1.analisis(text);
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}
