using System;

namespace Lesson03HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = {"Emily", "Harry", "Rupert", "Clara", "Lily", "Michael"};

            for(int i = 0; i < nameArray.Length; i++)
            {
                Console.WriteLine("Have you seen " + nameArray[i] + "?");
            }

            for(int i = nameArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Have you seen " + nameArray[i] + "?");
            }
        }
    }
}