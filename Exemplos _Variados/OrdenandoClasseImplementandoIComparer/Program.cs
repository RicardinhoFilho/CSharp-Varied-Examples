using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoClasseImplementandoIComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*como vimos em nosso Projeto "OrdenandoUmaListDeClasseUtilizandoInterfaceICombarable" utilizamos aclasse IComparable
             atribuir uma regra de ordenação, neste caso nós atribuimios a regra de ordenar pelo campo id, entretanto, agora
             queremos ordenar pelo campo nome, para isso vamos criar uma classe chamad OrdenaAlunoPorNome e implementa-la*/

            var listaAlunos = new List<Aluno>()
            {
                new Aluno(3, "Fabio"),
                new Aluno(2, "Eliza"),
                new Aluno(1, "Adroaldo"),
                new Aluno(5, "Felipe"),
                new Aluno(4, "Natália")
            };
            Console.WriteLine("ANTES DA ORDENAÇÃO: ");
            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Id.{aluno._id}, Nome.{aluno._nome}");
            }
            Console.ReadLine();

            Console.WriteLine("APÓS ORDENAÇÃO DEFINIDA COMO PADRÃO NA CLASSE ALUNO(POR ID): ");
            listaAlunos.Sort();//se não passamos nenhum parâmetro ao método "Sort" ele nos ordena por padrão que neste caso está definido na classe Aluno
            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Id.{aluno._id}, Nome.{aluno._nome}");
            }
            Console.ReadLine();

            

            Console.ReadLine();

            Console.WriteLine("APÓS ORDENAÇÃO POR NOME IMPLEMENTADA PELA NOSSA CLASSE CRIADA NESTE PROJETO 'OrdenaAlunoPorNome'");
            listaAlunos.Sort(new OrdenaAlunoPorNome());//Para ordenarmos pelo nome, criamos uma nova instância da classe OrdenaAlunoPorNome como parâmeto do método Sort(new OrdenaAlunoPeloNome())
            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Id.{aluno._id}, Nome.{aluno._nome}");
            }
            Console.ReadLine();


        }
    }
}
