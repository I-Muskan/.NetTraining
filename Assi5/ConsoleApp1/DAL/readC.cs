using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Assi5.DAL
{
    class readC
    {
        DataTable dt = new DataTable();
        public void readCategory()
        {
            GetData getCategoryData = new GetData();
            if (ConnectionState.Closed == getCategoryData.con.State)
            {
                getCategoryData.con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from category", getCategoryData.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                foreach(var P in rd )
                {
                    Console.WriteLine(rd[0] + " " + rd[1]);
                }
                dt.Load(rd);
               

            }
            catch
            {
                throw;
            }
            finally
            {
                getCategoryData.con.Close();
            }

        }
        public void readProduct()
        {
            GetData getCategoryData = new GetData();
            if (ConnectionState.Closed == getCategoryData.con.State)
            {
                getCategoryData.con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from Product", getCategoryData.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                foreach (var P in rd)
                {
                    Console.WriteLine(rd[0] + " " + rd[1]+" "+rd[2]+" "+rd[3]);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                getCategoryData.con.Close();

            }
        }
        public void UpdatePrice(int productId, double updatedPrice)
        {
            GetData getCategoryData = new GetData();
            if (ConnectionState.Closed == getCategoryData.con.State)
            {
                getCategoryData.con.Open();
            }


            try
            {
                string query = "Update Product SET Price=" + "" + updatedPrice + "" + "where ProductID=" + productId + ";";
                SqlCommand cmd = new SqlCommand(query, getCategoryData.con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                getCategoryData.con.Close();

            }
        }
        public void specificProduct(int productId)
        {
            GetData getCategoryData = new GetData();
            if (ConnectionState.Closed == getCategoryData.con.State)
            {
                getCategoryData.con.Open();
            }


            try
            {
                string query = "Select * from  Product where ProductID =" + productId + ";";
                SqlCommand cmd = new SqlCommand(query, getCategoryData.con);
             
                var rd = cmd.ExecuteReader();

                foreach (var v in rd)
                {
                    Console.WriteLine(rd[0] + " " + rd[1] + " " + rd[2] + " " + rd[3]);
                    Console.WriteLine("-----------------------------------------");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                getCategoryData.con.Close();

            }
        }
        public void AddProduct(int productId, string productName, double price,int cid)
        {
            GetData getCategoryData = new GetData();
            if (ConnectionState.Closed == getCategoryData.con.State)
            {
                getCategoryData.con.Open();
            }


            try
            {
                string query = "insert into Product values( " + productId + "," +"'" +productName+"'" + "," + price +","+cid +")";
                SqlCommand cmd = new SqlCommand(query, getCategoryData.con);
                cmd.ExecuteNonQuery();


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                getCategoryData.con.Close();

            }
        }
            public void AddCategory(int categoryId, string categoryName)
            {
                GetData getCategoryData = new GetData();
                if (ConnectionState.Closed == getCategoryData.con.State)
                {
                    getCategoryData.con.Open();
                }


                try
                {
                    string query = "insert into Category values( " + categoryId + "," +"'" +categoryName +  "')";
                    SqlCommand cmd = new SqlCommand(query, getCategoryData.con);
                    cmd.ExecuteNonQuery();


                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
                
                finally
                {
                    getCategoryData.con.Close();

                }

            }
        }
}
