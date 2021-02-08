using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComLista
{
    class Program
    {
        static void Main(string[] args)
        {

            GerarLista gerarLista = new GerarLista();
            //Acima chamamos a classe "gerarLista" como tamanho padrão, que neste exemplo é 5 desta forma iremos gastar muito tempo para criarmos está 
            //lista uma vez que iremos demorar para descobrir qual o tamanho suficiente de nosso vetor
            Contato contato1 = new Contato("alex", 9999999);
            Contato contato2 = new Contato("alex", 9999999);
            Contato contato3 = new Contato("alex", 9999999);
            Contato contato4 = new Contato("alex", 9999999);
            Contato contato5 = new Contato("alex", 9999999);
            Contato contato6 = new Contato("alex", 9999999);
            Contato contato7 = new Contato("alex", 9999999);
            Contato contato8 = new Contato("alex", 9999999);
            Contato contato9 = new Contato("alex", 9999999);
            Contato contato10 = new Contato("alex", 9999999);
            Contato contato11 = new Contato("alex", 9999999);
            Contato contato12 = new Contato("alex", 9999999);
            Contato contato13 = new Contato("alex", 9999999);
            /*Acima criamos 13 contartos ficticios somente para exemplificar*/

            gerarLista.Adicionar(contato1);
            gerarLista.Adicionar(contato2);
            gerarLista.Adicionar(contato3);
            gerarLista.Adicionar(contato4);
            gerarLista.Adicionar(contato5);
            gerarLista.Adicionar(contato6);
            gerarLista.Adicionar(contato7);
            gerarLista.Adicionar(contato8);
            gerarLista.Adicionar(contato9);
            gerarLista.Adicionar(contato10);
            gerarLista.Adicionar(contato11);
            gerarLista.Adicionar(contato12);
            gerarLista.Adicionar(contato13);

            /*Por conta de termosd definido como tamanho inicial de nosso vetor da classe gerar lista = 5, 
             * iremos demorar muito para adicionarmos todos os contatos */


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Percebam que por conta de somarmos de 1 em 1 o tamanho de nosso vetor acaba que " +
                "demoramos muito relendo nosso vetor," +
                " tornando nossa operação realmente muito cara!" +
                "para corrigirmos isto podemos passar um novo valor para nosso capacidadeInicial");

            Console.ReadLine();

            GerarLista gerarLista2 = new GerarLista(14);
            /*Agora passamos por paramêtro o tamanho minímo de 14*/
            gerarLista2.Adicionar(contato1);
            gerarLista2.Adicionar(contato2);
            gerarLista2.Adicionar(contato3);
            gerarLista2.Adicionar(contato4);
            gerarLista2.Adicionar(contato5);
            gerarLista2.Adicionar(contato6);
            gerarLista2.Adicionar(contato7);
            gerarLista2.Adicionar(contato8);
            gerarLista2.Adicionar(contato9);
            gerarLista2.Adicionar(contato10);
            gerarLista2.Adicionar(contato11);
            gerarLista2.Adicionar(contato12);
            gerarLista2.Adicionar(contato13);

            /*Desta forma não precisamos atribuir um novo tamanho para nosso vetor montando a lista muito mais rápido*/


            Console.WriteLine("Agora que passamos um tamanho minimo suficiente para nosso vetor, nossa lista foi criada de forma muito mais rapida");

            Console.Read();

        }
    /// <summary>
    /// Classe contato responsável por gerar um novo contato
    /// </summary>
        public class Contato 
        {
            /// <summary>
            /// Passamos como contrutor 2 parametros 
            /// </summary>
            /// <param name="nome"></param>
            /// <param name="numero"></param>
            public Contato(string nome, int numero)
            {
                Nome = nome;
                Numero = numero;
            }
            public string Nome { get; private set; }
            public int Numero { get; private set; }
        }
        /// <summary>
        /// classe responsável por gerar nossa lista de contatos 
        /// </summary>
        public class GerarLista
        {

            private Contato[] _contatos;
            private int proxPosicao = 0;
            private int capacidadeInicial;
            /// <summary>
            /// Recebe um construtor opcional 
            /// </summary>
            /// <param name="_capacidadeInicial">É um construtor que recebe um valor padrão que pode ser alterado caso seja passado outro valor por paramêtro</param>
            public GerarLista(int _capacidadeInicial = 5)
            {
                _contatos = new Contato[_capacidadeInicial];

                capacidadeInicial = _capacidadeInicial;
            }
            /// <summary>
            /// Método chamado para adicionarmos os contatos selecionados à nossa lista
            /// </summary>
            /// <param name="contatos">Rece como parametro um Contato</param>
            public void Adicionar(Contato contatos)
            {
                Console.WriteLine($"Adicionando contato[{proxPosicao}]");
                VerificarCapacidade(proxPosicao + 1);

                _contatos[proxPosicao] = contatos;

                proxPosicao++;


            }
            /// <summary>
            /// Como nosso tamanho padrão é 5 pode ser que falte espaço em nosso aray este método é quem aumenta nosso array até que todos os contatos sejam listados
            /// </summary>
            /// <param name="tamanhoNecessario">Tamanho necessário é o parametro que define se devemos aumentar nosso array ou não</param>
            void VerificarCapacidade(int tamanhoNecessario)
            {

                if (tamanhoNecessario < capacidadeInicial)
                {
                    return;
                }
                int novoTamanho = tamanhoNecessario++;

                Contato[] novoArray = new Contato[novoTamanho];

                for (int i = 0; i < _contatos.Length; i++)
                {
                    novoArray[i] = _contatos[i];
                    Console.WriteLine($"Passando valor vetor contatos[{i}] para vetor novoArray[{i}]");
                }

                _contatos = novoArray;
            }


        }
    }
}
