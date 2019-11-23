using System.Collections.Generic;
using Postulados_Golomb.Extensions;

namespace Postulados_Golomb.Functions
{
    internal class Postulate3
    {
        /// <summary>
        ///     Analisis del postulado 3 para conocer el espectro de valores
        /// </summary>
        /// <param name="text">Cadena a analizar</param>
        /// <returns>Lista de valores que conforman al espectro</returns>
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