using Postulados_Golomb.Models;

namespace Postulados_Golomb.Extensions
{
    /// <summary>
    ///     Definicion de clase elementExtension para extensiones de la clase ELement
    /// </summary>
    internal static class elementExtension
    {
        /// <summary>
        ///     Metodo actualizar para aumentar el numero de ocurrencias de un elemento
        /// </summary>
        /// <param name="element">Elemento que se actualizara</param>
        /// <returns>Elemento actualizado en concurrencias</returns>
        public static Element Update(this Element element)
        {
            element.Coincidences += 1;
            return element;
        }
    }
}