using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Gestion_Northwind.View;

namespace App_Gestion_Northwind.Controler
{
    internal class AppControler
    {
        DataSetResultados dsResultados;
        SqlConnection conexion;
        DataSetNorthWind dsNorthwind;
        Inicio menuInicio;
        public AppControler(SqlConnection pconecxion, DataSetResultados pdsResultados, DataSetNorthWind pdsNorthwind)
        {
            ApplicationConfiguration.Initialize();
            dsNorthwind = pdsNorthwind;
            dsResultados = pdsResultados;
            conexion = pconecxion;
            menuInicio = new Inicio(this,dsResultados);
            cargarClientesNorthwind();
            cargarProductosNorthwind();
            Application.Run(menuInicio);      
        }

        public SqlConnection Conexion { get => conexion;}

        public void actualizarDatosNorthwind()
        {
            cargarProductosNorthwind();
            cargarClientesNorthwind();
        }
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
            ControlerClientes controlerClientes = new ControlerClientes(Conexion,dsResultados,dsNorthwind,this);
            controlerClientes.menu();
            menuInicio.Visible = false;
        }
        public void mostrarMenuInicio()
        {
            menuInicio.Visible = true;
            menuInicio.Show();
        }
       

        public void menuProductos()
        {
            ControlerProductos controlProductos = new ControlerProductos(Conexion, dsResultados, dsNorthwind,this);          
            controlProductos.menu();
            menuInicio.Visible = false;

        }
        
        public void menuOrdenes()
        {
            ControlerOrdenes controlOrdenes = new ControlerOrdenes(Conexion, dsResultados, dsNorthwind,this);
            controlOrdenes.menu();
            menuInicio.Visible = false;
        }

        public Image cargarFoto(int id)
        {
            try
            {
                cargarNombeEmpleado(id);
                string query = $"SELECT Photo FROM Employees WHERE EmployeeID = {id}";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                byte[] imageData = (byte[])reader["Photo"];
                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                Image img = (Image)converter.ConvertFrom(imageData);
                reader.Close();
                return img;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public void cargarNombeEmpleado(int id)
        {         
            try
            {
                dsResultados.Employees.Clear();
                string query = $"SELECT FirstName,LastName FROM Employees WHERE EmployeeID = {id}";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dsResultados.Employees);                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
          
        }
    }
}
