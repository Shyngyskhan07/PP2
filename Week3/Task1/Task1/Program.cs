using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part2
{   class farm
    {
        public farm()                           //Defoult cunstructor
        {
            cursor = 0;
        }
        public int cursor;                                                   
        public int sz;
      
        public void Up()                                                  //method Up
        
        {
            cursor--;                                                       //substract 1
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()                                             //method Down
        {
            cursor++;                                                    //add 1
            if (cursor == sz)
                cursor = 0;
        }
        public void Color(FileSystemInfo file,int index)            //method with 2 parametres
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
        public void Show(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);                                  //Gets infomation in d
            FileSystemInfo[] f = d.GetFileSystemInfos();                                //Gets information to massive
            sz = f.Length;
            int index = 0;
            foreach(FileSystemInfo file in f)                            
            {
                Color(file, index);                                      //calls method Color
                Console.WriteLine(file.Name);                            //Output name of file
                index++;                                                  //add 1

            }
        }
        public void Start(string path)
        {   
            ConsoleKeyInfo key = Console.ReadKey();           //reads from keyboard
            while (key.Key != ConsoleKey.Escape) 
            {
                Console.BackgroundColor = ConsoleColor.Black;                 
                Console.Clear();                                              //Clear
                Show(path);                                                  //calls Show
                key = Console.ReadKey();                                    //Reads from 
                if (key.Key == ConsoleKey.UpArrow) 
                    Up();                                                   //calls method Up
                if (key.Key == ConsoleKey.DownArrow) 
                    Down();                                                 //calls method Down
            }
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            farm far = new farm();                                               //calls constructor without paratmetres
            far.Start(@"C: \Users\Чингиз\Desktop\gg\Task1");                     // calls Start method using link
        }
    }
 }
