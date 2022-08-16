using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assi5.BLL;

namespace Assi5.PAL
{


    class Program
    {
        //public static List<Student> StudentArray = new List<Student>();
        static void Main(string[] args)
        {
            Boolean flag = true;
            do
            {
                Menu();
                Console.WriteLine("please enter your choice");

                int choice = int.Parse(Console.ReadLine());
                Operate(choice);
            } while (flag);

        }
        static void Menu()
        {
            Console.WriteLine("press 1: to Add Category");
            Console.WriteLine("press 2: to Add Product");
            Console.WriteLine("press 3: to get all categories");
            Console.WriteLine("press 4: to get all products");
            Console.WriteLine("press 5: to get specific product");
            Console.WriteLine("press 6: to update product price");
            Console.WriteLine("press 7: to delete a product");
            Console.WriteLine("press 8: EXIT");


        }

        static Boolean Operate(int choice)
        {
          FetchData fd = new FetchData();

            switch (choice)
            {
                
                case 1:

                    
                    Console.WriteLine("Enter Category Id");
                    int cId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Category Name");
                    string cName= Console.ReadLine();
                    Category category = new Category(cId, cName);

                    fd.AddCategory(cId,cName);


                    return true;

                case 2:
                    Console.WriteLine("Enter product Id");
                    int pId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter product Name");
                    string pName = Console.ReadLine();
                    Console.WriteLine("Enter product  Price");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter category id");
                   int CID = int.Parse(Console.ReadLine());
                 

                    fd.AddProduct(pId,pName,price,CID);

                    return true;

                case 3:

                   
                    fd.ShowAllCategories();
                    return true;
                   

                case 4:


                    fd.ShowAllProducts();
                    return true;

                   
                case 5:
                    Console.WriteLine("Enter product Id");
                    int productId = int.Parse(Console.ReadLine());
                    fd.ShowSpecificProduct(productId);
                    return true;
                case 6:
                    Console.WriteLine("Enter product Id");
                    int Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter product new price");
                    double productPrice = double.Parse(Console.ReadLine());
                    fd.UpdateProductPrice(Id,productPrice);
                    return true;

                default:
                    Console.WriteLine("Please Enter Correct Option" + "");
                    return true;
            }

        }
    }
}
