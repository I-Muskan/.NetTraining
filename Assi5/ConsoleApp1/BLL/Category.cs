using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi5.BLL
{
    class Category
    {

        int _categoryId;
        string _categoryName;



      

        
        /// Constructor
        public Category()
        {

        }
        public Category(int categoryId, string categoryName)
        {
            this._categoryId = categoryId;
            this._categoryName = categoryName;

        }


       

       

        public int GetCategoryId()
        {
            return _categoryId;
        }
        public string GetCategroyName()
        {
            return _categoryName;
        }
        public void SetCategoryId(int categoryId)
        {

            this._categoryId = categoryId;

        }

        public void SetCategorytName(string categoryName)
        {

            this._categoryName = categoryName;

        }
       

    }
  }

