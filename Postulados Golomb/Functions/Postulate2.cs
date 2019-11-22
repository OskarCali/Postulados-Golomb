using System;
using System.Collections.Generic;
using System.Linq;
using Postulados_Golomb.Extensions;
using Postulados_Golomb.Models;

namespace Postulados_Golomb.Functions
{
    internal class Postulate2
    {
        /// <summary>
        ///     Metodo analisis para evaluar cadena binaria por pares, trinas, etc
        /// </summary>
        /// <param name="text">Cadena a evaluar</param>
        /// <param name="bin">Cantidad de bits por grupo</param>
        /// <returns>Grupos de bits evaluados</returns>
        public List<List<Element>> analisis(string text, int bin)
        {
            var _groups = new List<List<Element>>();

            for (var i = 2; i <= bin; i++)
            {
                var group = new List<Element>();
                //group.Add("0".PadLeft(i, '0'));

                for (var j = 0; j < (int) Math.Pow(2, i); j++)
                    group.Add(new Element(Convert.ToString(j, 2).PadLeft(i, '0')));

                _groups.Add(group);
            }

            for (var i = 2; i <= bin; i++)
            for (var j = 0; j < text.Length; j++)
            {
                var tempAnalisis = text.Substring(0, i);

                var grupo = _groups[i - 2];
                grupo.FirstOrDefault(x => x.Name == tempAnalisis).Update();

                var temp = text[0];
                text = text.Remove(0, 1);
                text += temp;
            }

            return _groups;
        }
    }
}