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
            StreamReader sr = new StreamReader("C: /Users/Чингиз/Desktop/PP2/Week2/Task2/input.txt");
            StreamWriter sw = new StreamWriter("C: /Users/Чингиз/Desktop/PP2/Week2/Task2/output.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            string[] arr = s.Split();
            int[] array1 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                array1[i] = int.Parse(arr[i]);
            
            for (int i = 0; i < array1.Length; i++)
            {
                int Dividers = 0;
                if (array1[i] == 1)
                    Dividers++;

                for (int j = 2; j <= array1[i] / 2; j++)
                    if (array1[i] % j == 0)
                        Dividers++;

                if (Dividers == 0)
                  sw.Write(array1[i] + " ");
            }
               sw.Close();
        }
    }
}