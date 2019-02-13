using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task4
{
    class Program
    {
       public static void Main()
        {
            string Folder = "C:/Users/Чингиз/Desktop/PP2/Week2/Task4/path/b.txt";            //new way to string Folder
            string Folder1 = "C:/Users/Чингиз/Desktop/PP2/Week2/Task4/path1/b1.txt";         //new way to string Folder1
            FileInfo f = new FileInfo(Folder);                               //Get info from Folder
            StreamWriter sw = new StreamWriter(Folder);                      //To write in Folder
            sw.Write("Exists");                                           //Writes in path "Exists"
            sw.Close();                                                   //Close streamWriter
            if (f.Exists)                                                  //Check files to exist
            {
                Console.WriteLine("Moved from path to path1");             //Outputs "Moved from Folder to Folder1"
                f.CopyTo(Folder1,true);                                      //Copy from path to Folder1
                f.Delete();                                                //Delete b.txt
               
            }

       }
    }
}
