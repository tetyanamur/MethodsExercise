using System;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            if (name == "Tetyana")
            {
                Console.WriteLine("Good afternoon, Tetyana!");
            }
            else
            {
                Console.WriteLine($"Sorry for misunderstanding! How is your day {name}");
            }
            Console.WriteLine("My favorite color is white. What is your favorite color?");
            string color = Console.ReadLine();
            if (color == "Green")
            {
                Console.WriteLine("Green is a beautiful color.");
            }
            else
            {
                Console.WriteLine($"Awesome.! I love that {color} pattern as well.");
            }
            Console.WriteLine("This is intertsting that people like different colors. Aslo, many people like animals. What is your favorite animal?.");
            string animal = Console.ReadLine();
            if (animal == "Raccoon")
            {
                Console.WriteLine("Raccoons are funny animals.");
            }
            else
            {
                Console.WriteLine($"Awesome. I think that {animal} are very exclusive.");
            }
            Console.WriteLine("Besides animals, a lot of people pick different kinds of music bands to listen. What is your favorite band?");
            string band = Console.ReadLine();
            if (name == "Queen")
            {
                Console.WriteLine("Great. I enjoy listening to  Queen as well.");
            }
            else
            {
                Console.WriteLine($"Good. In fact, my musical taste is the same. I also have multiple {band} recordings. ");
            }

            Console.WriteLine($" Finally, I will tell you a story. Once a {animal} went to the {color} garden and heard a band called {band}. He liked the music.");
        }
    }
}














