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



namespace pract
{
    class Program
    {

        public static int Addition(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public static int Subtraction(int num1, int num2, int num3)
        {
            return num1 - num2 - num3;
        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        public static int Divide(int num1, int num2, int num3)
        {
            return num1 / num2 / num3;
        }
        public static int Modulus(int num1, int num2)
        {
            return (num1 % num2);
        }
        static void Main(string[] args)
        {
            int answer1 = Addition(5, 4, 7);
            Console.WriteLine(answer1);

            int answer2 = Subtraction(10, 5, 2);
            Console.WriteLine(answer2);

            int answer3 = Multiply(8, 7, 3);
            Console.WriteLine(answer3);

            int answer4 = Divide(40, 5, 4);
            Console.WriteLine(answer4);

            int answer5 = Modulus(answer4 - 1, 5);
            Console.WriteLine(answer5);

        }
    }
}










