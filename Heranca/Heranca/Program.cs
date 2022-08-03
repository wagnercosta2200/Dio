using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Wagner";
            p1.Idade = 46;

            p1.Apresentar();
        }
    }
}

