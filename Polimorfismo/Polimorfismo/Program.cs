using System;

namespace Polimorfismo// sobrescreve metodos das classes filhas para se comportarem de maneira diferente e ter sua implementação
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Wagner";
            p1.Idade = 46;
            p1.Nota = 10;
            p1.Apresentar();
        }

    }
}