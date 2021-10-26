using System;

namespace Generator
{
    class Program
    {
        const string stopKey = "nein";
        static readonly Random random = new();

        static void Main(string[] args)
        {
            bool stopEatingCake = false;
            do
            {
                var userReponse = GetUserReponse();

                stopEatingCake = userReponse == stopKey;

                if (!stopEatingCake)
                {
                    var number = random.Next(1, 100);

                    if (number < 60)
                    {
                        Console.WriteLine("App thinks that you have already eaten enough cake for today!");
                    }
                    else
                    {
                        Console.WriteLine("Let's eat one more piece!");
                    }
                }
                else
                {
                    Console.WriteLine("Completed for now");
                }
            }
            while (!stopEatingCake);
        }

        static string GetUserReponse()
        {
            Console.WriteLine($"Would you like to know if you need one extra piece of cake? Press any key " +
                $"to continue or '{stopKey}' to stop");

            var result = Console.ReadLine();

            return result;
        }
    }
}
