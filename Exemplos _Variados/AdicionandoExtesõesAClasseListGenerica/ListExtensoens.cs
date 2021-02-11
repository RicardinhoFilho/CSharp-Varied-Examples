using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoExtesõesAClasseListGenerica
{
    public static class ListExtensoens
    {
        /// <summary>
        /// Método genérico "T" que facilita a ad~ção de itens em nossa lista
        /// </summary>
        /// <typeparam name="T">Tipo Genérico</typeparam>
        /// <param name="listaDeInteiros"></param>
        /// <param name="itens"></param>
        public static void AdicionarVarios<T>(this List<T> listaDeInteiros, params T[] itens)
        {
            foreach (T item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
        /// <summary>
        /// Método que escreve na tela nossa lista genérica
        /// </summary>
        /// <typeparam name="T">Tipo genérico</typeparam>
        /// <param name="listaDeInteiros"></param>
        public static void EscreveListaNaTela<T>(this List<T> listaDeInteiros)
        {
            foreach (T item in listaDeInteiros)
            {
                Console.WriteLine(item);
            }
        }
    }
}

