using System;
using System.Linq;
using System.Text;

namespace Postulados_Golomb.Extensions
{
    /// <summary>
    ///     Definicio de la clase stringExtension para extensiones de la clase String
    /// </summary>
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
        ///     Funcion para comparar los caracteres de dos cadenas
        /// </summary>
        /// <param name="text">Cadena principal</param>
        /// <param name="textCompare">Cadena con la que se va a comparar</param>
        /// <returns></returns>
        public static double Compare(this string text, string textCompare)
        {
            var c = 0;
            var length = text.Length;

            for (var i = 0; i < length; i++) c += text[i] == textCompare[i] ? 1 : 0;

            return 1.0 * (c - (length - c)) / length;
        }
    }
}