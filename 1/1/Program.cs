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


            int alvo = 20;



            Console.WriteLine("Escolha um Personagem (escrevendo seu nome): ");
            Console.WriteLine("ARQUEIRO    --    BARBARO    --    GUERREIRO");

            string personagem = Console.ReadLine();


            if (personagem == "ARQUEIRO")
            {
                dano = arqueiroFOR + arqueiroAGI;

                int result = dano - alvo;


                if (result >= 0)
                {
                    Console.WriteLine("ALVO DESTRUIDO");

                }
                else
                {
                    Console.WriteLine("ALVO NÂO FOI DESTRUIDO");
                }

            }
            else 
            {
                if (personagem == "BARBARO")
                {

                    dano = barbaroFOR + barbaroAGI;

                    int result = dano - alvo;


                    if (result >= 0)
                    {
                        Console.WriteLine("ALVO DESTRUIDO");

                    }
                    else
                    {
                        Console.WriteLine("ALVO NÂO FOI DESTRUIDO");
                    }

                }
                else
                {
                    if (personagem == "GUERREIRO")
                    {

                        dano = guerreiroFOR + guerreiroAGI;

                        int result = dano - alvo;


                        if (result >= 0)
                        {
                            Console.WriteLine("ALVO DESTRUIDO");

                        }
                        else
                        {
                            Console.WriteLine("ALVO NÂO FOI DESTRUIDO");
                        }

                    }
                }
            }
        }
    }
}
