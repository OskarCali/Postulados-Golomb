using System.Collections.Generic;
using System.Linq;

namespace Postulados_Golomb.Functions
{
    internal class Postulate1
    {
        /// <summary>
        ///     Funcion para realizar el analisis del postulado 1
        /// </summary>
        /// <param name="text">Secuencia binaria pseudo-aleatoria</param>
        /// <returns>Lista con las coincidencias de 0's y 1's</returns>
        public List<int> analisis(string text)
        {
            var _analisis = new List<int>();

            var cerosCount = text.Count(x => x == '0');
            var unosCount = text.Count(x => x == '1');

            _analisis.Add(cerosCount);
            _analisis.Add(unosCount);

            return _analisis;
        }
    }
}