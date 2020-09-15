using System;

namespace VariablesCS
{
    class Program
    {
        static void variablesMethod()
        {
            // Declare Variables
            var numberOfCupsOfCoffee = 3;
            var fullName = "Josh Mann";
            // Using DateTime to represent current date as string
            var today = DateTime.Now.ToString("dd/MM/yyyy");

            // Output to Terminal
            Console.WriteLine($"numberOfCupsOfCoffee: {numberOfCupsOfCoffee} fullName: {fullName} today: {today}");

            // Get Input from User
            Console.Write("What is your name? ");
            var userName = Console.ReadLine();

            if (userName == "Alice")
            {
                Console.WriteLine("Hi, Alice! Welcome Back!");
            }
            else
            {
                Console.WriteLine($"Hello, {userName}.");
            }

            // Getting different types of input from the user
            Console.WriteLine("Please enter 2 numbers.");
            Console.Write("First Number: ");
            string firstNumberAsString = Console.ReadLine();
            Console.Write("Second Number: ");
            string secondNumberAsString = Console.ReadLine();


            // Converting string input into numbers
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);


            // Doing Math

            // sum
            var sum = firstOperand + secondOperand;
            Console.WriteLine($"sum = {sum}");
            // difference
            var difference = firstOperand - secondOperand;
            Console.WriteLine($"difference = {difference}");
            // product
            var product = firstOperand * secondOperand;
            Console.WriteLine($"product = {product}");
            // quotient
            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"quotient = {quotient}");
            // remainder (modulo)
            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"remainder = {remainder}");
            // display
        }
        static void Main(string[] args)
        {
            variablesMethod();
        }
    }
}
