using App_Gestion_Northwind.Controler;
using System;
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
    public partial class CrearOrderView : Form
    {
        bool moverPanel = false;
        int mX, mY;
        const string ESPACIO_ANTES_PRODUCTO = "    ";
        string fecha = DateTime.Now.ToLongDateString();

        DateTime orderDateTime = DateTime.Now;
        string orderDate = DateTime.Now.ToString("dd/MM/yyyy");
        int idOrden = 0;
        string idCliente = "";
        DataSetNorthWind dsNortwind;
        DataSetResultados dsResultados;
        ControlerOrdenes controlOrdenes;
        public CrearOrderView(DataSetNorthWind pdsNortwind, DataSetResultados pdsResultados, object pcontrolOrdenes)
        {
            InitializeComponent();
            this.dsNortwind = pdsNortwind;
            dsResultados = pdsResultados;
            controlOrdenes = (ControlerOrdenes)pcontrolOrdenes;
        }

        public void reiniciarTicket()
        {
            inputID.Text = "";
            lblPaso.Text = "Selecciona el Cliente";
            lblCliente.Text = "Cliente: ";
            lblEncabezado.Visible = false;
            lblSeparador2.Visible = false;
            lblTotalTicket.Visible = false;
            listBoxTicket.Items.Clear();
            panelSeleccionProductos.Visible = false;
            dataGridMostrar.Visible = true;
            panelDetalleProducto.Visible = false;
            idOrden = controlOrdenes.nOrden();
            lblIDTicket.Text = "Ticket Nº " + idOrden;
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            controlOrdenes.mostrarMenuInicio();
            this.Close();
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
        int cantidadespaciosCorrecto = 46;


        private void CrearOrderView_Load(object sender, EventArgs e)
        {           
            reiniciarTicket();          
            lblTotalTicket.Text = "Total: 0";
            lblFechaTicket.Text = fecha;           
            dataGridMostrar.DataSource = dsNortwind.Customers;
            dataGridMostrar.Location = new Point(43, 36);
            dataGridMostrar.Size = new System.Drawing.Size(531, 450);
            dataGridViewMostrarProductos.DataSource = dsNortwind.Products;
        }

        private void auxAgregarClienteClick()
        {
            
            idCliente = dataGridMostrar.SelectedCells[0].Value.ToString();           
            lblCliente.Text = "Cliente: " + idCliente;
           // lblCliente.Text = "Cliente: " + dataGridMostrar.CurrentRow.Cells[0].Value.ToString();
            dataGridMostrar.Visible = false;
            panelSeleccionProductos.Visible = true;
            lblEncabezado.Visible = true;
            lblSeparador2.Visible = true;
            lblTotalTicket.Visible = true;
            panelDetalleProducto.Visible = true;
        }
        private void dataGridMostrar_DoubleClick(object sender, EventArgs e)
        {
            auxAgregarClienteClick();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }
        decimal total = 0m;

        private void auxClickAgregar()
        {
            cantidadespaciosCorrecto = 40;
            string idProducto = dataGridViewMostrarProductos.CurrentRow.Cells[0].Value.ToString();
            string formatLinea = dataGridViewMostrarProductos.CurrentRow.Cells[1].Value.ToString();
            int lengt = dataGridViewMostrarProductos.CurrentRow.Cells[1].Value.ToString().Length;
            string formatPrecio = dataGridViewMostrarProductos.CurrentRow.Cells[5].Value.ToString();
            decimal intPrecio = decimal.Parse(formatPrecio);
            decimal precioRedondeado = Math.Round(intPrecio, 2);
           
            string cantidad = "";
            if (comboBoxCantidad.SelectedIndex < 1)
            {
                cantidad = "1  ";
            }
            else
            {
                cantidad = comboBoxCantidad.SelectedItem.ToString();
                for(int u = cantidad.Length; u < 3; u++)
                {
                    cantidad += " ";
                }
            }
            string espacioEntreIdYNombre = "";
            for(int u = idProducto.Length;u<3; u++)
            {
                espacioEntreIdYNombre += " ";
            }
            for (int i = lengt; i <= cantidadespaciosCorrecto; i++)
            {
                formatLinea += " ";
            }
            decimal auxCantidad = decimal.Parse(cantidad.Trim());
            decimal auxtotal = auxCantidad * precioRedondeado;
            total += auxtotal;
            lblTotalTicket.Text = $"Total: {total}$";
            listBoxTicket.Items.Add(ESPACIO_ANTES_PRODUCTO + idProducto + espacioEntreIdYNombre + formatLinea + cantidad +"     " +precioRedondeado);
        }
        private void dataGridViewMostrarProductos_DoubleClick(object sender, EventArgs e)
        {
            if (btnConfirmarDato.Enabled)
            {
                auxClickAgregar();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            reiniciarTicket();
        }

        private bool auxcomprobarStock()
        {
            comboBoxCantidad.Items.Clear();
            bool hayStock = false;          
            int intStock = int.Parse(dataGridViewMostrarProductos.CurrentRow.Cells[6].Value.ToString());
            lblStock.Text = "Stock: " + dataGridViewMostrarProductos.CurrentRow.Cells[6].Value.ToString();
            if (intStock < 1)
            {
                comboBoxCantidad.Text = "0";
                comboBoxCantidad.Enabled = false;
                btnConfirmarDato.Enabled = false;
            }
            else
            {
                btnConfirmarDato.Enabled = true;
                hayStock = true;
                comboBoxCantidad.Text = "1";                
                comboBoxCantidad.Enabled = true;
            }
            if (hayStock)
            {
                for (int i = 1; i <= intStock; i++)
                {
                    if (i <= 10)
                    {
                        comboBoxCantidad.Items.Add(i);
                    }
                    else if (i > 10 & i % 10 == 0)
                    {
                        comboBoxCantidad.Items.Add(i);
                    }

                }
                comboBoxCantidad.Items.Add(intStock);
            }
            return hayStock;
        }
        private void dataGridViewMostrarProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            auxcomprobarStock();
                                             
        }

        private void btnConfirmarDato_Click(object sender, EventArgs e)
        {
            if (dataGridMostrar.Visible)
            {
                auxAgregarClienteClick();
                inputID.Text = "";
            }
            else
            {
                if (btnConfirmarDato.Enabled)
                {
                    auxClickAgregar();
                    inputID.Text = "";
                }
            }                        
        }

        private void auxBuscarCliente()
        {
            int indice = 0;
            foreach (DataRow row in dsNortwind.Customers.Rows)
            {
                if (row[0].ToString() == inputID.Text.ToUpper())
                {
                    dataGridMostrar.Rows[indice].Selected = true;
                    dataGridMostrar.FirstDisplayedScrollingRowIndex = indice;
                }
                indice++;
            }
            dataGridMostrar.Focus();
        }

        private void auxBuscarProducto()
        {
                      
            int indice = 0;
            foreach (DataRow row in dsNortwind.Products.Rows)
            {
                if (row[0].ToString() == inputID.Text)
                {
                    dataGridViewMostrarProductos.Rows[indice].Selected = true;
                    dataGridViewMostrarProductos.CurrentCell = dataGridViewMostrarProductos.Rows[indice].Cells[2];
                    dataGridViewMostrarProductos.FirstDisplayedScrollingRowIndex = indice;
                }
                indice++;
            }
            auxcomprobarStock();

            dataGridViewMostrarProductos.Focus();
        }

        private void auxBtnBuscarClick()
        {
            if (dataGridMostrar.Visible & inputID.Text != null & inputID.Text != "")
            {
                auxBuscarCliente();
            }else if (!dataGridMostrar.Visible & inputID.Text != null & inputID.Text != "")
            {
                auxBuscarProducto();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            auxBtnBuscarClick();
        }

        private void inputID_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                auxBtnBuscarClick();
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

        private void inputID_TextChanged(object sender, EventArgs e)
        {
            if (!dataGridMostrar.Visible)
            {
                permitirSoloNumeros(inputID, 3);
            }
        }

        private void btnEliminarLinea_Click(object sender, EventArgs e)
        {
            if(listBoxTicket.Items.Count > 0)
            {
                string linea = listBoxTicket.SelectedItem.ToString();
                string[] arrayLinea = linea.Split(" ");
                listBoxTicket.Items.Remove(listBoxTicket.SelectedItem);
                lblTotalTicket.Text = arrayLinea[arrayLinea.Length -1];
            }
        }

        private void btnConfirmarOrden_Click(object sender, EventArgs e)
        {
            List<string> detalleOrden = new List<string>();
            if (listBoxTicket.Items.Count > 0)
            {
                controlOrdenes.altaOrden(idCliente, orderDate);
                foreach(string str in listBoxTicket.Items)
                {
                    detalleOrden.Add(str);
                }
                int cantidadDetalles = controlOrdenes.altaDetallesOrden(detalleOrden, idOrden);
                CustomAlert alerta = new CustomAlert("Se han añadido: " + cantidadDetalles+ " a la tabla detalles");
                alerta.Show();
                reiniciarTicket();               

            }
        }

        private void dataGridViewMostrarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            moverPanel = false;

        }
    }
}
