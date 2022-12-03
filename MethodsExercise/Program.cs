using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(story());
           Console.WriteLine(Add(10, 15));
           Console.WriteLine(Substract(15, 10));
           Console.WriteLine(Multiply(2, 4));
           Console.WriteLine(Divide(4, 2));
           Console.WriteLine(Modulus(100, 5));
        }
        public static string story()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal");
            var animal = Console.ReadLine();
   
            return $"Hello, my name is {name}. My favorite color is {color}, and I like {animal}s";
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return (num1 % num2);
        }
    }
}
