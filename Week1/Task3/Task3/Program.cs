using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{     
    class Program
    {
        public static void Replace(int[] arr, int[] arr1, int k, int x, int n, string[] str)//function
        {
            

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(str[i]);//Converting from the string to the Int
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = k; j < x; j++)
                {
                    arr1[j] = arr[i];  // The second array's 2 elements equal to the first array's 1 element

                }
                k += 2;   //Adding 2 To increase array's location
            }
            for (int i = 0; i < x; i++)
            {
                Console.Write(arr1[i] + " ");//Outputs elements of arr1 + space
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//input size of array
            int[] arr = new int[n]; //one dimensional array with size n
            int x = n * 2;   //second array's size (twice larger than first)
            int k = 0;  //new int 
            int[] arr1 = new int[x]; //one dimensional array with size x
            string s = Console.ReadLine(); //Input string to transfer 
            string[] str = s.Split(); //Every element splitted by space
            Replace(arr, arr1,k,x, n ,str);//Calling function
           

        }
    }
}
