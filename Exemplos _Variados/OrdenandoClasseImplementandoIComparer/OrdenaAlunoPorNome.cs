
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoClasseImplementandoIComparer
{
    public class OrdenaAlunoPorNome : IComparer<Aluno>
    {
        public int Compare(Aluno x, Aluno y)
        {
            return x._nome.CompareTo(y._nome);
        }
    }
}
