using System;

namespace methods_example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = Sum(4, 5);
            var quot = Division(10, 5);
            var product = Multip(4, 5);
            var diff = Division(20, 5);

            Console.WriteLine(answer);
            Console.WriteLine(diff);    
            Console.WriteLine(quot);
            Console.WriteLine(product);

            CreateAStory();
                    
        }
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public static double Division(double num1, double num2)
        {

            return num1 / num2;
        }

        public static int Multip(int x, int y)
        { 
            return x * y;

        }
        public static void CreateAStory()
        {
            Console.WriteLine("What is your name?");
            var username = Console.ReadLine();

            Console.WriteLine("What is your favorite color hat?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();


            Console.WriteLine("What band sings your favorite song?");
            var band = Console.ReadLine();
            Console.WriteLine($"Hello {username},Your favorite band {band} are coming to the BJCC this summer.Wear your favorite {color} hat because we will be there.Do not forget to ask when you are there, 'What does the {animal} say?'");

        }
         

    }

}
 