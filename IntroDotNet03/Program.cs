using System;

namespace IntroDotNet03
{
    class Desafio03
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" ");

            //  todas as variaveis devem ser Double para manter a precisao
            double coxinhas = int.Parse(line[0]);
            double competidores = int.Parse(line[1]);
            double conta = coxinhas / competidores;
            //  conversao para String para mostrar o resultado real sem arredondar
            Console.WriteLine(conta.ToString("N2"));
        }
    }
}
