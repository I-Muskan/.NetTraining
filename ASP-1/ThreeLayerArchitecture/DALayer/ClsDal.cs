using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALayer
{
    public class ClsDal
    {
        DataSet1.SelectDetailsDataTable userDT = new DataSet1.SelectDetailsDataTable();
        DataSet1TableAdapters.SelectDetailsTableAdapter userDA = new DataSet1TableAdapters.SelectDetailsTableAdapter();
        
        public void InsertData(string _name, string _address, string _city, string _email)
        {
            int i = userDA.Insert(_name, _address, _city, _email);
                
        }

        public object selectData()
        {
            return userDT = userDA.GetData();
        }
    }
}
