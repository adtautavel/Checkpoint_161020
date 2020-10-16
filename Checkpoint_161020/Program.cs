using System;

namespace Checkpoint_161020
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] testArray = { 1, 10, 3, 0 };
            DisplayArray(testArray);
            Console.WriteLine("Array sum is : " + Sum(testArray));
            Console.WriteLine("Array mean is : " + Mean(testArray));
            
            int[] sortedArray;
            sortedArray = Sort(testArray);
            Console.WriteLine("Sorted Array is : ");
            DisplayArray(sortedArray);
                       
        }

        static void DisplayArray(int[] array)
        {
            Console.Write("{ ");
            foreach (int i in array)
            {
                Console.Write(" "+ i +" ");
            }
            Console.Write(" }");
            Console.WriteLine("");
        }

        static int Sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }

        static int Mean(int[] array)
        {
            int mean = (Sum(array) / array.Length);
            return mean;
        }

        static int[] Sort(int[] array)
        {
            int[] sortedArray = array;

            for (int i=0; i<(sortedArray.Length-1); i++)
            {
                for (int j=i+1; j>0; j--)
                {
                    if(sortedArray[j-1]>sortedArray[j])
                    {
                        int temp = sortedArray[j-1];
                        sortedArray[j-1] = sortedArray[j];
                        sortedArray[j] = temp;
                    }
                }
            }
            return sortedArray;
        }
    }   

}
