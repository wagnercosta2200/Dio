// Encapsulamento   serve para proteger uma classe e definir limites para alteração de suas propriedaes


namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //valores validos
            Retangulo r = new Retangulo();
            r.DefenirMedidadas(30, 30);

            Console.WriteLine($"Area : { r.ObterArea()}");

            //valores invalidos
            Retangulo r2 = new Retangulo();
            r2.DefenirMedidadas(0, 30);

            Console.WriteLine($"Area : { r2.ObterArea()}");

        }
    }
}


