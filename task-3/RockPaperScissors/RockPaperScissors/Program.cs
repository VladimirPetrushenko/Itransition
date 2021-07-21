using System;
using System.Linq;
using System.Security.Cryptography;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!ValidateInputStringArray(args))
            {
                return;
            }
            while (true)
            { 
                byte[] HMACkey = RandomHMACKey();
                byte computer = ChoiceOfComputer(args.Length);
                byte[] HMAC = HMACSHA256(HMACkey, computer);
                Console.WriteLine("HMAC: " + CreateStringFromByteArray(HMAC));
                MainMenu(args);
                byte player = CheckInputNumber(args);
                if (player == 0)
                    break;
                Console.WriteLine("You move: " + args[player - 1]);
                Console.WriteLine("Computer move: " + args[computer - 1]);
                Console.WriteLine(WhoHasWon(player, computer, args.Length));
                Console.WriteLine("HMACkey: " + CreateStringFromByteArray(HMACkey));
            }
        }

        private static byte ChoiceOfComputer(int length)
        {
            Random random = new Random();
            int computerMove = random.Next(0, length) + 1;
            return (byte)computerMove;
        }

        private static byte[] RandomHMACKey()
        {
            RandomNumberGenerator generator = RandomNumberGenerator.Create();
            byte[] randomKey = new byte[16];
            generator.GetBytes(randomKey);
            return randomKey;
        }
        private static byte[] HMACSHA256(byte[] HMACkey, byte add)
        {
            SHA256 mySHA256 = SHA256.Create();
            string buffer = Convert.ToString(CreateStringFromByteArray(HMACkey)) + add;
            return mySHA256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(buffer));
        }
        private static void MainMenu(string[] args)
        {
            Console.WriteLine("available move:");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine((i + 1) + " - " + args[i]);
            }
            Console.WriteLine("0 - exit\n");
        }

        private static bool ValidateInputStringArray(string[] args)
        {
            if (args.Count() < 3)
            {
                Console.WriteLine("Invalid number of arguments, must be more than three arguments");
                return false;
            }
            if (args.Count() % 2 != 1 || args.Count() < 3)
            {
                Console.WriteLine("Invalid number of arguments, there must be an odd number of arguments");
                return false;
            }
            if (args.Distinct().Count() != args.Count())
            {
                Console.WriteLine("Arguments must not be repeated");
                Console.WriteLine("Correct: rock paper scissors");
                Console.WriteLine("Wrong: rock rock scissors");
                return false;
            }
            return true;
        }

        private static byte CheckInputNumber(string[] args)
        {
            int choice;
            while (true)
            {
                Console.Write("Enter your move:");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine($"Incorrect entry, you can only enter numbers from 0 to {args.Length}\n");
                    MainMenu(args);
                    continue;
                }
                if (choice <= args.Length && choice >= 0)
                    break;
                else
                {
                    Console.WriteLine($"Wrong value, you will get numbers from 0 to {args.Length}\n");
                    MainMenu(args);
                }
            }
            return (byte)choice;
        }
        private static string CreateStringFromByteArray(byte[] array)
        {
            string result = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                result+=$"{array[i]:X2}";
            }
            return result;
        }

        private static string WhoHasWon(int player, int computer, int countOfMoves)
        {
            if (player - computer == 0)
                return "draw";
            if (((player + countOfMoves) - computer) % countOfMoves > countOfMoves / 2) 
            {
                return "Computer win";
            }
            else
                return "Player win";
        }
    }
}
