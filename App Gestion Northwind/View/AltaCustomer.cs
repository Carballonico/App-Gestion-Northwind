using App_Gestion_Northwind.Controler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App_Gestion_Northwind.View
{
    public partial class AltaCustomer : Form
    {
        ControlerClientes controlerClientes;
        DataSetResultados dsResultados;
        DataSetNorthWind dsNorthwind;
        public AltaCustomer(object pcontrolClientes, DataSetResultados pdsResultados, DataSetNorthWind pdsNorthwind)
        {
            InitializeComponent();
            controlerClientes = (ControlerClientes)pcontrolClientes;
            dsResultados = pdsResultados;
            dsNorthwind = pdsNorthwind;
        }

        private void AltaCustomer_Load(object sender, EventArgs e)
        {
         
            activarInputs(false);
            Eliminar.Enabled = false;
            lblTitulo.Text = "Menu clientes";
            btnModificar.Enabled = false;
            Eliminar.BackColor = Color.DarkGray;
            btnModificar.BackColor = Color.DarkGray;           
        }

        private void AltaCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }           

        bool moverPanel = false;
        int mX, mY;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            moverPanel = true;
            mX = e.X;
            mY = e.Y;
        }
        private void activarInputs(bool activar)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Controls.Count > 0)
                {
                    foreach (Control c in control.Controls)
                    {
                        if (c.Controls.Count > 0)
                        {
                            foreach (Control c1 in c.Controls)
                            {
                                if (c1 is TextBox | c1 is ComboBox)
                                {
                                    if (activar)
                                    {
                                        c1.Enabled = true;
                                        c1.BackColor = Color.White;
                                    }
                                    else
                                    {
                                        c1.Enabled = false;
                                        c1.BackColor = Color.DarkGray;
                                    }
                                   
                                }
                            }
                        }
                        if (c is TextBox | c is ComboBox)
                        {
                            if (activar)
                            {
                                c.Enabled = true;
                                c.BackColor = Color.White;
                            }
                            else
                            {
                                c.Enabled = false;
                                c.BackColor = Color.DarkGray;
                            }
                                
                        }
                    }
                }
                if (control is TextBox | control is ComboBox)
                {
                    if (activar)
                    {
                        control.Enabled = true;
                        control.BackColor = Color.White;
                    }
                    else
                    {
                        control.Enabled = false;
                        control.BackColor = Color.DarkGray;
                    }                        
                }
            }
        }
        private void limpiarInputs()
        {            
            foreach(Control control in this.Controls)
            {
                if(control.Controls.Count > 0)
                {
                    foreach(Control c in control.Controls)
                    {
                        if(c.Controls.Count > 0)
                        {
                            foreach (Control c1 in c.Controls)
                            {
                                if(c1 is TextBox)
                                {
                                    c1.Text = "";
                                }
                            }
                        }
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }                    
                }
                if(control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (moverPanel)
            {
                this.SetDesktopLocation(MousePosition.X - mX,MousePosition.Y - mY);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
          
        }
  

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarInputs();
        }

        int clicks = 0;
        const string FNBUSCAR = "Buscar";
        const string FNALTA = "Alta";
        const string FNELIMINIAR = "Eliminar";
        const string FNMODIFICAR = "Modificar";
        string fn = "ninguna";
        private void reiniciarClicks(string ultimaFn)
        {
            if (fn.Equals(ultimaFn))
            {
                clicks++;
            }
            else if(inputID.Enabled == false)
            {
                clicks=0;
            }else 
            {
                clicks = 1;
                fn = ultimaFn;
            }
        }
        const string VACIO = "";
        public void btnBuscarAux(string id)
        {
            if (!id.Equals(VACIO))
            {
                inputID.Text = id;
            }
            this.Focus();
            reiniciarClicks(FNBUSCAR);
            activarInputs(true);
            if (inputID.Text != null & inputID.Text != "")
            {
                controlerClientes.buscarCliente(inputID.Text);
                if (dsResultados.Customers.Count > 0)
                {
                    if (!dsResultados.Customers[0].IsAddressNull())
                    {
                        inputAddress.Text = dsResultados.Customers[0].Address;
                    }
                    else
                    {
                        inputAddress.Text = "";
                    }
                    if (!dsResultados.Customers[0].IsCityNull())
                    {
                        inputCity.Text = dsResultados.Customers[0].City;
                    }
                    else
                    {
                        inputCity.Text = "";
                    }
                    if (!dsResultados.Customers[0].IsNull("CompanyName"))
                    {
                        inputCompanyName.Text = dsResultados.Customers[0].CompanyName;
                    }
                    else
                    {
                        inputCompanyName.Text = "";
                    }
                    if (!dsResultados.Customers[0].IsContactNameNull())
                    {
                        inputContactName.Text = dsResultados.Customers[0].ContactName;
                    }
                    else
                    {
                        inputContactName.Text = "";
                    }
                    if (!dsResultados.Customers[0].IsCountryNull())
                    {
                        inputCountry.Text = dsResultados.Customers[0].Country;
                    }
                    else
                    {
                        inputCountry.Text = "";
                    }
                    if (!dsResultados.Customers[0].IsFaxNull())
                    {
                        inputFax.Text = dsResultados.Customers[0].Fax;
                    }
                    else
                    {
                        inputFax.Text = "";
                    }
                    if (!dsResultados.Customers[0].IsPhoneNull())
                    {
                        inputPhone.Text = dsResultados.Customers[0].Phone;
                    }
                    else
                    {
                        inputPhone.Text = "";
                    }
                    if (!dsResultados.Customers[0].IsPostalCodeNull())
                    {
                        inputPostalCode.Text = dsResultados.Customers[0].PostalCode;
                    }
                    else
                    {
                        inputPostalCode.Text = "";
                    }
                    if (!dsResultados.Customers[0].IsContactTitleNull())
                    {
                        inputContactTitle.Text = dsResultados.Customers[0].ContactTitle;
                    }
                    else
                    {
                        inputContactTitle.Text = "";
                    }
                    if (!dsResultados.Customers[0].IsRegionNull())
                    {
                        inputRegion.Text = dsResultados.Customers[0].Region;
                    }
                    else
                    {
                        inputRegion.Text = "";
                    }

                    btnModificar.Enabled = true;
                    Eliminar.Enabled = true;
                    btnModificar.BackColor = Color.FromArgb(141, 170, 157);
                    Eliminar.BackColor = Color.FromArgb(141, 170, 157);
                }
                else
                {
                    CustomAlert alert = new CustomAlert("No se encontro un usuario bajo ese ID!");
                    alert.Show();
                    activarInputs(false);
                    inputID.Enabled = true;
                    inputID.BackColor = Color.White;

                    btnModificar.Enabled = false;
                    Eliminar.Enabled = false;
                    Eliminar.BackColor = Color.DarkGray;
                    btnModificar.BackColor = Color.DarkGray;
                }
            }
            else if (clicks == 1)
            {
                activarInputs(false);
                CustomAlert alert = new CustomAlert("Ingrese un ID para buscar!");
                alert.Show();
                inputID.Enabled = true;
                inputID.BackColor = Color.White;
                btnModificar.Enabled = false;
                Eliminar.Enabled = false;
                Eliminar.BackColor = Color.DarkGray;
                btnModificar.BackColor = Color.DarkGray;
            }
            else if (clicks > 1)
            {
                timerAnimationID.Interval = 200;
                timerAnimationID.Start();
                activarInputs(false);
                inputID.Enabled = true;
                inputID.BackColor = Color.White;
            }
        }
        private void btnBuscarCustomer_Click(object sender, EventArgs e)
        {
            btnBuscarAux(VACIO);
        }                       
        

        private void btnAltaCustomer_Click(object sender, EventArgs e)
        {
            this.Focus();
            reiniciarClicks(FNALTA);
            activarInputs(true);
            if (inputID.Text != null & inputID.Text != "")
            {   
                if(inputCompanyName.Text != null & inputCompanyName.Text != "")
                {
                    bool existe = controlerClientes.comprobarIDExiste(inputID.Text.ToUpper());
                    if (!existe)
                    {
                        string values = $"'{inputID.Text.ToUpper()}','{inputCompanyName.Text}','{inputContactName.Text}','{inputContactTitle.Text}','{inputAddress.Text}','{inputCity.Text}','{inputRegion.Text}','{inputPostalCode.Text}','{inputCountry.Text}','{inputPhone.Text}','{inputFax.Text}'";
                        int resultado = controlerClientes.altaCustomer(values);
                        if(resultado > 0)
                        {
                            CustomAlert alert = new CustomAlert("Cliente añadido correctamente");
                            alert.Show();
                            limpiarInputs();
                        }
                    }
                    else if(existe & clicks == 1)
                    {
                        CustomAlert alert = new CustomAlert("El id NO esta disponible");
                        alert.Show();
                    }else if(existe & clicks > 1)
                    {
                        timerAnimationID.Interval = 200;
                        timerAnimationID.Start();
                   
                    }
                }
                else if(inputCompanyName.Text != null & clicks == 1| inputCompanyName.Text != "" & clicks == 1)
                {
                    CustomAlert alert = new CustomAlert("El campo Company Name es obligatorio!");
                    alert.Show();
                }else if(inputCompanyName.Text != null & clicks > 1 | inputCompanyName.Text != "" & clicks > 1)
                {
                    timerAnimationIDCompanyName.Interval = 200;
                    timerAnimationIDCompanyName.Start();

                }
            }
            else if (clicks == 1)
            {               
                CustomAlert alert = new CustomAlert("El campo ID es obligatorio!");
                alert.Show();                                
            }
            else if (clicks > 1)
            {
                timerAnimationID.Interval = 200;
                timerAnimationID.Start();                       
            }           

        }

      

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Focus();
            reiniciarClicks(FNMODIFICAR);
            activarInputs(true);
            if (inputID.Text != null & inputID.Text != "")
            {
                if (inputCompanyName.Text != null & inputCompanyName.Text != "")
                { 
                    bool existe = controlerClientes.comprobarIDExiste(inputID.Text.ToUpper());
                    if (existe)
                    {
                        string values = $"CustomerID = '{inputID.Text.ToUpper()}',CompanyName = '{inputCompanyName.Text.Replace("'", " ")}',ContactName = '{inputContactName.Text}',ContactTitle = '{inputContactTitle.Text}',Address = '{inputAddress.Text}',City = '{inputCity.Text}',Region = '{inputRegion.Text}',PostalCode = '{inputPostalCode.Text}',Country = '{inputCountry.Text}',Phone = '{inputPhone.Text}',Fax = '{inputFax.Text}'";
                        int resultado = controlerClientes.modificarCustomer(values, inputID.Text.ToUpper());
                        if (resultado > 0)
                        {
                            CustomAlert alert = new CustomAlert("Cliente modificado correctamente");
                            alert.Show();
                            limpiarInputs();
                        }
                    }
                    else
                    {
                        CustomAlert alert = new CustomAlert("No se encontro un cliente bajo ese ID!");
                        alert.Show();
                    }
                    

                }
                else if (inputCompanyName.Text != null & clicks == 1 | inputCompanyName.Text != "" & clicks == 1)
                {
                    CustomAlert alert = new CustomAlert("El campo Company Name es obligatorio!");
                    alert.Show();
                }
                else if (inputCompanyName.Text != null & clicks > 1 | inputCompanyName.Text != "" & clicks > 1)
                {
                    timerAnimationIDCompanyName.Interval = 200;
                    timerAnimationIDCompanyName.Start();

                }

            }
            else if (clicks == 1)
            {
                CustomAlert alert = new CustomAlert("El campo ID es obligatorio!");
                alert.Show();                
            }
            else if (clicks > 1)
            {
                timerAnimationID.Interval = 200;
                timerAnimationID.Start();               
            }

        }
     

        private void Eliminar_Click(object sender, EventArgs e)
        {
            this.Focus();
            reiniciarClicks(FNELIMINIAR);
            activarInputs(true);
            if (inputID.Text != null & inputID.Text != "")
            {                
                    bool existe = controlerClientes.comprobarIDExiste(inputID.Text.ToUpper());
                    if (existe)
                    {
                       
                        int resultado = controlerClientes.eliminarCustomer(inputID.Text.ToUpper());
                        if (resultado > 0)
                        {
                            CustomAlert alert = new CustomAlert("Cliente eliminado correctamente");
                            alert.Show();
                            limpiarInputs();
                        }
                    }
                    else
                    {
                        CustomAlert alert = new CustomAlert("No se encontro un cliente bajo ese ID!");
                        alert.Show();
                    }                
            }
            else if (clicks == 1)
            {
                CustomAlert alert = new CustomAlert("El campo ID es obligatorio!");
                alert.Show();              
            }
            else if (clicks > 1)
            {
                timerAnimationID.Interval = 200;
                timerAnimationID.Start();           
            }
        }

        int numRepeticiones = 0;
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if(numRepeticiones % 2 == 0)
            {
                inputID.BackColor = Color.CadetBlue;
            }
            else
            {
                inputID.BackColor = Color.White;
            }
            numRepeticiones++;
            if(numRepeticiones == 6)
            {
                timerAnimationID.Stop();
                numRepeticiones = 0;
            }
        }
       
        
        private void inputID_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
            inputID.SelectionStart = inputID.Text.Length;                        
            if (inputID.Text.Length >= 6)
            {              
                inputID.Text = inputID.Text.Substring(0, inputID.Text.Length -1);
            }
        }

        private void inputCompanyName_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
            inputCompanyName.SelectionStart = inputCompanyName.Text.Length;
            if (inputCompanyName.Text.Length >= 41)
            {
                inputCompanyName.Text = inputCompanyName.Text.Substring(0, inputCompanyName.Text.Length -1);
            }
        }

        private void inputContactName_TextChanged(object sender, EventArgs e)
        {
            inputContactName.SelectionStart = inputContactName.Text.Length;
            if (inputContactName.Text.Length >= 31)
            {
                inputContactName.Text = inputContactName.Text.Substring(0, inputContactName.Text.Length - 1);
            }
        }

        private void inputContactTitle_TextChanged(object sender, EventArgs e)
        {
            inputContactTitle.SelectionStart = inputContactTitle.Text.Length;
            if (inputContactTitle.Text.Length >= 31)
            {
                inputContactTitle.Text = inputContactTitle.Text.Substring(0, inputContactTitle.Text.Length - 1);
            }
        }

        private void inputAddress_TextChanged(object sender, EventArgs e)
        {
            inputAddress.SelectionStart = inputAddress.Text.Length;
            if (inputAddress.Text.Length >= 61)
            {
                inputAddress.Text = inputAddress.Text.Substring(0, inputAddress.Text.Length - 1);
            }
        }

        private void inputCity_TextChanged(object sender, EventArgs e)
        {
            inputCity.SelectionStart = inputCity.Text.Length;
            if (inputCity.Text.Length >= 16)
            {
                inputCity.Text = inputCity.Text.Substring(0, inputCity.Text.Length - 1);
            }
        }

        private void inputRegion_TextChanged(object sender, EventArgs e)
        {
            inputRegion.SelectionStart = inputRegion.Text.Length;
            if (inputRegion.Text.Length >= 16)
            {
                inputRegion.Text = inputRegion.Text.Substring(0, inputRegion.Text.Length - 1);
            }
        }

        private void inputPostalCode_TextChanged(object sender, EventArgs e)
        {
            inputPostalCode.SelectionStart = inputPostalCode.Text.Length;
            if (inputPostalCode.Text.Length >= 11)
            {
                inputPostalCode.Text = inputPostalCode.Text.Substring(0, inputPostalCode.Text.Length - 1);
            }
        }

        private void inputCountry_TextChanged(object sender, EventArgs e)
        {
            inputCountry.SelectionStart = inputCountry.Text.Length;
            if (inputCountry.Text.Length >= 16)
            {
                inputCountry.Text = inputCountry.Text.Substring(0, inputCountry.Text.Length - 1);
            }
        }

        private void inputPhone_TextChanged(object sender, EventArgs e)
        {
            inputPhone.SelectionStart = inputPhone.Text.Length;
            if (inputPhone.Text.Length >= 25)
            {
                inputPhone.Text = inputPhone.Text.Substring(0, inputPhone.Text.Length - 1);
            }
        }

        private void inputFax_TextChanged(object sender, EventArgs e)
        {
            inputFax.SelectionStart = inputFax.Text.Length;
            if (inputFax.Text.Length >= 25)
            {
                inputFax.Text = inputFax.Text.Substring(0, inputFax.Text.Length - 1);
            }
        }

        private void timerAnimationIDCompanyName_Tick(object sender, EventArgs e)
        {
            if (numRepeticiones % 2 == 0)
            {
                inputID.BackColor = Color.CadetBlue;
                inputCompanyName.BackColor = Color.CadetBlue;
            }
            else
            {
                inputID.BackColor = Color.White;
                inputCompanyName.BackColor = Color.White;
            }
            numRepeticiones++;
            if (numRepeticiones == 6)
            {
                timerAnimationIDCompanyName.Stop();
                numRepeticiones = 0;
            }
        }
        
        private void btnMinimizar_MouseHover(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(224, 26, 79);            
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(224, 26, 79);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(46, 49, 56);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(46, 49, 56);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            moverPanel = false;
        }
    }
}
