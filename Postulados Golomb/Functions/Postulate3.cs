using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Postulados_Golomb.Extensions;

namespace Postulados_Golomb.Functions
{
    class Postulate3
    {
        public List<double> analisis(string text)
        {
            var _analisis = new  List<double>();

            string textTemp = text;

            for (int i = 0; i <= text.Length; i++)
            {
                _analisis.Add(text.Compare(textTemp));

                var temp = textTemp[0];
                textTemp = textTemp.Remove(0, 1);
                textTemp += temp;
            }

            return _analisis;
        }
    }
}
