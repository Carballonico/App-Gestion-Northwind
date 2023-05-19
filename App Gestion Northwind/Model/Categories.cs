using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Northwind.Model
{
    internal class Categories
    {        
        int categoryID;
        string categoryName;
        string description;
        byte[] picture;

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Description { get => description; set => description = value; }
        public byte[] Picture { get => picture; set => picture = value; }


    }
}
