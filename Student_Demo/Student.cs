using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Demo
{
    

    
         class Student : IStudent
        {
            #region Data Fields
            
          public int Id;
          public string Name;
          public int Marks;

          public string Address;
            #endregion

            #region constructors
            /// Constructor
            public Student()
            {

            }
          public Student(int id,string name,int marks,string address)
          {
            this.Id = id;
            this.Name = name;
            this.Marks= marks;
            this.Address = address;
          }

        
            #endregion

            #region Properties

            public int GetStudentId()
            {
                return Id;
            }
            public string GetStudentName()
            {
                return Name;
            }

            public int GetStudentMarks()
            {
                return Marks;
            }
            public string GetStudentAddress()
            {
                return Address;
            }

            public void SetStudentId(int id)
            {
               
                    this.Id = id;
                
            }

            public void SetStudentName(string name)
            {
               
                    this.Name = name;
               
            }
            public void SetStudentMarks(int marks)
            {
                   this.Marks = marks;
                
            }

            public void SetStudentAddress(String address)
            {
                
                    this.Address = address;
                
            }
        public void DisplayStudentDetails()
        {

            Console.WriteLine("Student Id {0} : ",Id);
            Console.WriteLine("Student Name {0} : ", Name);

            Console.WriteLine("Student Marks {0} : ", Marks);
            Console.WriteLine("Student Address{0} : ", Address);

        }
       
    }
        #endregion
    }

