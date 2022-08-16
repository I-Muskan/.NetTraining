using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Assi5.DAL;

namespace Assi5.BLL
{
    class FetchData
    {
        public static List<Category> categoryList = new List<Category>();
        public static List<Product> ProductList = new List<Product>();
        public void AddCategory(int categoryId,string categoryName)
        {

            readC categoryData = new readC();
            categoryData.AddCategory(categoryId,categoryName);


        }
        public void AddProduct(int productId,string productName,double price,int cid)
        {
            readC categoryData = new readC();
            categoryData.AddProduct(productId, productName,price,cid);
        }
        public void ShowAllCategories()
        {
            readC categoryData = new readC();
            categoryData.readCategory();


        }
        public void ShowAllProducts()
        {
            readC categoryData = new readC();
            categoryData.readProduct();
        }
        public void ShowSpecificProduct(int productId)
        {
            readC categoryData = new readC();
           categoryData.specificProduct(productId);
        }
        public void UpdateProductPrice(int productId,double price)
        {
            readC categoryData = new readC();
            categoryData.UpdatePrice(productId,price);
        }
        public void DeleteProduct()
        {

        }
    }
}
