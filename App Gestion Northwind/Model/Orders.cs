using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Northwind.Model
{
    internal class Orders
    {
        int orderID;
        string customerID;
        DateTime orderDate;
        DateTime requiredDate;
        DateTime shippedDate;
        int shipVia;
        int freight;
        string shipName;
        string shipAddress;
        string shipCity;
        string shipRegion;
        string shipPostalCode;
        string shipCountry;
    }
}
