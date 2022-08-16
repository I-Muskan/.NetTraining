using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi5.BLL
{
    class Product
    {

        int _productId;
        string _productName;
        double _price;






        /// Constructor
        public Product()
        {

        }
        public Product(int productId, string productName, double price)
        {
            this._productId = productId;
            this._productName = productName;
            this._price = price;

        }






        public int GetProductId()
        {
            return _productId;
        }
        public string GetProductName()
        {
            return _productName;
        }
        public double GetProductPrice()
        {
            return _price;
        }

        public void SetProductId(int productId)
        {

            this._productId = productId;

        }

        public void SetProductName(string productName)
        {

            this._productName = productName;

        }
        public void SetPrice(double price)
        {
            this._price = price;

        }

    }
}
