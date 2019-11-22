using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postulados_Golomb.Functions
{
    class Postulate1
    {
        public List<int> analisis(string text)
        {
            List<int> _analisis = new List<int>();

            var cerosCount = text.Count(x => x == '0');
            var unosCount = text.Count(x => x == '1');

            _analisis.Add(cerosCount);
            _analisis.Add(unosCount);

            return _analisis;
        }
    }
}
