using App_Gestion_Northwind.View;
using System;
using System.Collections.Generic;
using System.Data;
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
        AppControler appControler;

        public ControlerOrdenes(SqlConnection pconexion, DataSetResultados pdsResultados, DataSetNorthWind pdsNorthwind, object pAppControler)
        {
            this.conexion = pconexion;
            this.dsResultados = pdsResultados;
            this.dsNorthwind = pdsNorthwind;
            appControler = (AppControler)pAppControler;
        }
        public void mostrarMenuInicio()
        {
            appControler.mostrarMenuInicio();
        }
        public void altaOrden(string pIdCliente , string pOrderDate)
        {
            string query = $"INSERT INTO Orders (CustomerID,OrderDate) VALUES ('{pIdCliente}',{pOrderDate});";
            SqlCommand comando = new SqlCommand(query, conexion);
            int resultado = comando.ExecuteNonQuery();

            if(resultado != -1)
            {
                CustomAlert alertaExito = new CustomAlert("orden creada con exito");
                alertaExito.Show();
            }
            else
            {
                CustomAlert alertaExito = new CustomAlert("Algo salio mal");
                alertaExito.Show();
            }

        }

        public int altaDetallesOrden(List<string> detalleOrden, int pOrderID)
        {
            List<string> datos = new List<string>();
            int cantidadDetalles = 0;
            foreach(string detalle in detalleOrden)
            {
                datos.Clear();
                string idProdu = "";
                string nombreProdu = "";
                string cantidad = "";
                string precio = "";
                string[] arrDetalle = detalle.Split(" ");           
                string[] auxdetalle = arrDetalle.Where(d => !d.Equals("")).ToArray();
                int indice = 0;                
                foreach(string auxdeta in auxdetalle)
                {
                    
                    if (indice > 0 & indice < auxdetalle.Length-2)
                    {
                        nombreProdu += auxdeta +" ";
                    }else
                    {
                        datos.Add(auxdeta);
                    }
                    indice++;
                }
                idProdu = datos[0];
                nombreProdu = nombreProdu.TrimEnd();
                cantidad = datos[1];
                precio = datos[2];
                int intIdProdu = 0;                
                int intCantidad = 0;
                decimal intPrecio = 0m;
                try
                {
                    intIdProdu = int.Parse(idProdu);                  
                    intCantidad = int.Parse(cantidad);
                    intPrecio = decimal.Parse(precio);
                }
                catch
                {

                }
                SqlCommand comando = new SqlCommand(null, conexion);
                comando.CommandText = "INSERT INTO [Order Details] (OrderID,ProductID,UnitPrice,Quantity)values (@OrderID,@ProductID,@UnitPrice,@Quantity);";
                SqlParameter paramOrderID = new SqlParameter("@OrderID",SqlDbType.Int);
                paramOrderID.Value = pOrderID;
                comando.Parameters.Add(paramOrderID);
                SqlParameter paramProductID = new SqlParameter("@ProductID",SqlDbType.Int);
                paramProductID.Value = intIdProdu;
                comando.Parameters.Add(paramProductID);
                SqlParameter paramUnitPrice = new SqlParameter("@UnitPrice", SqlDbType.Money);
                paramUnitPrice.Value = intPrecio;
                comando.Parameters.Add(paramUnitPrice);
                SqlParameter paramQuantity = new SqlParameter("@Quantity",SqlDbType.Int);
                paramQuantity.Value = intCantidad;
                comando.Parameters.Add(paramQuantity);
                if (comando.ExecuteNonQuery() != -1)
                {
                    cantidadDetalles++;
                }
              
            }
            appControler.actualizarDatosNorthwind();
            return cantidadDetalles;
        }
        public int nOrden()
        {
            int nOrden = 0;
            string query = $"SELECT max(OrderID) FROM Orders ";         
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            SqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            nOrden = reader.GetInt32(0);      
            reader.Close();
            return nOrden +1;
        }
        public void menu()
        {
            CrearOrderView orderView = new CrearOrderView(dsNorthwind,dsResultados,this);
            orderView.Show();
        }
    }
}
