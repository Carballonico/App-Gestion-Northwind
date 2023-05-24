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
    public partial class CustomAlert : Form
    {
        string msg;
        public CustomAlert(string pmsg)
        {
            InitializeComponent();
            msg = pmsg;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        bool moverPanel = false;
        int mX, mY;

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            moverPanel = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (moverPanel)
            {
                this.SetDesktopLocation(MousePosition.X - mX, MousePosition.Y - mY);
            }
        }

        private void CustomAlert_Load(object sender, EventArgs e)
        {
            lblMensajeAlerta.Text = msg;
            
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            moverPanel = true;
            mX = e.X;
            mY = e.Y;
        }

        
        
    }
}
