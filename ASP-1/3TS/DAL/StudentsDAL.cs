using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddProps;
namespace DAL
{
    public class StudentsDAL
    {
        DBcon con;
        string cs = "Data Source=DEL1-LHP-N82179;Initial Catalog = studentsDetails; Integrated Security = True";
        public StudentsDAL()
        {
            con = new DBcon(cs);
        }
        public bool StudentInsertDAL(Students st)
        {
            string query = "INSERT INTO Students values('" + st.Id + "','" + st.Name+ "'," + st.Age + "," + st.Standard + ",'" + st.Age + "')";
            return con.checkCon(query);
        }
        public bool StudentUpdateDAL(Students st)
        {
            string query = "UPDATE Students SET name='"+st.Name+"',age="+st.Age+",standard="+st.Standard+",address='"+st.Address+"'";
            return con.checkCon(query);
        }
        public bool StudentDeleteDAL(Students st)
        {
            string query = "DELETE FROM Students WHERE Id='"+st.Id+"'";
            return con.checkCon(query);
        }
        public bool StudentSpecificDAL(Students st)
        {
            string query = "SELECT * FROM Students WHERE Id='" + st.Id + "'";
            return con.checkCon(query);
        }
        public bool StudentAllDAL(Students st)
        {
            string query = "SELECT * FROM Students ";
            return con.checkCon(query);
        }

    }
}
