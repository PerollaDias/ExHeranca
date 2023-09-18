using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Exercicio2
{
    internal class Cachorro:Mamiferos
    {
        public int peso { get; set; }
        public override void barulho()
        {
            Console.WriteLine(this.raca + " AUAUUUUUU");
        }
    }
}
