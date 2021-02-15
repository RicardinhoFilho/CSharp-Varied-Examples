using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoLinqEOperadorWhere
{
    public class Aluno 
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
    }
}
