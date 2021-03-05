using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dano;

            int arqueiroFOR = 5;
            int arqueiroAGI = 12;

            int barbaroFOR = 15;
            int barbaroAGI = 5;

            int guerreiroFOR = 10;
            int guerreiroAGI = 8;


            Random alvo = new Random();



            Console.WriteLine("Escolha um Personagem (escrevendo seu nome): ");
            Console.WriteLine("ARQUEIRO    --    BARBARO    --    GUERREIRO");

            string personagem = Console.ReadLine();


            if (personagem == "ARQUEIRO")
            {
                dano = arqueiroFOR + arqueiroAGI;

                int result = dano - alvo.Next(25);


                if (result >= 0)
                {
                    Console.WriteLine("ALVO DESTRUIDO", result);

                }
                else
                {
                    Console.WriteLine("ALVO NÂO FOI DESTRUIDO", result);
                }

            }
            else 
            {
                if (personagem == "BARBARO")
                {

                    dano = barbaroFOR + barbaroAGI;

                    int result = dano - alvo.Next(25);


                    if (result >= 0)
                    {
                        Console.WriteLine("ALVO DESTRUIDO", result);

                    }
                    else
                    {
                        Console.WriteLine("ALVO NÂO FOI DESTRUIDO", result);
                    }

                }
                else
                {
                    if (personagem == "GUERREIRO")
                    {

                        dano = guerreiroFOR + guerreiroAGI;

                        int result = dano - alvo.Next(25);


                        if (result >= 0)
                        {
                            Console.WriteLine("ALVO DESTRUIDO", result);

                        }
                        else
                        {
                            Console.WriteLine("ALVO NÂO FOI DESTRUIDO", result);
                        }

                    }
                }
            }
        }
    }
}
