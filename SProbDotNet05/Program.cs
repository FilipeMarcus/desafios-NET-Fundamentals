using System;
using System.Collections.Generic;

namespace SProbDotNet05
{
    class Desafio05
    {
        static List<int> filaChegada = new List<int>();
        static List<int> filaOrdenada = new List<int>();
        static void Main(string[] args)
        {
            //Console.Write("Nº Casos de Teste: ");
            if (int.TryParse(Console.ReadLine(), out int casosTeste) && casosTeste >=1 
                && casosTeste <=1000)
            {
                int filas = 1;
                while (filas <= casosTeste)
                {
                    int mudancas = 0; 
                    if (int.TryParse(Console.ReadLine(), out int numClientes) && numClientes >= 1
                        && numClientes <= 1000)
                    {                        
                        string[] smsLine = Console.ReadLine().Trim().Split(' ');
                        for(int contador = 0; contador < numClientes; contador++)
                        {
                            if (int.TryParse(smsLine[contador], out int number) && number >= 1 && number <= 1000)
                            {
                                filaChegada.Add(number);
                                filaOrdenada.Add(number);
                            }
                        }
                        filaOrdenada.Sort();
                        filaOrdenada.Reverse();
                        for (int contador = 0; contador < numClientes; contador++)
                        {
                            if (filaOrdenada[contador] == filaChegada[contador])
                            {
                                mudancas += 1;
                            }
                        }
                        Console.WriteLine(mudancas);
                    }
                    filas += 1;
                    filaChegada.Clear();
                    filaOrdenada.Clear();
                }   
            }
        }
    }
}