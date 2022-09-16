using System;

namespace SecondLargestNumber
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           

            int[] num = { 20, 10, 30, 50, 40 };//taking an unsorted array
            int n=num.Length;//finding its length

            //sort the array
            Array.Sort(num);//sorting using sort method
            Console.WriteLine("second largest number is " + num[n-2]);
        }
    }
}
    

