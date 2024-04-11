using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of lines:");
        int H = Convert.ToInt32(Console.ReadLine());

        for (int i = H; i >= 1; i--)
        {
            Console.WriteLine();
            for (int j = i; j >= 1; j--)
            {
                Console.Write('-');
            }
        }

        Console.ReadLine();
    }
}
