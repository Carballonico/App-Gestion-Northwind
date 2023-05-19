using App_Gestion_Northwind.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gestion_Northwind.Controler
{
    internal class ControlerClientes
    {
        SqlConnection conexion;
        DataSetResultados dsResultados;
        DataSetNorthWind dsNorthwind;
        AltaCustomer menuCustomersView;
        public ControlerClientes(SqlConnection pconexion, DataSetResultados pdsResultados, DataSetNorthWind pdsNorthwind)
        {
            this.conexion = pconexion;
            this.dsResultados = pdsResultados;
            this.dsNorthwind = pdsNorthwind;
            menuCustomersView = new AltaCustomer(this, dsResultados, dsNorthwind);
        }
        public void menu()
        {
            MostrarCustomers mostrarCustomers = new MostrarCustomers(this, dsNorthwind);
            mostrarCustomers.Show();
           
        }        
        public void menuEditarCustomer(string id)
        {            
            menuCustomersView.Visible = true;
            menuCustomersView.Show();              
            menuCustomersView.btnBuscarAux(id);                       
        }
        public void buscarCliente(string ID)
        {         
            string query = $"SELECT * FROM Customers Where CustomerID = '{ID}'";
            dsResultados.Customers.Clear();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dsResultados.Customers);                    
        }

        public bool comprobarIDExiste(string ID)
        {
            bool IDExiste = false;
            string query = $"SELECT * FROM Customers Where CustomerID = '{ID}'";
            dsResultados.Customers.Clear();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dsResultados.Customers);
            if(dsResultados.Customers.Count > 0)
            {
                IDExiste = true;
            }

            return IDExiste;
        }

        public int altaCustomer(string values)
        {
            string query = $"insert into Customers values ({values})";           
            SqlCommand comando = new SqlCommand(query, conexion);
            int rows = comando.ExecuteNonQuery();
            return rows;
        }

        public int modificarCustomer(string values,string id)
        {
            string query = $"update Customers set {values} where CustomerID = '{id}'";
            SqlCommand comando = new SqlCommand(query, conexion);
            int rows = comando.ExecuteNonQuery();
            return rows;
        }

        public int eliminarCustomer(string id)
        {
            string query = $"Delete from Customers where CustomerID = '{id}'";
            SqlCommand comando = new SqlCommand(query, conexion);
            int rows = comando.ExecuteNonQuery();
            return rows;
        }
    }
}
