using System;

namespace Polimorfismo// sobrescreve metodos das classes filhas para se comportarem de maneira diferente e ter sua implementação
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Resultado da pimeira soma: " + calc.Somar(10,10));
            Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 9));



            //Aluno p1 = new Aluno();
            //p1.Nome = "Wagner";
            //p1.Idade = 46;
            //p1.Nota = 10;
            //p1.Apresentar();
        }

    }
}