using System;

namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] {2, 4, 6, 8, 4, 3, -2};
            
            Excercises.PrintNumbers();
            Excercises.PrintOdds();
            Excercises.PrintSum();
            Excercises.LoopArray(testArray); 
            Excercises.FindMax(testArray);
            Excercises.GetAverage(testArray);
            int[] odds = Excercises.OddArray();
            int total = Excercises.GreaterThanY(new int[] {2, 8, 10, 13, 4, 6}, 8);
            Excercises.SquareArrayValues(new int[] {2, 4, 6});
            Excercises.EliminateNegatives(new int[] {2, 4, 6, -2});
            Excercises.MinMaxAverage(testArray);
            Excercises.ShiftArrayValues(new int[] {2, 4, 6, 3, -2, -5});

            object[] objArr = Excercises.NumToString(testArray);




        }
    }
}
