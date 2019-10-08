using System;
using System.Collections.Generic;
using System.Linq;


namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetMean()
            int n = 0;
            int res = GetMean(n);
            Console.WriteLine(res);

            //DisplayPattern()
            int nn = 3;
            DisplayPattern(nn);

            //MinMaxSum()
            int[] arr = { 4, 1, 9, 3, 2, 10, 8, 6, 5, 7 };
            MinMaxSum(arr);


            //LargestUniqueNumber()
            int[] A = { 5, 7, 3, 9, 4, 9, 8, 3, 1 };
            Console.WriteLine("Largest integer occuring once = {0}\n", LargestUniqueNumber(A));


        }




        /* Complete the method to find out the mean of digits of a number
         Example:
         Input:281
         Output:3
         public int Getmean(int n)*/

        public static int GetMean(int n)
        {
            try
            {
                //handle the error case. There might be more elegant solution.
                if (n == 0)
                {
                    return 0;
                }

                //Create a list to store numbers
                List<int> storage = new List<int>();
                int digit;
                int temp = n;
                int total = 0;

                while (temp > 0)
                {
                    digit = temp % 10;

                    storage.Add(digit);

                    temp /= 10;
                }

                foreach (int el in storage)
                {
                    total = total + el;
                }

                return total / storage.Count;


            }

            catch
            {
                Console.WriteLine("Exception occurred while computing GetMean()");
            }

            return 0;
        }


        /*Complete the method to display the following pattern till n rows:
         * input = 3
         * Output is below
         * 1
         *12
        *123*/

        public static void DisplayPattern(int n)
        {
            try
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = n - i; j > 1; j--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(j + 1);
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("exception for DisplayPatterm");
            }

        }



        /* Find min and max sum by summing 9 of the 10 integers in the array.  No dublicates elements. Time Complexity should be  O(n)*/
        /*We were also able to use dictionary*/

        public static void MinMaxSum(int[] arr)
        {
            try
            {
                int minSum;
                int maxSum;
                int total = 0;

                int max = arr[0];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }

                int min = arr[0];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }

                foreach (int el in arr)
                {
                    total = total + el;
                }

                Console.WriteLine("Min Values Sum" + " " + (total - max));
                Console.WriteLine("Max Values Sum" + " " + (total - min));


            }

            catch
            {
                Console.WriteLine("MaxMinSum()");
            }


        }


        /*  Input: [5,7,3,9,4,9,8,3,1]
        Output: 8
        Explanation: 
        The maximum integer in the array is 9 but it is repeated. The number 8 occurs only once, so it's the answer.*/


        public static int LargestUniqueNumber(int[] A)
        {
            try
            {
                //List to save dublicate values
                var dublicates = new List<int>();
                int largestUnique;

                //Create dict and count occurence of each element in the given array
                Dictionary<int, int> dict = new Dictionary<int, int>();

                foreach (int element in A)
                {
                    if (dict.ContainsKey(element))
                    {
                        dict[element] = dict[element] + 1;
                    }
                    else
                    {
                        dict[element] = 1;
                    }
                }

                // if there is all non unique 
                if(!dict.ContainsValue(1))
                {
                    return -1;
                }

                // add dublicates to the dict
                foreach(var val in dict)
                {
                    if(val.Value > 1)
                    {
                        dublicates.Add(val.Key);
                    }
                }

                //Remove dublicate keys
                dublicates.ForEach(k => dict.Remove(k));

                //Get the largestUnique value
                largestUnique = dict.Keys.Max();

                return largestUnique;







            }


            catch
            {
                Console.WriteLine("LargestUniqueNumber()");
            }

            return 0;


        }




    }

}