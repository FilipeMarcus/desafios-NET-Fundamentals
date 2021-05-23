using System;

class Desafio01 {
    static void Main() {
    //declare suas variaveis corretamente
    uint notasValidadas = 0;
    double nota1 = 0, nota2, media;

        //continue a solução ou implemente da sua maneira

        while ( notasValidadas < 2 ) {
        
            if ( Double.TryParse(Console.ReadLine(), out double digitacao) && digitacao >= 0 && digitacao <= 10 ) 
            {
                if ( notasValidadas == 0 )
                {
                    nota1 = digitacao;
                    notasValidadas = 1;
                }
                else if ( notasValidadas == 1)
                {
                    nota2 = digitacao;
                    notasValidadas = 2;
                    media = ( nota1 + nota2 ) / 2;
                    Console.Write("media = ");
                    Console.WriteLine(media.ToString("N2"));

                    while ( true )
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        if (double.TryParse(Console.ReadLine(), out double resposta))
                        {
                            if ( resposta < 1 || resposta > 2)
                            {
                                continue;
                            }
                            else if (resposta == 1)
                            {
                                notasValidadas = 0;
                                break;
                            }
                            else if (resposta == 2)
                            {
                                break;
                            }
                        }
                    }
                }   
            }
            else 
            {
                Console.WriteLine("nota invalida");
            } 
        }
    }
}