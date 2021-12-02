using System;
using System.Collections.Generic;

namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintNumbers();
            //PrintOdds();
            //PrintSum();
            //LoopArray(new int[] {2, 4, 6, 8, 10}); 

        }


        //------------------------------Print Numbers 1-255------------------------------------------
        public static void PrintNumbers() 
        {
            for(int i = 1; i < 256; i++) 
            {
                Console.WriteLine(i);
            }
        }


        //------------------------Print Odd Numbers between 1-255-----------------------------------
        public static void PrintOdds() 
        {
            for(int i = 1; i < 256; i++)
            {
                if(i % 2 != 0) 
                {
                    Console.WriteLine(i);
                }
                else 
                {
                    continue;
                }
            }
        }


        //-----------------------Print Numbers Along with Sum of Numbers between 1-255------------------------
        public static void PrintSum() 
        {
            int sum = 0;
            for(int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine($"Number: {i} / Curent Sum: {sum}");
            }
        }


        //-----------------------Iterate through Array and Print values to console------------------------
        public static void LoopArray(int[] numbers) 
        {
            for(var i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }
        }

        
        //-----------------------Find and Return Max Value From Any Given Array------------------------
        /*public static int FindMax(int[] numbers) 
        {
            
        }*/

        
        //-----------------------Get Average From Any Given Integer Array------------------------
        /*public static void GetAverage(int[] numbers) 
        {
            
        }*/


        //-----------------------Array With Odd Numbers------------------------
        /*public static int[] OddArray() 
        {
            
        }*/


        //-----------------------Greater Than Y------------------------
        /*public static int GreaterThanY(int[] numbers, int y) 
        {
            
        }*/


        //-----------------------Square the Values------------------------
        /*public static void SquareArrayValues(int[] numbers) 
        {
            
        }*/


        //-----------------------Eliminate Negative Numbers------------------------
        /*public static void EliminateNegatives(int[] numbers) 
        {
            
        }*/


        //-----------------------Min, Max and Average------------------------
        /*public static void MinMaxAverage(int[] numbers) 
        {
            
        }*/


        //-----------------------Shifting Values in Array------------------------
        /*public static void EliminateNegatives(int[] numbers) 
        {
            
        }*/


        //-----------------------Number to String------------------------
        /*public static object[] NumToString(int[] numbers) 
        {
            
        }*/




    }
}
