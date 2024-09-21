namespace Guess_The_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");

            Console.WriteLine(randomNum);

            while (!isCorrrectGuess)
            {
                
            }

            Console.ReadKey();
        }
    }
}
