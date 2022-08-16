using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assi5.DAL
{
    public class GetData
    {
        public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Goodsdb;Integrated Security=True");

    }
}
