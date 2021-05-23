using System;
using System.Text.RegularExpressions;

namespace SProbDotNet04
{
    class UsingRegexStringValidator
    {
        static void Main(string[] args)
        {
            string senhaEmTeste;
            do {
                senhaEmTeste = Console.ReadLine();

                if ( string.IsNullOrEmpty(senhaEmTeste) )
                {
                    break;
                }

                Regex textoRegex = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,32}$");
                
                var validacao = textoRegex.Match(senhaEmTeste);

                if (validacao.Success)
                {
                    Console.WriteLine("Senha valida.");
                }
                else
                {
                    Console.WriteLine("Senha invalida.");
                }
            }while (true);                  
        }
    }
}