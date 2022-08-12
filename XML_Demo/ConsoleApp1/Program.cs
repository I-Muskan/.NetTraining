using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_XML_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xelement = XElement.Load(@"C:\Users\anmol.soni\source\repos\LINQ_XML\LINQ_XML_Sort\Employees.xml");

            var dict = (from element in xelement.Descendants("employee")
                        let name = (string)element.Attribute("Name")
                        orderby name
                        select new
                        {
                            Id = element.Attribute("ID").Value,
                            empname = name
                        })
                        .ToDictionary(c => c.Id, c => c.empname);

            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();
        }
    }
}
