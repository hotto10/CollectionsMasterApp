using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var numbers = new int[50];
            


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);
            //ReverseArray(myNumberArray);

            //TODO: Print the first number of the array
            Console.WriteLine(numbers[0]);

            //TODO: Print the last number of the array//
            Console.WriteLine(numbers[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists

            NumberPrinter(numbers);
           
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            

            
            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(numbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            Array.Reverse(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
           
            Console.WriteLine("Sorted numbers:");
            
             Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> myList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {myList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(myList);

            //TODO: Print the new capacity
           Console.WriteLine($"New Capacity: {myList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int userNumber;
            bool isNumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out userNumber);


            } while (isNumber == false);   

            NumberChecker(myList, userNumber);
            
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(myList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            NumberPrinter(myList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var myArray = myList.ToArray();

            //TODO: Clear the list
            myList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (var i in numbers)
            {
                if (numbers [i] % 3 == 0) 
                    numbers [i] = 0;
            }

                NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count -1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);

                }
            }
            NumberPrinter(numberList);
        }
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes this is the number you are looking for");

            }
            else
            {
                Console.WriteLine($"This is not the number you are looking for");
            }
            
        }

        private static void Populater(List<int> numberList)
        {
            while (numberList.Count < 51) 
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);
                numberList.Add(number);

            }

            NumberPrinter(numberList);

        }

        private static void Populater(int[] numbers)
        {
            
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int val = rng.Next(0, 50);
                numbers[i] = val;
            }
        }        

        private static void ReverseArray(int[] array)
        {
            List<int> list = new List<int>();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                list.Add(array[i]);
            }

            //Reassigning the list to the array

            array = list.ToArray();
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
