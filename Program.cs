using System;

namespace ConsoleApp3
{
    class Program
    {
        static void output(char[] arr)
        {
            System.Console.Write(" |-" + arr[0] + "-|-" + arr[1] + "-|-" + arr[2] + "-| \n");
            System.Console.Write(" |-" + arr[3] + "-|-" + arr[4] + "-|-" + arr[5] + "-| \n");
            System.Console.Write(" |-" + arr[6] + "-|-" + arr[7] + "-|-" + arr[8] + "-| \n");
        }

        static char Move_checker(int choice, char[] arr)
        {
            switch (choice)
            {
                case 1:
                    return arr[0];
                case 2:
                    return arr[1];
                case 3:
                    return arr[2];
                case 4:
                    return arr[3];
                case 5:
                    return arr[4];
                case 6:
                    return arr[5];
                case 7:
                    return arr[6];
                case 8:
                    return arr[7];
                case 9:
                    return arr[8];
                default:
                    { 
                    Console.Write("Error!!!");
                    return '-';
                    }
            }
        }

        static void movement(int player, char[] arr)
        {
            string a = Console.ReadLine();
            int choice = System.Convert.ToInt32(a);
            while (Move_checker(choice, arr) == 'X' || Move_checker(choice, arr) == '0')
                Console.WriteLine("This cell is occupy!\n");
            switch (choice)
            {
                case 1:
                    if (player == 1) arr[0] = 'X';
                    else arr[0] = '0';
                    break;
                case 2:
                    if (player == 1) arr[1] = 'X';
                    else arr[1] = '0';
                    break;
                case 3:
                    if (player == 1) arr[2] = 'X';
                    else arr[2] = '0';
                    break;
                case 4:
                    if (player == 1) arr[3] = 'X';
                    else arr[3] = '0';
                    break;
                case 5:
                    if (player == 1) arr[4] = 'X';
                    else arr[4] = '0';
                    break;
                case 6:
                    if (player == 1) arr[5] = 'X';
                    else arr[5] = '0';
                    break;
                case 7:
                    if (player == 1) arr[6] = 'X';
                    else arr[6] = '0';
                    break;
                case 8:
                    if (player == 1) arr[7] = 'X';
                    else arr[7] = '0';
                    break;
                case 9:
                    if (player == 1) arr[8] = 'X';
                    else arr[8] = '0';
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        static char checker(char[] arr)
        {
            for (int i = 0; i < 3; i++)
                if (arr[i * 3] == arr[i * 3 + 1] && arr[i * 3 + 1] == arr[i * 3 + 2])
                    return arr[i]; // 1-2-3 / 4-5-6 / 7-8-9
                else if (arr[i] == arr[i + 3] && arr[i + 3] == arr[i + 6])
                    return arr[i]; //1-4-7, 2-5-8 / 3-6-9
                else if ((arr[2] == arr[4] && arr[4] == arr[6]) || (arr[0] == arr[4] && arr[4] == arr[8]))
                    return arr[i]; // 1-5-9 / 3-5-7
            return '-'; // no winner
        }

        static void win(char winner)
        {
            if (winner == 'X') Console.WriteLine("Crosses win!");
            else if (winner == '0') Console.WriteLine("Noughts win!");
            else Console.WriteLine("Standoff!");
        }
        static void Main(string[] args)
        {
            char winner = '-';
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Console.WriteLine( " --- Noughts and crosses ---\n\n");
            Console.WriteLine("Below is the playing field:\n");
            output(arr);
            Console.WriteLine("Enter the cell number to make a move:\n");
            for (int mov = 1; mov <= 9; mov++)
            {
                if (mov % 2 != 0)
                {
                    Console.WriteLine("Crosses go: ");
                    movement(1,arr);
                }
                else
                {
                    Console.WriteLine("Noughts go: ");
                    movement(2,arr);
                }
                output(arr);
                if (mov >= 5)
                {
                    winner = checker(arr);
                    if (winner != '-') break;
                }
            }
            win(winner);
        }
    }
}
