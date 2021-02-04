using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConhecendoExpressoesRegulares_Match_IsMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Neste exemplo vamos coletar o número de telefone de uma frase qualquer, parta exemplificar Match e IsMatch

            //string padraoTel = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padraoTel = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padraoTel = "[0-9]{4}-[0-9]{4}";//As quatro formas criadas estão corretas, na ultima utilizamos entre "{}" o número de repetições que queremos para está regra, no caso[0-9]
            //string padraoTel = "[0-9]{4,5}-{0,1}[0-9]{4}"; //Nesta outra forma estamos lembrando que um telefone pode possuir um 9 na frente ou qualquer outro número, é muito comum, por isso utilizaos entre "4,5", para demonstrar que podemos ter de 4 a 5 caracteres ant6es do hífen. Também nos preocupamos com o fato de pessoas digitarem ou não o hífen, para isso atribuimos o hígen {0,1} demonstrando que podemos ou não escrever um número com o hífen
            string padraoTel = "[0-9]{4,5}-?[0-9]{4}";//neste ultimo exemplo estamos utilizando "?" que tem a mesma funcionalidade que estavamos utilizando antes com {0,1}
            //A variavel acima define a construção de um telefone padrão, dois grupos de 4 números separador por "-" que variam de 0 à 9.
            string fraseTeste1 = "Meu número é 999224456";
            string fraseTeste2 = "Meu número é 99922-4456";
            string fraseTeste3 = "Meu número é 99224456";

            //Acima temos duas frases para fazermos a exemplificação

            Console.WriteLine(Regex.IsMatch(fraseTeste1, padraoTel));
            Console.WriteLine(Regex.IsMatch(fraseTeste2, padraoTel));
            Console.WriteLine(Regex.IsMatch(fraseTeste3, padraoTel));
            //As construções acima validam se as frases contém um número de telefone ou não

            Console.WriteLine(Regex.Match(fraseTeste1, padraoTel));
            Console.WriteLine(Regex.Match(fraseTeste2, padraoTel));
            Console.WriteLine(Regex.Match(fraseTeste3, padraoTel));
            //As construções acima escrevem na tela o número dos telefones presentes nas frases, caso eles se enquadrem com o padrão



            Console.ReadLine();
        }
    }
}
