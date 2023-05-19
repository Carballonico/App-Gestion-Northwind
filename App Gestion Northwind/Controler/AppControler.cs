using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Gestion_Northwind.View;

namespace App_Gestion_Northwind.Controler
{
    internal class AppControler
    {
        DataSetResultados dsResultados;
        SqlConnection conexion;
        DataSetNorthWind dsNorthwind;
        public AppControler(SqlConnection pconecxion, DataSetResultados pdsResultados, DataSetNorthWind pdsNorthwind)
        {
            dsNorthwind = pdsNorthwind;
            dsResultados = pdsResultados;
            conexion = pconecxion;
            cargarClientesNorthwind();
            cargarProductosNorthwind();
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio(this));
      

        }

        public SqlConnection Conexion { get => conexion;}

        public void cargarProductosNorthwind()
        {
            string query = $"SELECT * FROM Products";
            dsNorthwind.Products.Clear();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dsNorthwind.Products);
        }
            public void cargarClientesNorthwind()
        {
            string query = $"SELECT * FROM Customers";
            dsNorthwind.Customers.Clear();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dsNorthwind.Customers);


            string queryRegion = $"SELECT * FROM Region";
            dsNorthwind.Region.Clear();
            SqlCommand comand = new SqlCommand(queryRegion, conexion);
            SqlDataAdapter adapter1 = new SqlDataAdapter(comand);
            adapter1.Fill(dsNorthwind.Region);
        }
        public void menuClientes()
        {
            
            ControlerClientes controlerClientes = new ControlerClientes(Conexion,dsResultados,dsNorthwind);
            controlerClientes.menu();
        }

        public void mostrarClientes()
        {
            ControlerClientes controlerClientes = new ControlerClientes(Conexion, dsResultados, dsNorthwind);
           
          
        }

        public void menuProductos()
        {
            ControlerProductos controlProductos = new ControlerProductos(Conexion, dsResultados, dsNorthwind);          
            controlProductos.menu();

        }
        
        public void menuOrdenes()
        {
            ControlerOrdenes controlOrdenes = new ControlerOrdenes(Conexion, dsResultados, dsNorthwind);
            controlOrdenes.menu();
        }
    }
}
