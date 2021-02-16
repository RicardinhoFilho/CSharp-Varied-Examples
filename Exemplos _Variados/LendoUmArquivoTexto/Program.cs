using System;
using System.Collections.Generic;
using System.IO;//Diretiva necessária para utilização dos metodos como para ler Stream
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendoUmArquivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var endereco = "C:\\Users\\User\\Desktop\\Exemplos _Variados\\LendoUmArquivoTexto\\ListaDeNomes.txt";

            using (var fluxoDeArquivo = new FileStream(endereco, FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxoDeArquivo))
                {
                    //var linha = leitor.ReadLine();//ReadLine nos retorna a primeira linha
                    //var linha = leitor.ReadToEnd();//Este método 'Read to end'lê todas as linhas e retorna em uma string gigante 

                    while (!leitor.EndOfStream)//enquanto leitor for diferente de EndOfStream-> método que nos retorna o final do arquivo texto
                    {
                        var linha = leitor.ReadLine();//linha receberá o valor da linha do arquivo texto
                        Console.WriteLine(linha);//escreve na tela a linha
                    }
                }
            }


                Console.ReadLine();
        }
    }
}
