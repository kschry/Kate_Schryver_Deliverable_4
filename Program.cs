/* 
Author: Kate Schryver
Date: 02/07/2023
Description: The first 25 numbers of the Fibonacci sequence
*/
using System;
namespace Kate_Schryver_Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25] ;
            int a = 2;
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            foreach (int element in fibonacci)
            {
                fibonacci[0] = fibonacci[a - 1] + fibonacci[a - 2];
                Console.WriteLine ("Fibonacci number " + element + "= " + fibonacci[element]);
            }

        }
    }
}

          