using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Classes
{
    internal class Alunos:Pessoa
    {
        public string responsavel { get; set; }
        public string turma { get; set; }
        public string matricula { get; set; }
    }
}
