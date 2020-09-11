using System;

namespace _9_ClassesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human pat = new Human();
            Human alex = new Human() {firstName = "Alex", lastName = "Wong"};

            pat.AboutMe();
            alex.AboutMe();

            Human eye = new Human() {eyeColor = "Brown"};
            Human age = new Human() {age = 21};
            Human jenna = new Human() {
                firstName = "Jenna",
                lastName = "Liang",
                eyeColor = "Brown",
                age = 22
            };

            eye.AboutMe();
            age.AboutMe();
            jenna.AboutMe();

            Human weight = new Human();
            weight.Weight = 120;
            Console.WriteLine(weight.Weight);
            // weight.Weight = 500;
        }
    }
}
