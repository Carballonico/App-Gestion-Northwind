using App_Gestion_Northwind.Controler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Gestion_Northwind.View
{
    public partial class Inicio : Form
    {
        bool moverPanel = false;
        int mX, mY;
        AppControler controler;
        DataSetResultados dsResultados;
        public Inicio(object pcontroler,DataSetResultados pDsResultados)
        {
            InitializeComponent();
            controler = (AppControler)pcontroler;
            dsResultados = pDsResultados;
            
        }
        ArrayList arrayPictures = new ArrayList();

        int[] arrFotos = {1,2,3,4,5,6,7,8};

        int i = 1;
        private void Inicio_Load(object sender, EventArgs e)
        {
            arrayPictures.Add(pictureBox1);        
            int i = 1;
            pictureBox1.Image = controler.cargarFoto(i);
            lblEmpleado.Text = dsResultados.Employees[0].FirstName.ToString() + " " + dsResultados.Employees[0].LastName.ToString();
            timer1.Start();
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(i == 1)
            {
                i = 8;
            }
            else
            {
                i--;
            }
            pictureBox1.Image = controler.cargarFoto(i);
            lblEmpleado.Text = dsResultados.Employees[0].FirstName.ToString() + " " + dsResultados.Employees[0].LastName.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 8)
            {
                i = 1;
            }
            else
            {
                i++;
            }
            pictureBox1.Image = controler.cargarFoto(i);
            lblEmpleado.Text = dsResultados.Employees[0].FirstName.ToString() + " " + dsResultados.Employees[0].LastName.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           controler.menuClientes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controler.menuProductos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
         
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            controler.menuOrdenes();
        }

        

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            moverPanel = false;

            
        }
    }
}
