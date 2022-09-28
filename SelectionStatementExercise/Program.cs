namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int G = 700;
            Console.WriteLine("Can you guess my favorite number bewtween 1 and 1000?");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput < G)
            {
                Console.WriteLine("TO Low!!");
            }
            else if (userInput > 1000)
            {
                Console.WriteLine("Nevermind");
            }
            else
            {
                Console.WriteLine("TO HIGH!");
            }
        }
    }
}