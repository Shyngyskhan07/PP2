using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student                                                         //new class with 3 types;
    {
        public string name;                                              //name
        public string ID;                                                //id
        public int year_Of_Study;                                       //year of study
       public Student(){}                                              //defoult constructor with 0 parameters and wtihout body
     public Student(string name, string ID)                           //constructor with 2 parameters
        {
            this.name = name;                              
            this.ID = ID;
        }
          public string write_name(string name)                      //method to change name
            {
            this.name = name; 
            return name;                                            //returns name
             } 
         public string write_ID(string ID)                         //method to change ID
        {
            this.ID = ID;
            return ID;                                            //returns ID
        }
         public int increment_year(int year_Of_Study)            //method which add +1 to year_Of_study and we get new year
        {
            this.year_Of_Study = year_Of_Study+1;
            return year_Of_Study;                               //returns year_of_study
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
         //We work with class Student
        }
    }
}
