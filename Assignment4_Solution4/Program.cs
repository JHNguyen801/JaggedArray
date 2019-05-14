// This program uses a rectangular 3 x 2 jagged array holding values, initializing 
// the array, then computing and display the sum, product, and sum of 
// the product array elements & rows
using System;

namespace Assignment4_Solution4
{
    class Program
    {
        // This method is to display the value of the array, compute the sum, product 
        // and sum of the product of the columns for each row.
        static void Main(string[] args)
        {
            // Declare variable for sum, product and the sum of product
            int sum = 0;
            int sumproduct = 0;

            // Intialize the values of jagged array
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] { 1, 3, 20, -1 };
            jaggedArr[1] = new int[] { -1, 7, 2 };
            jaggedArr[2] = new int[] { -3, -4 };

            //Display the message 
            Console.WriteLine("The array contains:");
            // for loop that display the elements in the jagged array
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                int[] innerArray = jaggedArr[i];
                for (int element = 0; element < innerArray.Length; element++)
                {
                    sum += innerArray[element];
                    Console.Write("{0,4}", +innerArray[element]);
                }
                Console.WriteLine();
            }
            //Display the sum of elements in jagged array
            Console.WriteLine("\nThe sum of the array elements is " + sum + "\n");

            // loop for product in rows of jagged array
            foreach (int[] array in jaggedArr)
            {
                int product = 1;
                foreach (int element in array)
                    product = product * element;
                {
                    //Display the Subarray row and products of elements
                    Console.WriteLine("Subarray product for Row {0} is {1}", array.ToString(),
                        product);
                }
                // Compute the sum of the product of the array
                sumproduct = sumproduct + product;
            }
            //Display the sum of products value of the array
            Console.WriteLine("\nSum of the Product is " + sumproduct);
        }
    }
}
