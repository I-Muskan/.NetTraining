using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        string name;
         int id;
        char gender;
          int Id{ get; set; }
        String Name { get; set; }
        Char Gender { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
                
                new Student(){Id=1,Name="Aditya","Kinjal","Samiksha","Supriya" };
            var QuerySyntax = from obj in studentList
                              where obj > 2
                              select obj;
            foreach(var item in QuerySyntax)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
    }
}
