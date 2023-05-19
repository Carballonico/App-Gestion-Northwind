using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Northwind.Model
{
    internal class Products
    {
        int productID;
        string productName;
        int categoryID;
        string quantityPerUnit;
        int unitPrice;
        int unitsInStock;
        int unitsOnOrder;
        int reorderLevel;
        byte discontinued;
    }
}
