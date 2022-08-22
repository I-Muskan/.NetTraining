using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddProps;
using DAL;

namespace BLL
{
    class DepartmentBLL
    {
        DepartmentDAL dpmtDAL = new DepartmentDAL();
        public bool DepartmentInsertBLL(Department dpmt)
        {
            return dpmtDAL.DepartmentInsertDAL(dpmt);
        }
        public bool DepartmentUpdateBLL(Department dpmt)
        {
            return dpmtDAL.DepartmentUpdateDAL(dpmt);
        }
        public bool DepartmentDeleteBLL(Department dpmt)
        {
            return dpmtDAL.DepartmentDeleteDAL(dpmt);
        }
        public bool DepartmentSpecificBLL(Department dpmt)
        {
            return dpmtDAL.DepartmentSpecificDAL(dpmt);
        }
        public bool DepartmentAllBLL(Department dpmt)
        {
            return dpmtDAL.DepartmentAllDAL(dpmt);
        }
    }
}
