﻿{
 string[] escolhas = { "pedra", "papel", "tesoura" };
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Escolha: pedra, papel ou tesoura (ou 'sair' para encerrar):");
            string escolhaUsuario = Console.ReadLine().ToLower();

            if (escolhaUsuario == "sair")
                break;

            if (Array.IndexOf(escolhas, escolhaUsuario) == -1)
            {
                Console.WriteLine("Escolha inválida. Tente novamente.");
                continue;
            }

            string escolhaComputador = escolhas[random.Next(0, escolhas.Length)];
            Console.WriteLine($"Computador escolheu: {escolhaComputador}");

            if (escolhaUsuario == escolhaComputador)
            {
                Console.WriteLine("Empate!");
            }
            else if ((escolhaUsuario == "pedra" && escolhaComputador == "tesoura") ||
                     (escolhaUsuario == "papel" && escolhaComputador == "pedra") ||
                     (escolhaUsuario == "tesoura" && escolhaComputador == "papel"))
            {
                Console.WriteLine("Você venceu!");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }

            Console.WriteLine(); // Linha em branco para separar as rodadas
        }

        Console.WriteLine("Obrigado por jogar!");
    }

