using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Aluno : Pessoa
    {
        public int Nota { get; set; }
        // override significa sobre escrita
        public override void Apresentar()
        { 
            Console.WriteLine($"Ola, meu nome é {Nome} e sou um Aluno nota {Nota}");
        }
    }
}
