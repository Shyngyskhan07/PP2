using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C: /Users/Чингиз/Desktop/PP2/Week2/Task2/input.txt");             //To read from input
            StreamWriter sw = new StreamWriter("C: /Users/Чингиз/Desktop/PP2/Week2/Task2/output.txt");            //To write to output
            string s = sr.ReadToEnd();                                                                            //Reads sr
            sr.Close();                                                                                             //Close sr
            string[] arr = s.Split();                                                                               //massive saves by splitting
            int[] array1 = new int[arr.Length];                                                                     //new array with length arr

            for (int i = 0; i < arr.Length; i++)            
                array1[i] = int.Parse(arr[i]);                                                                      //converts to int each number
            
            for (int i = 0; i < array1.Length; i++)
            {
                int Dividers = 0;                                                                                   //To count dividers each number
                if (array1[i] == 1)                                                                                 //1 is not prime
                    Dividers++;                                                                                     //add +1 to dividers

                for (int j = 2; j <= array1[i] / 2; j++)                                                            //runs from 2 to half of number
                    if (array1[i] % j == 0)                                                     
                        Dividers++;                                                                                 //add +1 to dividers

                if (Dividers == 0)
                  sw.Write(array1[i] + " ");                                                                        //if Dividers 0 writes in output.txt
            }
               sw.Close();                                                                                          //close sw
        }
    }
}