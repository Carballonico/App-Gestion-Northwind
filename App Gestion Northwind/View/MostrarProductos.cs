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
    public partial class MostrarProductos : Form
    {
        DataSetNorthWind dsNortwind;
        ControlerProductos controlProductos;
        public MostrarProductos(object pcontrolProductos, DataSetNorthWind pdsNortwind)
        {
            InitializeComponent();
            dsNortwind = pdsNortwind;
            controlProductos = (ControlerProductos)pcontrolProductos;
        }

        private void MostrarProductos_Load(object sender, EventArgs e)
        {
            dataGridMostrar.DataSource = dsNortwind.Products;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        bool moverPanel = false;
        int mX, mY;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (moverPanel)
            {
                this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
            }
        }      

        private void panel2_MouseUp_1(object sender, MouseEventArgs e)
        {
            moverPanel = false;
        }

        private void btnMinimizar_MouseHover(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(224, 26, 79);
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(224, 26, 79);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(46, 49, 56);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(46, 49, 56);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            moverPanel = true;
            mX = e.X;
            mY = e.Y;
        }

        private void btnBuscarCustomer_Click(object sender, EventArgs e)
        {
            btnBuscarClickAux();
        }

        private void inputID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscarClickAux();
            }
        }

        private void inputID_TextChanged(object sender, EventArgs e)
        {
            inputID.SelectionStart = inputID.Text.Length;
            if (inputID.Text.Length >= 4)
            {
                inputID.Text = inputID.Text.Substring(0, inputID.Text.Length - 1);
            }
        }

        private void dataGridMostrar_DoubleClick(object sender, EventArgs e)
        {
            string id = dataGridMostrar.CurrentRow.Cells[0].Value.ToString();
            controlProductos.menuEditarProducto(id);
        }

        private void btnBuscarClickAux()
        {
            int indice = 0;
            foreach (DataRow row in dsNortwind.Products.Rows)
            {
                if (row[0].ToString() == inputID.Text)
                {
                    dataGridMostrar.Rows[indice].Selected = true;
                    dataGridMostrar.FirstDisplayedScrollingRowIndex = indice;
                }
                indice++;
            }
            dataGridMostrar.Focus();
        }

    }
}
