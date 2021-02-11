using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoExtensoesAClasseList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaIdades = new List<int>();

            //adicionando elementos à nossa lista utilizando o método "Add"
            Console.WriteLine("Utilização método da classe list 'add' ");
            listaIdades.Add(2);
            listaIdades.Add(5);

            //adicionando elementos à nossa lista utilizando o método "AddRange"
            Console.WriteLine("Utilização método da classe list 'AddRange' ");
            int[] vetIdades = { 6, 7, 8 };
            listaIdades.AddRange(vetIdades);

            for (int i = 0; i < listaIdades.Count; i++) //Count é a propriedade que define o tamanho de nossa lista, neste caso lista de idades
            {
                Console.WriteLine(listaIdades[i]);
            }

            Console.ReadLine();

            /*Queremos adicionar varios elementos sem termos que nos preocuparmos com criar um vetor, 
            para isso iremos criar uma extenssão: */

            Console.WriteLine("Utilização de nossa extensão da classe list: 'AdicionarVarios' ");

            listaIdades.AdicionarVarios(9, 10, 11, 12, 13);//Como podemos perceber agora passamos os vários elementos por parametro diretamente, sem precisarmos criar um vetor com estes elementos antes de adicionarmos em nossa lista

            for (int i = 0; i < listaIdades.Count; i++)
            {
                Console.WriteLine(listaIdades[i]);
            }

            Console.ReadLine();

            /*Como percebemos que para escrevermios na tela os valores da lista gastamos 3 linhas, 
             * é interessante criarmos uma extensão que escreva estes valores em nossa tela, iremos utiliza-la abaixo: */

            Console.WriteLine("Utilização da extensão da classe 'list' : 'EscreveListaNaTela()"); 
            listaIdades.EscreveListaNaTela();

            Console.ReadKey();
        }
    }
}
