using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploheranca1.Exercicio2
{
    internal class Gato:Mamiferos
    {
        public string cordosolhos { get; set; }
        public override void barulho()
        {
            Console.WriteLine(this.raca + " MIAUUUUUUU");
        }
    }
}
