using System;

namespace _9_ClassesChallenge
{
    public class Human
    {
        public string lastName = "Smyth";
        public string firstName = "Pat";

        public string eyeColor;
        public int age;

        private int weight;

        public int Weight { 
            get {
                return this.weight;
            } 
            set {
                if (value <= 0 || value > 400) {
                    throw new Exception("Weight must be between 0 and 400");
                }
                this.weight = value;
            } 
        }
        //default constructor is needed when you create a parameterized constructor.
        public Human() { }

        public Human(string lastName, string firstName) {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public Human(string lastName, string firstName, string eyeColor) {
            this.lastName = lastName;
            this.firstName = firstName;
            this.eyeColor = eyeColor;
        }

        public Human(string lastName, string firstName, int age) {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
        }

        public Human(string lastName, string firstName, string eyeColor, int age) {
            this.lastName = lastName;
            this.firstName = firstName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        public void AboutMe()
        {
            if (eyeColor == null && age == 0) {
                Console.WriteLine($"My name is {firstName} {lastName}.");
            } else if (eyeColor == null) {
                Console.WriteLine($"My name is {firstName} {lastName}. My age is {age}.");
            } else if (age == 0) {
                Console.WriteLine($"My name is {firstName} {lastName}. My eye color is {eyeColor}.");
            } else {
                Console.WriteLine($"My name is {firstName} {lastName}. My eye color is {eyeColor} and my age is {age}.");
            }
        }

    }//end of class
}//end of namespace