using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void PrintSpaces(int level)                                  //method to print spaces
        {
            for (int i = 0; i < level; i++)                                 //rung from 0 to level
                Console.Write("  ");                                        //Outputs spaces
        }

        static void GetInfo(DirectoryInfo directory, int level)            //Method with 2 parametres
        {
            FileInfo[] files = directory.GetFiles();                       //Massive files
            DirectoryInfo[] directories = directory.GetDirectories();     //Massive directories

            foreach (FileInfo file in files)                              //Check massive files
            {
                PrintSpaces(level);                                       //calls method PritSpaces
                Console.WriteLine(file.Name);                             //Outputs Name of File
            }

            foreach (DirectoryInfo d in directories)                      //Check massive directories
            {
                PrintSpaces(level);             //calls method PrintSpaces
                Console.WriteLine(d.Name);        //Outputs Name of directory
                GetInfo(d, level + 1);            //calls method GetInfo with level++
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("C: /Users/Чингиз/Desktop/PP2/Week2"); //Gets directory info
            GetInfo(d,0);                          //calls method GetInfo with level 0
            
        }
    }
}
