// See https://aka.ms/new-console-template for more information


namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Wagner";
            p1.Idade = 46;

            p1.Apresentar();
        }
    }
}
