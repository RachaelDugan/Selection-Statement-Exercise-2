using System.Reflection.Metadata;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            
            string favsub = Console.ReadLine();

            switch (favsub.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is the best!");
                    break;
                case "biology":
                    Console.WriteLine("Biology rocks!");
                    break;
                case "reading":
                    Console.WriteLine("I love to read!");
                    break;
                case "writing":
                    Console.WriteLine("Writing, I love telling stories!");
                    break;
                case "gym":
                    Console.WriteLine("I crush it in the Gym");
                    break;
                default:
                    Console.WriteLine("It's complicated");
                    break;


            }
        }
    }
}