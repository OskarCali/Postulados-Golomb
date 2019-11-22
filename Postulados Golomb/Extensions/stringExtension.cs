using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postulados_Golomb.Extensions
{
    internal static class stringExtension
    {
        /// <summary>
        ///     Funcion para pasar de texto a bits
        /// </summary>
        /// <param name="text">Texto a convertir</param>
        /// <param name="encoding">Tipo de codificacion</param>
        /// <returns>Cadena binaria del texto</returns>
        public static string TextToBin(this string text, Encoding encoding)
        {
            return string.Join("", encoding.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }

        /// <summary>
        ///     Funcion para pasar los bits a texto
        /// </summary>
        /// <param name="data">Cadena binaria a transformar</param>
        /// <param name="encoding">Tipo de codificacion</param>
        /// <returns>Cadena de texto</returns>
        public static string BinToText(this string data, Encoding encoding)
        {
            var byteList = new List<byte>();

            for (var i = 0; i < data.Length; i += 8) byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));

            return encoding.GetString(byteList.ToArray());
        }

        /// <summary>
        ///     Funcion para igualar una cadena con otra en longitud, manteniendo sus caracteres
        /// </summary>
        /// <param name="shortCad">Cadena que se quiere emparejar</param>
        /// <param name="text">Cadena principal con la que se va a emparejar</param>
        /// <returns>Cadena con misma longitud y caracteres reptidos</returns>
        public static string ToEqualize(this string shortCad, string text)
        {
            while (shortCad.Length < text.Length) shortCad += shortCad;

            shortCad = shortCad.Substring(0, text.Length);

            return shortCad;
        }

        public static double Compare(this string text, string textCompare)
        {
            int c = 0, nc = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == textCompare[i])
                {
                    c++;
                }
                else
                {
                    nc++;
                }
            }

            return 1.0 * (c - nc) / text.Length;
        }
    }
}