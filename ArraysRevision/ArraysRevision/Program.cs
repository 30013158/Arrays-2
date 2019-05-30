//Array revision inside collection
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision
{
    class Program
    {
        static void Main(string[] args)
        {   //ques 1 
            int[] nums = new int[50];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            { nums[i] = rand.Next(1, 100); }
            Display(nums);

            //ques 2
            Console.WriteLine($"The value is located at index {FindIndex(nums)}");
            Console.ReadLine();

            //ques 3
            int[] copiedArray = new int[nums.Length];
            Array.Copy(nums, copiedArray, nums.Length);
            Display(copiedArray);
            Console.ReadLine();
            //ques4
            Array.Sort(copiedArray);
            Console.WriteLine("--sorted array--");
            Display(copiedArray);
            Console.WriteLine("--reversed array--");
            Array.Reverse(copiedArray);
            Display(copiedArray);
            Console.ReadLine();



        }
        static int FindIndex(int[] arr)//arr is just a parameter passed when the method is called it is replaced by nums
        { Console.WriteLine("Write the number whose index you want to find .");
            int input = int.Parse(Console.ReadLine());
            return Array.IndexOf(arr, input);
        }
        static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                if ((i + 1) % 10 == 0)
                Console.WriteLine();
            }
        }
    }
}
