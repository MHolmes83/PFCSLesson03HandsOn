using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] theBeatles = new string[] { "John", "George", "Paul", "Ringo" };

            Console.WriteLine(theBeatles[3]);
            Console.WriteLine(theBeatles[0]);
            Console.WriteLine(theBeatles.Length);

            string[] groceryList = new string[4];
            groceryList[0] = "bread";
            groceryList[1] = "eggs";
            groceryList[2] = "milk";
            groceryList[3] = "tea";

            Console.WriteLine(groceryList[1]);
            groceryList[1] = "beans";
            Console.WriteLine(groceryList[1]);

            int[] highestArizonaTemperatures = { 120, 122, 121, 118, 119 };
            Console.WriteLine(highestArizonaTemperatures[0]);
            Console.WriteLine(highestArizonaTemperatures[4]);

            string[] musician = new string[4];
            musician[0] = "John";
            musician[1] = "Mike";
            musician[2] = "Joe";
            musician[3] = "Kevin";

            Console.WriteLine(musician[3]);
            Console.WriteLine(musician.Length);

            string[] grade = {"A", "B", "C", "D", "F"};
            
            Console.WriteLine(grade[0]);
            Console.WriteLine(grade.Length);

            int myNumber = 1;

            /* while(myNumber <= 10)
            {
                Console.WriteLine(myNumber);
                myNumber++;
            } */

            do
            {
                Console.WriteLine(myNumber);
                myNumber++;
            } while (myNumber < 10);

           /*  for(int count = 10; count > 0; count--)
            {
                Console.WriteLine(count);
            }

            Console.WriteLine("Lift Off!"); */

            int count = 10;

            for(; count > 0; count--)
            {
                Console.WriteLine(count);
            }

            Console.WriteLine("Lift Off!");


            string[] myArray = {"Albert", "Kirsten", "Hester", "Henry"};

            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i] + ", hello!");
            }

            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] results = new int[numbers.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                results[i] = numbers[i] * 2;
            }

            Console.WriteLine(results);
        }
    }
}

