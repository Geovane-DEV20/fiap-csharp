﻿using System;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************");
            Console.WriteLine("***  JOKENPO  ***");
            Console.WriteLine("*****************");
            Console.WriteLine();
            Console.WriteLine("OPÇÕES DO JOGO");
            Console.WriteLine("-----------------");
            Console.WriteLine("[1] - Pedra");
            Console.WriteLine("[2] - Papel");
            Console.WriteLine("[3] - Tesoura");

            int pedra = 1;
            int papel = 2;
            int tesoura = 3;

            Console.WriteLine();
            Console.WriteLine("Qual a sua escolha? ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int computador = random.Next(1, 4);

            if (computador == pedra)
            {
                Console.WriteLine();
                Console.WriteLine("Computador escolheu Pedra");
            }
            else if (computador == papel)
            {
                Console.WriteLine();
                Console.WriteLine("Computador escolheu Papel");
            }
            else if (computador == tesoura)
            {
                Console.WriteLine();
                Console.WriteLine("Computador escolheu Tesoura");
            }

            if (escolha == pedra)
            {
                Console.WriteLine();
                Console.WriteLine("Você escolheu Pedra");
            }
            else if (escolha == papel)
            {
                Console.WriteLine();
                Console.WriteLine("Você escolheu Papel");
            }
            else if (escolha == tesoura)
            {
                Console.WriteLine();
                Console.WriteLine("Você escolheu Tesoura");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida");
            }


            if (1 <= escolha || escolha <= 3 && 1 <= computador || computador <= 3)
            {
                if (escolha == computador)
                {
                    Console.WriteLine();
                    Console.WriteLine("EMPATE");
                }
                else if (escolha - computador == -2 || escolha - computador == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** VOCÊ VENCEU !!! ***");
                }
                else 
                {
                    Console.WriteLine();
                    Console.WriteLine("COMPUTADOR GANHOU");
                }
            }
        }
    }
}

