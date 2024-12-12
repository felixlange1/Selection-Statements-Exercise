namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 3;
            
            Console.WriteLine("Guess the number:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low.");
            }
            
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high.");
            }

            else
            {
                Console.WriteLine("Correct!");
            }
            
        }
    }
}
