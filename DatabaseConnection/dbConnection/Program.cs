using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dbConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source = DEL1-LHP-N82179;Initial Catalog=studentDetails;Integrated Security=SSPI";


            SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                SqlCommand cmd = new SqlCommand("studentAnddepartment",con);
               
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
              
           
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                Console.WriteLine("Student Details");
                Console.WriteLine("--------------------");
                while (dataReader.Read())
                {

                    Console.WriteLine("Student Id: "+dataReader[0].ToString()+" Student Name: "+dataReader[1].ToString()+" Student Age:"+dataReader[2].ToString()+" Student Address: "+dataReader[3].ToString());
                }
            }
            if(dataReader.NextResult())
            {
                Console.WriteLine("Department Details");
                Console.WriteLine("--------------------");
                while (dataReader.Read())
                {


                    Console.WriteLine( "Department Id: "+dataReader[0].ToString()+" Department Name: "+dataReader[1].ToString()+" Department Head: "+dataReader[2].ToString());
                }

            }

            dataReader.Close();
            Console.ReadKey();
        }
    }
}
