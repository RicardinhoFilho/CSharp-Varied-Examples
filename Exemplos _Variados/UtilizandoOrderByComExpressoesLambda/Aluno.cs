using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoOrderByComExpressoesLambda
{
    public class Aluno : IComparable
    {
        public string Nome { get; private set; }
        public int Numero { get; private set; }
        public double Nota { get;  private set; }

        public Aluno(string nome,int numero)
        {
            Nome = nome;
            Numero = numero;
        }

        public void AtribuirNota(double nota)
        {
            Nota = nota;
        }

        public int CompareTo(object obj)//implementamos a interface IComparale para definir como ordenação padrão a ordenação alfabética por nome do aluno
        {
            Aluno outroAluno = obj as Aluno;

            

            return Nome.CompareTo(outroAluno.Nome);
        }
    }
}
