using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");


        }

        public static string GetName()
        {
            Console.WriteLine("What is your name?");
            string result = Console.ReadLine();
            return result;
        }

        public static void GreetFriend(string name)
        {
            //Greeting should be: Hello, nameVar. You are my friend
            //Ex: Hello, Jim. You are my friend
            Console.WriteLine($"Hello, {name}. You are my friend");
        }

        public static double GetNumber()
        {
            bool isDouble;
            double result;

            Console.WriteLine("Please enter a number");          
            string input = Console.ReadLine();

            isDouble = double.TryParse(input, out result);

            if (isDouble) {
                return result;
            } else {
                //Should throw FormatException if the user did not input a number
                throw new FormatException();
            }
        }

        public static int GetAction()
        {
            bool isInt;
            int action;

            do {
                Console.WriteLine("What action do you want to do with your numbers?");
                Console.WriteLine("1) add 2) subtract 3) multiply 4) divide");
                string input = Console.ReadLine();

                isInt = int.TryParse(input, out action);
            } while(action < 1 || action > 4);

            return action;
        }

        public static double DoAction(double x, double y, int z)
        {
            double result;

            if (z == 1) {
                //add
                result = x + y;
            } else if (z == 2) {
                //subtract
                result = y - x;
            } else if (z == 3) {
                //multiply
                result = x * y;
            } else if (z == 4){
                //divide
                result = x / y;
            } else {
                throw new FormatException();
            }
            
            return result;
        }
    }
}
