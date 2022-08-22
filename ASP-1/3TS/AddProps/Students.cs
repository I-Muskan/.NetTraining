using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddProps
{
    public class Students
    {
        string _id;
        string _name;
        int _age;
        int _standard;
        string _address;

        public int Standard { get => _standard; set => _standard = value; }
        public string Address { get => _address; set => _address = value; }
        public string Name { get => _name; set => _name = value; }
        public string Id { get => _id; set => _id = value; }
        public int Age { get => _age; set => _age = value; }
    }
}
