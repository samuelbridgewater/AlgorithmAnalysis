using System;
using System.Collections.Generic;


namespace AAnalysis
{
    public class Algorithms
    {
        
        // returns the maximum value in an array
        public int ArrayMax(int[] Array)
        {
            int max = Array[0];
            int numofElements = Array.Length;
            for(int i = 1; i < numofElements; i++)
            {
                if(Array[i] > max)
                {
                    max = Array[i];
                }
            }
            return max;
        }


        // returns the index of a given value within an array
        public int SequentialSearch(int[] Array, int Key)
        {
            int numOfElements = Array.Length;
            int i = 0;

            while (i < numOfElements && Key != Array[i])
            {
                i += 1;
            }

            if (i < numOfElements)
            {
                return i;
            }
            else
            {
                return -1;
            }
            
        }

        // returns the most frequent number in an array
        public void FrequentNumber(int[] numbers)
        {
            Dictionary<int, int> bucket = new Dictionary<int, int>();
            int maxInt = int.MinValue;
            int maxCount = 0;
            int count;

            foreach (var i in numbers)
            {

                if (bucket.TryGetValue(i, out count))
                {
                    count++;
                    bucket[i] = count;
                }
                else
                {
                    count = 1;
                    bucket.Add(i, count);
                }

                if (count >= maxCount)
                {
                    maxInt = i;
                    maxCount = count;
                }

            }

            Console.WriteLine("Maximum integer: {0}, appearing {1} times", maxInt, maxCount);

        }

        // returns an array, defined by the user in the console
        public int[] UserInputArray()
        {
            Console.Write("How many integers in the array? ");
            int numOfElements = Convert.ToInt32(Console.ReadLine());
            int[] usersArray = new int[numOfElements];

            for (int i = 0; i < numOfElements; i++)
            {
                Console.Write("Element {0}:  ", i);
                usersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return usersArray;
        }

        // natural numbers using recursion
        static int naturalNumbers(int startValue, int count)
        {
            if (count < 1)
            {
                return startValue;
            }
            count--;
            Console.Write("{0}", startValue);
            return naturalNumbers(startValue + 1, count);
        }


        static void Main(string[] args)
        {
            Algorithms arrayObj = new Algorithms();


            int[] array = { 43, 2, 34, 56, 42, 12, 56, 43, 56, 5, 6, 77 };
            int[] numbers = { 5, 4, 3, 32, 6, 6, 3, 3, 2, 2, 31, 1, 32, 4, 3, 4, 5, 6 };

           
            Console.WriteLine(arrayObj.SequentialSearch(array, 12));
            Console.WriteLine(arrayObj.ArrayMax(array));
            arrayObj.FrequentNumber(numbers);

            int[] users= arrayObj.UserInputArray();
            //foreach (var element in users)
            //{
            //    Console.Write("{0}, ", element);
            //}

            //naturalNumbers(0, 100);
          
        }
    }
}
