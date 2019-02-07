using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C: /Users/Чингиз/Desktop/PP2/Week2/Task1/input.txt");      //way where we read
            string s = sr.ReadToEnd();                                 //copy to string
            sr.Close();                                                //to close
            int cnt = 0;                                               //new cnt
            for(int i = 0; i < s.Length/2; i++)                        //we begin at 0 and end at half of length
            {
                if (s[i] != s[s.Length - i - 1])                       //to check elements for example:1 st and last
                    cnt++;                                             //if we find not same letter counter ++
            }
            if (cnt > 0)
                Console.WriteLine("No");                                //outputs "NO"
            else
            {
                Console.WriteLine("Yes");                                //outputs "YES"
            }

        }
    }
}
