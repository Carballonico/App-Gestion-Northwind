using App_Gestion_Northwind.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Northwind.Controler
{
    internal class ControlerProductos
    {
        SqlConnection conexion;
        DataSetResultados dsResultados;
        DataSetNorthWind dsNorthwind;    
        AltaProducto menuProductosView;
        AppControler appControler;
        public ControlerProductos(SqlConnection pconexion, DataSetResultados pdsResultados, DataSetNorthWind pdsNorthwind, object pAppControler)
        {
            this.conexion = pconexion;
            this.dsResultados = pdsResultados;
            this.dsNorthwind = pdsNorthwind;
            menuProductosView = new AltaProducto(this,dsResultados, dsNorthwind);
            appControler = (AppControler)pAppControler;
        }

        public void mostrarMenuInicio()
        {
            appControler.mostrarMenuInicio();
        }


        public void menu()
        {
            MostrarProductos mostrarProductos = new MostrarProductos(this, dsNorthwind);
            mostrarProductos.Show();

        }

        public void buscarProducto(string ID)
        {
            string query = $"SELECT * FROM Products Where ProductID = '{ID}'";
            dsResultados.Products.Clear();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dsResultados.Products);
        }
        public void menuEditarProducto(string id)
        {
            menuProductosView.Visible = true;
            menuProductosView.Show();
            menuProductosView.btnBuscarAux(id);
        }

        public bool comprobarIDExiste(int ID)
        {
            bool IDExiste = false;
            string query = $"SELECT * FROM Products Where ProductID = '{ID}'";
            dsResultados.Products.Clear();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dsResultados.Products);
            if (dsResultados.Products.Count > 0)
            {
                IDExiste = true;
            }

            return IDExiste;
        }

        public bool comprobarSupplierID(int ID)
        {
            bool IDExiste = false;
            string query = $"SELECT * FROM Suppliers Where SupplierID = '{ID}'";
            dsResultados.Suppliers.Clear();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dsResultados.Suppliers);
            if (dsResultados.Suppliers.Count > 0)
            {
                IDExiste = true;
            }

            return IDExiste;
        }

        public bool comprobarCategoryID(int ID)
        {
            bool IDExiste = false;
            string query = $"SELECT * FROM Categories Where CategoryID = '{ID}'";
            dsResultados.Categories.Clear();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dsResultados.Categories);
            if (dsResultados.Categories.Count > 0)
            {
                IDExiste = true;
            }

            return IDExiste;
        }


        public int altaProducto(string values)
        {
            string query = $"insert into Products values ({values})";
            SqlCommand comando = new SqlCommand(query, conexion);
            int rows = comando.ExecuteNonQuery();
            return rows;
        }
    }
}
