using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Demo
{


    class Program
    {
        public static List<Student> StudentArray = new List<Student>();
        static void Main(string[] args)
        {
            Boolean flag = true;
            do
            {
                Menu();
                Console.WriteLine("please enter your choice");

                int choice = int.Parse(Console.ReadLine());
                Operate(choice);
            } while (flag);

        }
        static void Menu()
        {
            Console.WriteLine("press 1: to enter student details");
            Console.WriteLine("press 2: to update student details");
            Console.WriteLine("press 3: to delete student details");
            Console.WriteLine("press 4: to display all student");
            Console.WriteLine("press 5: EXIT");


        }

        static Boolean Operate(int choice)
        {

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter student Id");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter student Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter student Marks");
                    int marks = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter student Address");
                    string address = Console.ReadLine();
                    Student student1 = new Student(id, name, marks, address);
                    StudentArray.Add(student1);


                    return true;

                case 2:
                    Console.WriteLine("Enter Student Id for which you want to update details");
                    int updateId = int.Parse(Console.ReadLine());
                    bool flagSt = false;
                    foreach (var student in StudentArray)
                    {
                        if (student.Id == updateId)
                        {
                            flagSt = true;

                            Console.WriteLine("Enter student updated Name");
                            string updatedName = Console.ReadLine();
                            student.SetStudentName(updatedName);
                            Console.WriteLine("Enter student updated marks");
                            int updatedMarks = int.Parse(Console.ReadLine());
                            student.SetStudentMarks(updatedMarks);
                            Console.WriteLine("Enter student updated address");
                            string updatedAddress = Console.ReadLine();
                            student.SetStudentAddress(updatedAddress);
                            Console.WriteLine("Updated details are: ");
                            student.DisplayStudentDetails();


                        }

                    }
                    if(flagSt==false)
                    {
                        Console.WriteLine("This Student Does not exist");
                    }
                    return true;

                case 3:
                    Console.WriteLine("Enter Student Id you want to delete");
                    int deleteId = int.Parse(Console.ReadLine());
                    bool flagDel = false;
                    for (var i=0;i<StudentArray.Count();i++)
                    {
                        if (StudentArray[i].Id == deleteId)

                        {
                            flagDel = true;
                            StudentArray.Remove(StudentArray[i]);
                            Console.WriteLine("Student with id {0}", deleteId + "has been deleted");
                        }

                    }
                   
                    if(flagDel==false)
                    {
                        Console.WriteLine("This Student Does not exist");
                    }
                    return true;

                case 4:
                  
                        foreach (var item in StudentArray)
                        {
                        Console.WriteLine(" Id: {0} ", item.Id);
                        Console.WriteLine(" Name: {0} ", item.Name );
                        Console.WriteLine(" Marks: {0} " , item.Marks);
                        Console.WriteLine(" Address:{0} " , item.Address);
                        }
                   

                    
                    return true;
                case 5:
                    return false;

                default:
                    Console.WriteLine("Please Enter Correct Option" + "");
                    return true;
            }

        }
    }
}

