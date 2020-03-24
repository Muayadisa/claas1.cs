using System;

namespace lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array: ");

            // length of array: 
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());


            // number to multiply cells. 
            Console.WriteLine("Enter number to multiply: ");
            int NumToMul = Convert.ToInt32(Console.ReadLine());


            // initialize array: 
            int[] arr = new int[lengthOfArray];

            Console.WriteLine($"Num of elements: {lengthOfArray}, num to mul:{NumToMul}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * NumToMul;
                Console.Write(arr[i] + ", ");
            }
        }
    }
}