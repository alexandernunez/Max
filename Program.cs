using System;
using System.Collections.Generic;
using  System.Linq;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list to store the numbers
            List<int> numberList = new List<int>();
            
            // Pronting the user with the list of numbers
            Console.WriteLine("Please enter a list of integers, pressing enter after each one. When finish input 0 ");
            
            // Declaring the variables for store the numbers passed by the user
            int input;
        
            //Adding the values to the list until the user input = 0
            do
            {
            input = int.Parse(Console.ReadLine());
            numberList.Add(input);
            } while (input!=0);
            //removing 0 from the list
            numberList.Remove(0);

            // Calling the funcion Max and storing its return int the variable maxNumber
            int maxNumber = Max(numberList);
            Console.WriteLine("The maximum number is: "+maxNumber);
        }

        private static int Max(List<int> numberList)
        {
            // Using the function Max from the System.Linq library
            int maxNumber = numberList.Max();
            return maxNumber;
        }
    }
}
