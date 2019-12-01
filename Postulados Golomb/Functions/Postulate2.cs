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
        ///     Metodo para analizar pequeños grupos de binarios
        /// </summary>
        /// <param name="text">Secuencia binaria pseudo-aleatoria</param>
        /// <param name="bin">Cantidad de binarios maximos en un grupo</param>
        /// <returns>Lista de grupos analizados</returns>
        public List<List<Element>> analisis(string text, int bin)
        {
            var _groups = new List<List<Element>>();

            for (var i = 2; i <= bin; i++)
            {
                var group = new List<Element>();

                for (var j = 0; j < (int) Math.Pow(2, i); j++)
                    group.Add(new Element(Convert.ToString(j, 2).PadLeft(i, '0')));

                _groups.Add(group);
            }

            for (var i = 2; i <= bin; i++)
            for (var j = 0; j < text.Length; j++)
            {
                var tempGroup = text.Substring(0, i);

                var grupo = _groups[i - 2];
                grupo.FirstOrDefault(x => x.Name == tempGroup).Update();

                var temp = text[0];
                text = text.Remove(0, 1);
                text += temp;
            }

            return _groups;
        }
    }
}