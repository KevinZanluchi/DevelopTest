using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pedra_Papel_Tesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            int mode = Choose_mode();
            bool game = true;
            bool choose_Mode = false;
            while (game)
            {
                if (choose_Mode)
                {
                    mode = Choose_mode();
                }
                int round = Round();
                if (mode == 1)
                {
                    PlayerVsComp(round, mode);
                }
                else
                {
                    CompVsComp(round, mode);
                }

                switch (Menu_pos_game())
                {
                    case 1:
                        choose_Mode = true;
                        break;
                    case 2:
                        choose_Mode = false;
                        break;
                    case 3:
                        game = false;
                        break;
                }
                Console.Clear();

            }
            

        }

        // function to choose the mode
        static int Choose_mode()
        {
            bool mode_game = false;
            while (!mode_game)
            {
                Console.WriteLine("Escolha o modo de jogo:");
                Console.WriteLine("Digite 1 para Player vs Computador");
                Console.WriteLine("Digite 2 para Computador vs Computador");
                Console.WriteLine("Qual modo deseja jogar?");
                int mode = Convert.ToInt32(Console.ReadLine());
                if (mode == 1 || mode == 2)
                {
                    return mode;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Valor invalido, certifique-se que digitou uma das opções!");
                    Console.WriteLine();
                }
            }
            return 0;
        }

        //function to choose number of rounds
        static int Round()
        {
            Console.Clear();
            Console.WriteLine("Digite o número de rounds que deseja jogar nesse modo:");
            return Convert.ToInt32(Console.ReadLine());
        }

        //function player's move
        static int Move_player()
        {
            Console.WriteLine("Faça a sua jogada!");
            Console.WriteLine("Digite 1 para Pedra");
            Console.WriteLine("Digite 2 para Papel");
            Console.WriteLine("Digite 3 para Tesoura");
            return Convert.ToInt32(Console.ReadLine());
        }

        // function Computer's move
        static int Move_comp()
        {
            Random rand = new Random();
            return rand.Next(1, 4);
        }


        // function to see who won the round
        static int Win_round(int player1, int player2)
        {
            switch (player1)
            {
                case 1:
                    switch (player2)
                    {
                        case 1:
                            return 2;
                        case 2:
                            return 0;
                        case 3:
                            return 1;
                    }
                    break;
                case 2:
                    switch (player2)
                    {
                        case 1:
                            return 1;
                        case 2:
                            return 2;
                        case 3:
                            return 0;
                    }
                    break;
                case 3:
                    switch (player2)
                    {
                        case 1:
                            return 0;
                        case 2:
                            return 1;
                        case 3:
                            return 2;
                    }
                    break;
            }
            return 4;
        }

        // function to see who won the game
        static void Win_game(int player1, int player2, int mode)
        {
            if (mode == 1)
            {

                if (player1 > player2)
                {
                    Console.WriteLine("Meu Parabéns!!! Você Ganhou!!!");
                }
                else if (player1 < player2)
                {
                    Console.WriteLine("Você Perdeu...");
                }
                else if (player1 == player2)
                {
                    Console.WriteLine("Empate!");
                }
            }
            else
            {
                if (player1 > player2)
                {
                    Console.WriteLine("Computador 1 é o vencedor!!!");
                }
                else if (player1 < player2)
                {
                    Console.WriteLine("Computador 2 é o vencedor!!!");
                }
                else if (player1 == player2)
                {
                    Console.WriteLine("Empate!");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }

        //function return the name of computer'choise
        static string Name(int name)
        {
            if (name == 1)
            {
                return "Pedra";
            }else if ( name == 2)
            {
                return "Papel";
            }
            else
            {
                return "Tesoura";
            }
        }

        //function of menu after game 
        static int Menu_pos_game()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Digite 1 se deseja continuar jogando e alterar o modo de jogo.");
            Console.WriteLine("Digite 2 se deseja continuar jogando no mesmo modo de jogo.");
            Console.WriteLine("Digite 3 se deseja sair do jogo.");
            return Convert.ToInt32(Console.ReadLine());
        }

        //function the game player vs computer
        static void PlayerVsComp(int round, int mode)
        {
            int score_Player = 0;
            int score_Comp = 0;
            for (int i = 1; i <= round; i++)
            {
                Console.Clear();
                Console.WriteLine("Rodada " + i + " PLACAR: Player " + score_Player + " VS Computador " + score_Comp);
                int move_Player = Move_player();
                Thread.Sleep(20);
                int move_Comp = Move_comp();
                int win_Round = Win_round(move_Player, move_Comp);
                Console.Clear();
                Console.WriteLine("Você jogou " + Name(move_Player) + " contra " + Name(move_Comp) + " do computador.");
                Console.WriteLine();
                switch (win_Round)
                {
                    case 0:
                        Console.WriteLine("Computador ganhou essa rodada!");
                        score_Comp++;
                        break;
                    case 1:
                        Console.WriteLine("Você ganhou essa rodada!");
                        score_Player++;
                        break;
                    case 2:
                        Console.WriteLine("Empate!");
                        break;
                }
                Console.WriteLine("Digite uma tecla para continuar...");
                Console.ReadLine();
            }
            Console.Clear();
            Win_game(score_Player, score_Comp, mode);
        }

        // function the game computer vs computer
        static void CompVsComp(int round, int mode)
        {
            int score_Comp1 = 0;
            int score_Comp2 = 0;
            for (int i = 1; i <= round; i++)
            {
                Console.Clear();
                Console.WriteLine("Rodada " + i + " PLACAR: Computador1 " + score_Comp1 + " VS Computador2 " + score_Comp2);
                Console.WriteLine();
                int move_Comp1 = Move_comp();
                Thread.Sleep(20);
                int move_Comp2 = Move_comp();
                int win_Round = Win_round(move_Comp1, move_Comp2);
                Console.WriteLine("Computador1 jogou " + Name(move_Comp1) + " contra " + Name(move_Comp2) + " do computador2.");
                Console.WriteLine();
                switch (win_Round)
                {
                    case 0:
                        Console.WriteLine("Computador 2 ganhou essa rodada!");
                        score_Comp2++;
                        break;
                    case 1:
                        Console.WriteLine("Computador 1 ganhou essa rodada!");
                        score_Comp1++;
                        break;
                    case 2:
                        Console.WriteLine("Empate!");
                        break;
                }
                Console.WriteLine("Digite uma tecla para continuar...");
                Console.ReadLine();
            }
            Console.Clear();
            Win_game(score_Comp1, score_Comp2, mode);
        }

    }
}
