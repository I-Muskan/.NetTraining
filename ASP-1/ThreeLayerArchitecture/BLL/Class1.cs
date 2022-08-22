using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
namespace BLL
{
    public class Class1
    {
        public ClsDal objDal = new ClsDal();

        public void InsertNewUser(string _name, string _add, string _city, string _email)
        {
            objDal.InsertData(_name, _add, _city, _email);
        }

        public object SelectUser()
        {
            return objDal.selectData();
        }

    }
}
