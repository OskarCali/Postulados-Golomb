using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Postulados_Golomb.Extensions;
using Postulados_Golomb.Models;

namespace Postulados_Golomb.Functions
{
    internal class Postulate2
    {
        public List<List<Element>> analisis(string text, int bin)
        {
            var _analisis = new List<List<Element>>();
            var _groups = new List<List<Element>>();

            for (int i = 2; i <= bin; i++)
            {
                var group = new List<Element>();
                //group.Add("0".PadLeft(i, '0'));

                for (int j = 0; j < (int) Math.Pow(2, i); j++)
                {
                    group.Add(new Element(Convert.ToString(j, 2).PadLeft(i, '0')));
                }

                _groups.Add(group);
            }

            for (int i = 2; i <= bin; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    string tempAnalisis = text.Substring(0, i);

                    var grupo = _groups[i - 2];
                    grupo.FirstOrDefault(x => x.Name == tempAnalisis).Update();

                    char temp = text[0];
                    text = text.Remove(0, 1);
                    text += temp;
                }
            }

            return _groups;
            //for (var i = 0; i < bin; i++)
            //{
            //    var hashtable = new Hashtable();
            //    var groups = new List<string>();

            //    //groups = createGroups();

            //    for (var j = 0; j < text.Length - 1; j++)
            //    {
            //        var elements = hashtable.Values.Cast<Element>().ToList();

            //        if (elements.Count != 0)
            //        {
            //            if (Equals(!groups.Contains(text[j] + text[j + 1].ToString())))
            //            {
            //                hashtable.Add(text[j] + text[j + 1].ToString(),
            //                    new Element(text[j] + text[j + 1].ToString()));
            //                groups.Add(text[j] + text[j + 1].ToString());
            //            }
            //            else
            //            {
            //                var element = elements.FirstOrDefault(x => x.Name == text[j] + text[j + 1].ToString());
            //                foreach (DictionaryEntry entry in hashtable)
            //                    if (element == entry.Value)
            //                    {
            //                        hashtable[entry.Key] = element.Update();
            //                        break;
            //                    }
            //            }
            //        }
            //        else
            //        {
            //            hashtable.Add(text[j] + text[j + 1].ToString(), new Element(text[j] + text[j + 1].ToString()));
            //            groups.Add(text[j] + text[j + 1].ToString());
            //        }
            //    }

            //    _analisis.Add(hashtable.Values.Cast<Element>().ToList());
            //}

            return _analisis;
        }
    }
}