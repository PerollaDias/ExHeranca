using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Classes
{
    internal class Funcionarios:Pessoa
    {
        public double salario { get; set; }
        public string SIAP { get; set; }
        public int CH { get; set; }
    }
}
