using System;
using System.Collections.Generic;

namespace SProbDotNet03
{
    class Desafio03
    {
        static void Main(string[] args)
        {   // Implemente a solução aqui
            List<string> listaCompras = new List<string>();
            int contador;
            // Digite o Numero de listas
            if (int.TryParse(Console.ReadLine(), out int testes) && testes < 100)
            {
                for (int i = 1; i <= 99; i++)
                {               
                    string[] lista = TrimSpacesBetweenString(Console.ReadLine().ToLower()).Trim().Split(' ');
                    contador = 0;
                        
                    foreach (string item in lista)
                    {
                        Console.WriteLine("lenght: " + lista[contador].Length);
                        if ( lista[contador].Length > 0 && lista[contador].Length < 21 )
                        {   
                            Console.WriteLine("char: " + lista[contador].Length);
                            contador += 1;
                            Console.WriteLine("teve: " + contador + " items na lista");
                            if (contador >= 999)
                            {
                                //Console.WriteLine("retornei");
                                contador = 0;
                                return;
                            }
                            if (!listaCompras.Contains(item))
                            {
                                //Console.WriteLine("meu item: " + item);
                                listaCompras.Add(item);
                            }
                        }
                        else
                        {
                            //Console.WriteLine("tamanho incompativel");
                            break;
                        }
                    }
                    listaCompras.Sort();
                    Console.WriteLine(string.Join(" ", listaCompras));
                    listaCompras.Clear();
                }
            }
            else
            {
                //Console.WriteLine("retornei");
                return;
            }
        }
        public static string TrimSpacesBetweenString(string s)
        {
        var mystring  = s.Split(new string[] {" "}, StringSplitOptions.None);
        string result = string.Empty;
        foreach (var mstr in mystring)
        {
            var ss = mstr.Trim();
            if (!string.IsNullOrEmpty(ss))
            {
                result = result + ss+" ";
            }
        }
        return result.Trim();
        }
    }
}