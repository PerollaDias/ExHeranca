namespace exemploheranca1.Exercicio2
{
    internal class Mamiferos
    {
        public DateOnly datanasc { get; set; }
        public string raca { get; set; }
        public virtual void barulho()
        {
            Console.WriteLine(this.raca + " Fazendo barulho");
        }

    }
}
