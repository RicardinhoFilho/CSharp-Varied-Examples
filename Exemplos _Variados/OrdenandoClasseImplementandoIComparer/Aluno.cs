using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoClasseImplementandoIComparer
{
    public class Aluno:IComparable
    {
        public int _id { get; private set; }
        public string _nome { get; private set; }

        public Aluno(int id, string nome)
        {
            _id = id;
            _nome = nome;
        }

        public int CompareTo(object obj)
        {
            var outroAluno = obj as Aluno; //sempre comparamos o "Aluno"(instância atual) com "outro aluno", que é recebido por parâmetro durante a execução

            /*Como implementar a assinatura da interface "ICombarable" "CompareTo:"
              
              -Retornamos 1 caso queiramos que o elemento que veio por parâmetro precede a instancia(outroAluno < Aluno)
              -Retornamos 0 caso queiramos que eles sejam equivalentes(outroAluno == Aluno)    
              -Retornamos -1 caso queiramos que a isntancia preceda o elementoq ue veio por parâmetro(Aluno < outroAluno)  

             */

            if (outroAluno == null)//quando outroAluno for nulo quero que ele esteja no final da lista
            {
                return 1;
            }

            if (_id < outroAluno._id)//se o identificador de nossa instância for menor que o identificador de outroAluno, nossa instância precede 
            {
                return -1;
            }

            if (_id > outroAluno._id)//se o identificador de nossa instância for maior que o identificadpor de outroAluno, outroAluno precede nossa instância
            {
                return 1;
            }

            return 0;//a ultima alternativa, se ambos forem iguais retorne que são equivalentes

        }
    }
}
