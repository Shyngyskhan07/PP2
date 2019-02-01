using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//converting to int size of array
            int[] array1 = new int[n];//new array with size n
            string s = Console.ReadLine();//creating another  array by writing array numbers
            string[] arr = s.Split(); //splitting by space;

            for (int i = 0; i < array1.Length; i++)
            {

                array1[i] = int.Parse(arr[i]); //Transfering to first array


            }
            int NumOfPrime = array1.Length; //Firstly size of array for substract not prime numbers
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 1)//1 is not a prime number 
                    NumOfPrime--;  //We substract 1 because 1 is not a prime

                for (int j = 2; j <= array1[i] / 2; j++)//We start with 2 because any number divides by 1
                {                                         //We run up to half of each number

                    if (array1[i] % j == 0)//If our number divides by number beside 2 and array1[i]
                    {
                        NumOfPrime--;   //We substract 1 because we found a number which is not a prime

                    }
                }
            }
            Console.WriteLine(NumOfPrime);  //Outputs Number of Primes
            for (int i = 0; i < array1.Length; i++) //starts at 0 and ends at length of array
            {
                int Dividers = 0;  //New int value to count dividers
                if (array1[i] == 1) //if number is 1 
                {
                    Dividers++; // add 1
                }
                for (int j = 2; j <= array1[i] / 2; j++)  //we again do the same process starts in 2 and ends in half of each number 
                    if (array1[i] % j == 0)//If our number divides by number beside 2 and array1[i]/2

                        Dividers++; //add 1

                if (Dividers == 0) //if dividers 0
                    Console.Write(array1[i] + " "); //Outputs Number and plus space

            }
        }
    }
}
