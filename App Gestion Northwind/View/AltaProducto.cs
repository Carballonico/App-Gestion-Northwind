using App_Gestion_Northwind.Controler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Gestion_Northwind.View
{
    public partial class AltaProducto : Form
    {
        int clicks = 0;
        bool moverPanel = false;
        int mX, mY;
        const string FNBUSCAR = "Buscar";
        const string FNALTA = "Alta";
        const string FNELIMINIAR = "Eliminar";
        const string FNMODIFICAR = "Modificar";
        string fn = "ninguna";
        const string VACIO = "";
        int numRepeticiones = 0;
        DataSetResultados dsResultados;
        DataSetNorthWind dsNorthwind;
        ControlerProductos controlProductos;
        ArrayList arrayAnimators = new ArrayList();
        public AltaProducto(object pcontrolProductos,DataSetResultados pdsResultados,DataSetNorthWind pdsNorthwind)
        {
            dsNorthwind = pdsNorthwind;
            dsResultados = pdsResultados;
            controlProductos = (ControlerProductos)pcontrolProductos;
            InitializeComponent();
        }

        private void btnBuscarCustomer_Click(object sender, EventArgs e)
        {
            btnBuscarAux(VACIO);
        }
        private void limpiarInputs()
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
                                if (c1 is TextBox)
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
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
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
       
        private void reiniciarClicks(string ultimaFn)
        {
            if (fn.Equals(ultimaFn))
            {
                clicks++;
            }
            else if (inputID.Enabled == false)
            {
                clicks = 0;
            }
            else
            {
                clicks = 1;
                fn = ultimaFn;
            }
        }

        public void btnBuscarAux(string id)
        {
            inputID.Enabled = true;
            inputID.BackColor = Color.White;
            if (!id.Equals(VACIO))
            {
                inputID.Text = id;
            }
            reiniciarClicks(FNBUSCAR);
            this.Focus();
            activarInputs(true);
            if (inputID.Text != null & inputID.Text != "")
            {
                controlProductos.buscarProducto(inputID.Text);
                if (dsResultados.Products.Count > 0)
                {
                    if (!dsResultados.Products[0].IsNull("ProductName"))
                    {
                        inputProductName.Text = dsResultados.Products[0].ProductName;
                    }
                    else
                    {
                        inputProductName.Text = "";
                    }
                    if (!dsResultados.Products[0].IsSupplierIDNull())
                    {
                        inputSupplierID.Text = dsResultados.Products[0].SupplierID.ToString();
                    }
                    else
                    {
                        inputSupplierID.Text = "";
                    }
                    if (!dsResultados.Products[0].IsCategoryIDNull())
                    {
                        inputCategoryID.Text = dsResultados.Products[0].CategoryID.ToString();
                    }
                    else
                    {
                        inputCategoryID.Text = "";
                    }
                    if (!dsResultados.Products[0].IsQuantityPerUnitNull())
                    {
                        inputQuantityPerUnit.Text = dsResultados.Products[0].QuantityPerUnit;
                    }
                    else
                    {
                        inputQuantityPerUnit.Text = "";
                    }
                    if (!dsResultados.Products[0].IsUnitPriceNull())
                    {
                        inputUnitPrice.Text = dsResultados.Products[0].UnitPrice.ToString();
                    }
                    else
                    {
                        inputUnitPrice.Text = "";
                    }
                    if (!dsResultados.Products[0].IsUnitsInStockNull())
                    {
                        inputUnitsInStock.Text = dsResultados.Products[0].UnitsInStock.ToString();
                    }
                    else
                    {
                        inputUnitsInStock.Text = "";
                    }
                    if (!dsResultados.Products[0].IsUnitsOnOrderNull())
                    {
                        inputUnitsOnOrder.Text = dsResultados.Products[0].UnitsOnOrder.ToString();
                    }
                    else
                    {
                        inputUnitsOnOrder.Text = "";
                    }
                    if (!dsResultados.Products[0].IsReorderLevelNull())
                    {
                        inputReorderLevel.Text = dsResultados.Products[0].ReorderLevel.ToString();
                    }
                    else
                    {
                        inputReorderLevel.Text = "";
                    }
                    inputDiscontinued.Checked = dsResultados.Products[0].Discontinued;
                    btnModificar.Enabled = true;
                    Eliminar.Enabled = true;
                    btnModificar.BackColor = Color.FromArgb(141, 170, 157);
                    Eliminar.BackColor = Color.FromArgb(141, 170, 157);
                }
                else
                {
                    CustomAlert alert = new CustomAlert("No se encontro un poducto bajo ese ID!");
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
                arrayAnimators.Clear();
                arrayAnimators.Add(inputID);
                timerAnimationID.Start();
                activarInputs(false);
                inputID.Enabled = true;
                inputID.BackColor = Color.White;
            }
        }

        private void timerAnimationID_Tick(object sender, EventArgs e)
        {
            if(arrayAnimators.Count > 0)
            {
                foreach(Control obj in arrayAnimators)
                {
                    if (numRepeticiones % 2 == 0)
                    {
                        obj.BackColor = Color.CadetBlue;
                    }
                    else
                    {
                        obj.BackColor = Color.White;
                    }
                }
            }          
            numRepeticiones++;
            if (numRepeticiones == 6)
            {
                timerAnimationID.Stop();
                numRepeticiones = 0;
            }
        }

        private void inputID_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
            permitirSoloNumeros(inputID,3);
        }

        private void btnAltaCustomer_Click(object sender, EventArgs e)
        {
            reiniciarClicks(FNALTA);
            activarInputs(true);
            inputID.Text = "";
            inputID.Enabled = false;
            inputID.BackColor = Color.DimGray;
            arrayAnimators.Clear();
            this.Focus();
            bool supplierBien = false;
            bool categoryBien= false;            
                if (inputProductName.Text != null & inputProductName.Text != "")
                {
                    if(inputSupplierID.Text != null & inputSupplierID.Text != "")
                    {
                         supplierBien = controlProductos.comprobarSupplierID(int.Parse(inputSupplierID.Text));
                    }
                    else
                    {
                        supplierBien = true;
                    }

                    if(inputCategoryID.Text != null & inputCategoryID.Text != "")
                    {
                        categoryBien = controlProductos.comprobarCategoryID(int.Parse(inputCategoryID.Text));
                    }
                    else
                    {
                        categoryBien = true;
                    }
                    
                    if (supplierBien & categoryBien)
                    {

                        string values = crearStingValuesAltaProducto();
                        int resultado = controlProductos.altaProducto(values);
                        if (resultado > 0)
                        {
                            CustomAlert alert = new CustomAlert("Producto añadido correctamente");
                            alert.Show();
                            limpiarInputs();
                        }
                    }                  
                    if (!supplierBien & clicks == 1)
                    {
                        CustomAlert alert = new CustomAlert("El id del Supplier no es valido");
                        alert.Show();
                    }else if (!supplierBien & clicks > 1)
                    {                    
                        arrayAnimators.Add(inputSupplierID);
                        timerAnimationID.Start();
                    }

                    if(!categoryBien & clicks == 1)
                    {
                        CustomAlert alert = new CustomAlert("El id de la Categoria no es valido");
                        alert.Show();
                    }
                    else if (!categoryBien & clicks > 1)
                    {
                        arrayAnimators.Add(inputCategoryID);
                        timerAnimationID.Start();
                    }
                }
                else if(clicks ==1)
                {
                    CustomAlert alert = new CustomAlert("El campo Product Name es obligatorio!");
                    alert.Show();
                }
                else if (clicks > 1)
                {                   
                    arrayAnimators.Add(inputProductName);
                    timerAnimationID.Start();
                }
            clicks++;
            
        }

        private string crearStingValuesAltaProducto()
        {
            string values = $"'{inputProductName.Text}',";
            if (inputSupplierID.Text != null & inputSupplierID.Text != "")
            {
                values += $"{inputSupplierID.Text},";
            }
            else
            {
                values += "null,";
            }
            if(inputCategoryID.Text != null & inputCategoryID.Text != "")
            {
                values += $"{inputCategoryID.Text},";
            }
            else
            {
                values += "null,";
            }
            if(inputQuantityPerUnit.Text != null & inputQuantityPerUnit.Text != "")
            {
                values += $"'{inputQuantityPerUnit.Text}',";
            }
            else
            {
                values += "'',";
            }
            if (inputUnitPrice.Text != null & inputUnitPrice.Text != "")
            {
                values += $"{inputUnitPrice.Text},";
            }
            else
            {
                values += "null,";
            }
            if (inputUnitsInStock.Text != null & inputUnitsInStock.Text != "")
            {
                values += $"{inputUnitsInStock.Text},";
            }
            else
            {
                values += "null,";
            }
            if (inputUnitsOnOrder.Text != null & inputUnitsOnOrder.Text != "")
            {
                values += $"{inputUnitsOnOrder.Text},";
            }
            else
            {
                values += "null,";
            }
            if (inputReorderLevel.Text != null & inputReorderLevel.Text != "")
            {
                values += $"{inputReorderLevel.Text},";
            }
            else
            {
                values += "null,";
            }
            if (inputDiscontinued.Checked)
            {
                values += "1";
            }
            else
            {
                values += "0";
            }
            return values;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarInputs();
        }

        private void inputProductName_TextChanged(object sender, EventArgs e)
        {
            inputProductName.SelectionStart = inputProductName.Text.Length;
            if (inputProductName.Text.Length >= 41)
            {
                inputProductName.Text = inputProductName.Text.Substring(0, inputProductName.Text.Length - 1);
            }
        }


        private void permitirSoloNumeros(TextBox control, int maximocaracteres)
        {
            maximocaracteres += 1;
            control.SelectionStart = control.Text.Length;
            try
            {
                int auxint = int.Parse(control.Text);
                if (control.Text.Length >= maximocaracteres)
                {
                    control.Text = control.Text.Substring(0, control.Text.Length - 1);
                }
            }
            catch
            {
                if (control.Text.Length > 1)
                {
                    control.Text = control.Text.Substring(0, control.Text.Length - 1);
                }
                else
                {
                    control.Text = "";
                }
            }
        }
        private void inputSupplierID_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
            permitirSoloNumeros(inputSupplierID, 2);
        }

        private void inputCategoryID_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
            permitirSoloNumeros(inputCategoryID, 1);
        }

        private void inputQuantityPerUnit_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
           
        }

        private void inputUnitPrice_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
            permitirSoloNumeros(inputUnitPrice, 4);
        }

        private void inputUnitsInStock_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
            permitirSoloNumeros(inputUnitsInStock, 4);
        }

        private void inputUnitsOnOrder_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
            permitirSoloNumeros(inputUnitsOnOrder, 4);
        }

        private void inputReorderLevel_TextChanged(object sender, EventArgs e)
        {
            clicks = 0;
            permitirSoloNumeros(inputReorderLevel, 2);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            moverPanel = true;
            mX = e.X;
            mY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (moverPanel)
            {
                this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
            }
        }

        private void btnMinimizar_MouseHover(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Crimson;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(46, 49, 56);
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Crimson;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(46, 49, 56);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            moverPanel = false;
        }
    }
}
