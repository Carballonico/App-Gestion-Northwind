using App_Gestion_Northwind.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Northwind.Controler
{
    internal class ControlerOrdenes
    {
        SqlConnection conexion;
        DataSetResultados dsResultados;
        DataSetNorthWind dsNorthwind;

        public ControlerOrdenes(SqlConnection pconexion, DataSetResultados pdsResultados, DataSetNorthWind pdsNorthwind)
        {
            this.conexion = pconexion;
            this.dsResultados = pdsResultados;
            this.dsNorthwind = pdsNorthwind;
            
        }


        public void menu()
        {
            CrearOrderView orderView = new CrearOrderView(dsNorthwind,dsResultados,this);
            orderView.Show();
        }
    }
}
