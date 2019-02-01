using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //enter a number and convert it to int
            int[,] arr = new int[n, n];  // Declare a two dimensional array
            for (int i = 0; i < n; i++) //run starts at 0 and ends at n
            {
                for (int j = 0; j < n; j++)  //run starts at 0 and ends at n
                {
                    if (i > j || i == j)  //ifi greater than j or i equal to j
                        Console.Write("[*]");//Outputs [*]
                }
                Console.WriteLine(); //enter
            }
        }
    }
    }
