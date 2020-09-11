using System;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UseFor();
            Console.WriteLine();
            UseDoWhile();
            Console.WriteLine();
            UseWhile();
        }
        
        public static void UseFor()
        {
            for (int i = 0; i < 50; i ++) {
                if (i % 2 == 1) {
                    Console.Write(i + " ");
                }
            }
        }

        public static void UseDoWhile()
        {
            int i = 0;
            do {
                Console.Write(i + " ");
                i += 2;
            } while(i <= 50);
        }

        public static void UseWhile()
        {
            int i = 3;
            while(i < 100) {
                if (i % 5 == 0) {
                    Console.WriteLine("Skipping this number");
                } else {
                    Console.WriteLine(i);
                }
                i += 3;
            }
        }
    }
}
// 2. create a do/while loop that displays the even integers from 0 to 50.
// 3. create a while loop that displays the multiples of 3 integers from 0 to 100. 
//     1. Design the loop so that when every multiple of 3 and 5 coincide(like 15, 30, etc), you print "skipping this number" instead of the number.
//     2. Design the loop so that when you get above 100 you automatically stop the loop with a break statement.