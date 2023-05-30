using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello you! Try and guess my favorite number!");

          var r = new Random();
            var favNumber = r.Next(1, 1000);

           var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber) 
            {
                Console.WriteLine("Too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else 
            { 
                Console.WriteLine("Congradulations!");
            }

        }
    }
}
