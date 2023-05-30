using App_Gestion_Northwind.Controler;
using App_Gestion_Northwind.View;
using System.Data.SqlClient;

namespace App_Gestion_Northwind
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string stringConection = "Data Source=DESKTOP-1S14JTQ\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(stringConection);
            conexion.Open();
            DataSetNorthWind dsNorthwind = new DataSetNorthWind();
            DataSetResultados dsResultados = new DataSetResultados();
            AppControler controler = new AppControler(conexion, dsResultados, dsNorthwind);
           
        }
    }
}