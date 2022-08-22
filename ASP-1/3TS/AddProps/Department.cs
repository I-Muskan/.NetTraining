using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddProps
{
    public class Department
    {
        int _deptId;
        string _deptName;
        string _deptHead;

        public int DeptId { get => _deptId; set => _deptId = value; }
        public string DeptName { get => _deptName; set => _deptName = value; }
        public string DeptHead { get => _deptHead; set => _deptHead = value; }
    }
}
