using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = "123456";
            p1.Descricao = "TV";

            Console.WriteLine($"P1: {p1}");

            Produto p2 = p1;
            p2.Descricao = "CELULAR";

            Console.WriteLine($"P2: {p2}");
            Console.WriteLine($"P1: {p1}");

            p2 = new Produto()
            {
                Codigo = "567890",
                Descricao = "LAPTOP"
            };

            Console.WriteLine($"New P2: {p2}");
            Console.WriteLine($"P1: {p1}");

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("STRUCT");

            Ponto pt1;
            pt1.X = 10.0;
            pt1.Y = 15;

            Console.WriteLine($"PT1: {pt1}");

            Ponto pt2 = pt1;
            pt2.Y = 20;

            Console.WriteLine($"PT2: {pt2}");
            Console.WriteLine($"P1T: {pt1}");

            pt2 = new Ponto()
            {
                X = 30,
                Y = 60
            };

            Console.WriteLine($"New PT2: {pt2}");
            Console.WriteLine($"PT1: {pt1}");

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Nullables");

            double? x = null;//sinal de ? indica que é nullable (pode aceitar null)

            double y = x ?? 5.0;// y = x se x não for null, senão y = 5

            Console.WriteLine($"y antes de alteração é : {y.ToString()}");

            Console.Write("Digite um valor para x: ");
            x = double.Parse(Console.ReadLine());

            y = x ?? 5.0;

            Console.WriteLine($"y após alteração é : {y.ToString()}");

            Console.ReadKey();
        }
    }
}
