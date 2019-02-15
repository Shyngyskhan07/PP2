using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task2
{   class farm
    {   
        public int cursor = 0;
        public int sz = 0;
        
        public farm()
        {
            cursor = 0;
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }
        public void Color(FileSystemInfo file,int index)
        {
            if (index == cursor)
                Console.BackgroundColor = ConsoleColor.Red;
            else if (file.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void Start(string path)
        {
           
            ConsoleKeyInfo key = Console.ReadKey();
            FileSystemInfo fi = null;
            while (key.Key != ConsoleKey.Escape)
            {   
                DirectoryInfo d = new DirectoryInfo(path);
               
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                key = Console.ReadKey();
                fi = d.GetFileSystemInfos()[cursor];                  //consider file where my cursor
                if (key.Key == ConsoleKey.UpArrow)
                    Up();
                else if (key.Key == ConsoleKey.DownArrow)
                    Down();
               
               else if (key.Key == ConsoleKey.Backspace)
                {
                    d = d.Parent;                           //Get inform dir before
                    path = d.FullName;                      //new path
                    cursor = 0;

                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (fi.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = fi.FullName;                          //new path
                    }

                }

            }
        }
        public void Show(string path)
        {   
            DirectoryInfo d = new DirectoryInfo(path);
            FileSystemInfo[] f = d.GetFileSystemInfos();
            sz = f.Length;
            int index = 0;
            foreach(FileSystemInfo file in f)
            {
                Color(file, index);
                Console.WriteLine(file.Name);
                index++;

            }
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            farm far = new farm();
            far.Start(@"C: \Users\Чингиз\Desktop\gg\Test1");

        }
    }
}
