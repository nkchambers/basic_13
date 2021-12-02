using System;

namespace basic_13
{
    public static class Excercises
    {
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
        public static void LoopArray(int[] numArray) 
        {
            foreach(int num in numArray) 
            {
                Console.WriteLine(num);
            }
        }

        
        //-----------------------Find and Return Max Value From Any Given Array------------------------
        public static int FindMax(int[] numbers) 
        {
            int max = Int32.MinValue;
            
            foreach(int num in numbers) 
            {
                if (num > max) 
                {
                    max = num;
                }
            }
            
            Console.WriteLine($"Max Number in Array: {max}");

            return max;
        }

        
        //-----------------------Get Average From Any Given Integer Array------------------------
        public static void GetAverage(int[] numbers) 
        {
            int sum = 0;

            foreach(int num in numbers) 
            {
                sum += num;
            }
            
            int average = sum / numbers.Length;
            
            Console.WriteLine($"AVERAGE: {average}");

        }


        //-----------------------Array With Odd Numbers------------------------
        public static int[] OddArray() 
        {
            //Determine size of array in order to return odds only in between 1-255
            int size = (255/2) + 1;

            //Create array with size variable
            int[] odds = new int[size];

            int i = 0;
            for(int num = 1; num <= 255; num += 2)
            {
                odds[i] = num;
                i++;
            }

            Console.WriteLine($"Odds Array: {odds}");
            return odds;
        }


        //-----------------------Greater Than Y------------------------
        public static int GreaterThanY(int[] numbers, int y) 
        {
            int total = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > y)
                {
                    total++;
                }
            }
            
            Console.WriteLine($"Total: {total}");
            return total;
        }


        //-----------------------Square the Values------------------------
        public static void SquareArrayValues(int[] numbers) 
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine($"Squared Array Values: {numbers}");
        }


        //-----------------------Eliminate Negative Numbers------------------------
        public static void EliminateNegatives(int[] numbers) 
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine($"Array Without Negatives: {numbers}");
        }


        //-----------------------Min, Max and Average------------------------
        public static void MinMaxAverage(int[] numbers) 
        {
            int min = Int32.MaxValue,
                max = Int32.MinValue,
                sum = 0;
            
            foreach(int num in numbers)
            {
                sum += num;
                if(num > max)
                    max = num;
                if(num < min)
                    min = num;
            }
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Average: {(float)sum / numbers.Length}");
        }


        //-----------------------Shifting Values in Array------------------------
        public static void ShiftArrayValues(int[] numbers) 
        {
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
            Console.WriteLine(numbers);
        }


        //-----------------------Number to String------------------------
        public static object[] NumToString(int[] numbers) 
        {
            object[] newArr = new object[numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0)
                    newArr[i] = "Dojo";
                else
                    newArr[i] = numbers[i];
            }
            Console.WriteLine($"{newArr}");
            return newArr;
        }

    }
}