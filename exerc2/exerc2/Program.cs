using System;

namespace exer2
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

            int answer5 = Modulus(1, 2);
            Console.WriteLine(answer5);

        }
    }
}