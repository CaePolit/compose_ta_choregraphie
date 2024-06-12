using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] moves = new string[32];
        int l = 0;
        while (l < 32)
        {
            Console.WriteLine("insert move " + l);
            string move = Console.ReadLine();
            if (move == "done")
            {
                break;
            }
            else
            {
                moves[l] = move;
                l++;
            }
        }
        Console.WriteLine("number of iterations: ");
        int iterations = default;
        string userEntry = default;

        while (true)
        {
            userEntry = Console.ReadLine();
            if (int.TryParse(userEntry, out iterations))
            {
                if (iterations > 0)
                    break;
                else
                    Console.WriteLine("invalid input");
            }
        }

        int i = 0;
        while (i < iterations)
        {
            foreach (string move in moves)
            {
                Console.WriteLine(move);
            }
            i++;
        }

    }
}