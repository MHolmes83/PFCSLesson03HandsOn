using System;

namespace CollectionAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] theBeatles = new string[]
            {
                "John", "George", "Paul", "Ringo"
            };

            Console.WriteLine(theBeatles[3]);
            Console.WriteLine(theBeatles[0]);

            string[] Metallica = new string[]
            {
                "James", "Lars", "Kirk", "Robert"
            };

            Console.WriteLine(Metallica.Length);

            string[] groceryList = new string[4];
            groceryList[0] = "bread";
            groceryList[1] = "eggs";
            groceryList[2] = "milk";
            groceryList[3] = "tea";

            Console.WriteLine(groceryList[1]);

            groceryList[1] = "beans";

            Console.WriteLine(groceryList[1]);

            int[] highestArizonaTemperatures = 
            {
                120, 122, 121, 118, 119
            };
            
            Console.WriteLine(highestArizonaTemperatures[0]);

            Console.WriteLine(highestArizonaTemperatures[4]);

            int myNumber = 1;

            while (myNumber < 10)
            {
                Console.WriteLine(myNumber);
                myNumber++;
            }

            int anotherNumber = 1;

            do
            {
                Console.WriteLine(anotherNumber);
                anotherNumber++;
            } while (anotherNumber < 10);

            for (int count = 10; count > 0; count--)
            {
                Console.WriteLine(count);
            }

            Console.WriteLine("Lift Off!");

            string[] myArray = 
            {
                "Oliver", "Diggle", "Felicity", "Laurel"
            };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i] + ", welcome to Team Arrow!");
            }
        }
    }
}