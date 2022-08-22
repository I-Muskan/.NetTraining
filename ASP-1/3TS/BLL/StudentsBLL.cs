using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddProps;
using DAL;

namespace BLL
{
    public class StudentsBLL
    {
        StudentsDAL stDAL = new StudentsDAL();
        public bool StudentInsertBLL(Students st)
        {
            return stDAL.StudentInsertDAL(st);
        }
        public bool StudentUpdateBLL(Students st)
        {
            return stDAL.StudentUpdateDAL(st);
        }
        public bool StudentDeleteBLL(Students st)
        {
            return stDAL.StudentDeleteDAL(st);
        }
        public bool StudentSpecificBLL(Students st)
        {
            return stDAL.StudentSpecificDAL(st);
        }
        public bool StudentAllBLL(Students st)
        {
            return stDAL.StudentAllDAL(st);
        }
    }
}
