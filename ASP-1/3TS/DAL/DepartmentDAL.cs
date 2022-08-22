using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddProps;

namespace DAL
{
    public class DepartmentDAL
    {
        DBcon con;
        string cs = "Data Source=DEL1-LHP-N82179;Initial Catalog = studentsDetails; Integrated Security = True";
        public DepartmentDAL()
        {
            con = new DBcon(cs);
        }
        public bool DepartmentInsertDAL(Department dpmt)
        {
            string query = "INSERT INTO department values('" + dpmt.DeptId + "','" + dpmt.DeptName + "','" + dpmt.DeptHead + "')";
            return con.checkCon(query);
        }
        public bool DepartmentUpdateDAL(Department dpmt)
        {
            string query = "UPDATE department SET DeptName='" + dpmt.DeptName + "',DeptHead='" + dpmt.DeptHead + "'";
            return con.checkCon(query);
        }
        public bool DepartmentDeleteDAL(Department dpmt)
        {
            string query = "DELETE FROM department WHERE DeptId='" + dpmt.DeptId + "'";
            return con.checkCon(query);
        }
        public bool DepartmentSpecificDAL(Department dpmt)
        {
            string query = "SELECT * FROM departments WHERE DeptId='" + dpmt.DeptId + "'";
            return con.checkCon(query);
        }
        public bool DepartmentAllDAL(Department dpmt)
        {
            string query = "SELECT * FROM department";
            return con.checkCon(query);
        }

    }
}

    

