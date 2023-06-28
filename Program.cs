using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Random random = new Random();
            for (int i = 0; i < 3 ; i++)
            {
                int[] programNumbers = new int[3];
                for (int j = 0; j < programNumbers.Length; j++)
                {
                    programNumbers[j] = random.Next(1, 25);

                }
                Console.WriteLine("числа программы");
                for (int j = 0; j < programNumbers.Length; j++)
                {
                    Console.WriteLine(programNumbers[j] + "");
                }
                Console.WriteLine();

                Console.WriteLine("Введите число от 1 до 24");
                int userNumber=int.Parse(Console.ReadLine());
                if (Array.Exists(programNumbers, number => number == userNumber))
                {
                    score++;

                }

         
            }
            if (score >=2)
            {
                Console.WriteLine("вин");

            }
            else
            {

                Console.WriteLine("проигрыш");
            }
           
        }

    }
}
