using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoExtensoesAClasseList
{
    public static class  ListExtensao
    {
        /// <summary>
        /// Método responsável por facilitar adiçao de elementos em nossa lista 
        /// </summary>
        /// <param name="listaDeInteiros">Para tornarmos apenas uma extenção o parametro lista de inteiros 
        /// recebe a construção "this" "List<tipo>" para definir que é apenas uma extensão da classe 
        /// list podendo ser chamada por ela</param>
        /// <param name="itens">Recebe a construção "params int[]" definindo que se trata de um vetor váriavel
        /// facilitando seu uso</param>
        public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
        {
            foreach (int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
        /// <summary>
        /// Método criado para escrevermos a a lista na tela
        /// </summary>
        /// <param name="listaDeInteiros">Para tornarmos apenas uma extenção o parametro lista de inteiros 
        /// recebe a construção "this" "List<tipo>" para definir que é apenas uma extensão da classe 
        /// list podendo ser chamada por ela</param>
        /// <param name="itens">Recebe a construção "params int[]" definindo que se trata de um vetor váriavel
        /// facilitando seu uso</param>
        public static void EscreveListaNaTela(this List<int> listaDeInteiros)
        {
            foreach (int item in listaDeInteiros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
