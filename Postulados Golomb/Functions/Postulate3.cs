using System.Collections.Generic;
using Postulados_Golomb.Extensions;

namespace Postulados_Golomb.Functions
{
    internal class Postulate3
    {
        /// <summary>
        ///     Analisis de la correlacion de la secuencia binaria
        /// </summary>
        /// <param name="text">Secuencia binaria pseudo-aleatoria</param>
        /// <returns>Lista de correlacion</returns>
        public List<double> analisis(string text)
        {
            var _analisis = new List<double>();

            var textTemp = text;

            for (var i = 0; i <= text.Length; i++)
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