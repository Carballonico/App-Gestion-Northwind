namespace App_Gestion_Northwind.View
{
    partial class CrearOrderView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearOrderView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelIzquierda = new System.Windows.Forms.Panel();
            this.panelDetalleProducto = new System.Windows.Forms.Panel();
            this.comboBoxCantidad = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.inputID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelSeleccionProductos = new System.Windows.Forms.Panel();
            this.dataGridViewMostrarProductos = new System.Windows.Forms.DataGridView();
            this.lblPaso = new System.Windows.Forms.Label();
            this.dataGridMostrar = new System.Windows.Forms.DataGridView();
            this.btnConfirmarDato = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelDerecha = new System.Windows.Forms.Panel();
            this.panelBotTicket = new System.Windows.Forms.Panel();
            this.lblTotalTicket = new System.Windows.Forms.Label();
            this.panelTopTicket = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblSeparador2 = new System.Windows.Forms.Label();
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblIDTicket = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblFechaTicket = new System.Windows.Forms.Label();
            this.lblNorthwind = new System.Windows.Forms.Label();
            this.listBoxTicket = new System.Windows.Forms.ListBox();
            this.btnEliminarLinea = new System.Windows.Forms.Button();
            this.lblFactura = new System.Windows.Forms.Label();
            this.btnConfirmarOrden = new System.Windows.Forms.Button();
            this.timerAnimator = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panelIzquierda.SuspendLayout();
            this.panelDetalleProducto.SuspendLayout();
            this.panelSeleccionProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar)).BeginInit();
            this.panelDerecha.SuspendLayout();
            this.panelBotTicket.SuspendLayout();
            this.panelTopTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 29);
            this.panel2.TabIndex = 25;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(6, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 25);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Northwind";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1185, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 26;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            this.btnMinimizar.MouseHover += new System.EventHandler(this.btnMinimizar_MouseHover);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1220, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
            // 
            // panelIzquierda
            // 
            this.panelIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(111)))), ((int)(((byte)(125)))));
            this.panelIzquierda.Controls.Add(this.panelDetalleProducto);
            this.panelIzquierda.Controls.Add(this.lblID);
            this.panelIzquierda.Controls.Add(this.inputID);
            this.panelIzquierda.Controls.Add(this.btnBuscar);
            this.panelIzquierda.Controls.Add(this.panelSeleccionProductos);
            this.panelIzquierda.Controls.Add(this.lblPaso);
            this.panelIzquierda.Controls.Add(this.dataGridMostrar);
            this.panelIzquierda.Controls.Add(this.btnConfirmarDato);
            this.panelIzquierda.Controls.Add(this.btnAtras);
            this.panelIzquierda.Location = new System.Drawing.Point(4, 33);
            this.panelIzquierda.Name = "panelIzquierda";
            this.panelIzquierda.Size = new System.Drawing.Size(619, 564);
            this.panelIzquierda.TabIndex = 26;
            // 
            // panelDetalleProducto
            // 
            this.panelDetalleProducto.Controls.Add(this.comboBoxCantidad);
            this.panelDetalleProducto.Controls.Add(this.lblCantidad);
            this.panelDetalleProducto.Controls.Add(this.lblStock);
            this.panelDetalleProducto.Controls.Add(this.lblProducto);
            this.panelDetalleProducto.Location = new System.Drawing.Point(43, 405);
            this.panelDetalleProducto.Name = "panelDetalleProducto";
            this.panelDetalleProducto.Size = new System.Drawing.Size(531, 87);
            this.panelDetalleProducto.TabIndex = 12;
            // 
            // comboBoxCantidad
            // 
            this.comboBoxCantidad.FormattingEnabled = true;
            this.comboBoxCantidad.Location = new System.Drawing.Point(104, 51);
            this.comboBoxCantidad.Name = "comboBoxCantidad";
            this.comboBoxCantidad.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCantidad.TabIndex = 15;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(3, 50);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 20);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(317, 51);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(48, 20);
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "Stock:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.Location = new System.Drawing.Point(3, 12);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(72, 20);
            this.lblProducto.TabIndex = 12;
            this.lblProducto.Text = "Producto:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(43, 497);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 20);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID:";
            // 
            // inputID
            // 
            this.inputID.Location = new System.Drawing.Point(43, 520);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(167, 23);
            this.inputID.TabIndex = 10;
            this.inputID.TextChanged += new System.EventHandler(this.inputID_TextChanged);
            this.inputID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputID_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(216, 505);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 50);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelSeleccionProductos
            // 
            this.panelSeleccionProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(96)))), ((int)(((byte)(110)))));
            this.panelSeleccionProductos.Controls.Add(this.dataGridViewMostrarProductos);
            this.panelSeleccionProductos.Location = new System.Drawing.Point(43, 36);
            this.panelSeleccionProductos.Name = "panelSeleccionProductos";
            this.panelSeleccionProductos.Size = new System.Drawing.Size(531, 363);
            this.panelSeleccionProductos.TabIndex = 8;
            // 
            // dataGridViewMostrarProductos
            // 
            this.dataGridViewMostrarProductos.AllowUserToAddRows = false;
            this.dataGridViewMostrarProductos.AllowUserToDeleteRows = false;
            this.dataGridViewMostrarProductos.AllowUserToResizeColumns = false;
            this.dataGridViewMostrarProductos.AllowUserToResizeRows = false;
            this.dataGridViewMostrarProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(96)))), ((int)(((byte)(110)))));
            this.dataGridViewMostrarProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMostrarProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(96)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMostrarProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMostrarProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMostrarProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMostrarProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewMostrarProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.dataGridViewMostrarProductos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMostrarProductos.MultiSelect = false;
            this.dataGridViewMostrarProductos.Name = "dataGridViewMostrarProductos";
            this.dataGridViewMostrarProductos.ReadOnly = true;
            this.dataGridViewMostrarProductos.RowHeadersVisible = false;
            this.dataGridViewMostrarProductos.RowTemplate.Height = 25;
            this.dataGridViewMostrarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostrarProductos.Size = new System.Drawing.Size(531, 363);
            this.dataGridViewMostrarProductos.TabIndex = 7;
            this.dataGridViewMostrarProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMostrarProductos_CellClick);
            this.dataGridViewMostrarProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMostrarProductos_CellContentClick);
            this.dataGridViewMostrarProductos.DoubleClick += new System.EventHandler(this.dataGridViewMostrarProductos_DoubleClick);
            // 
            // lblPaso
            // 
            this.lblPaso.AutoSize = true;
            this.lblPaso.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaso.ForeColor = System.Drawing.Color.White;
            this.lblPaso.Location = new System.Drawing.Point(195, 3);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new System.Drawing.Size(213, 30);
            this.lblPaso.TabIndex = 7;
            this.lblPaso.Text = "Selecciona el Cliente";
            // 
            // dataGridMostrar
            // 
            this.dataGridMostrar.AllowUserToAddRows = false;
            this.dataGridMostrar.AllowUserToDeleteRows = false;
            this.dataGridMostrar.AllowUserToResizeColumns = false;
            this.dataGridMostrar.AllowUserToResizeRows = false;
            this.dataGridMostrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(96)))), ((int)(((byte)(110)))));
            this.dataGridMostrar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridMostrar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(96)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMostrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMostrar.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMostrar.EnableHeadersVisualStyles = false;
            this.dataGridMostrar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.dataGridMostrar.Location = new System.Drawing.Point(8, 3);
            this.dataGridMostrar.MultiSelect = false;
            this.dataGridMostrar.Name = "dataGridMostrar";
            this.dataGridMostrar.ReadOnly = true;
            this.dataGridMostrar.RowHeadersVisible = false;
            this.dataGridMostrar.RowTemplate.Height = 25;
            this.dataGridMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMostrar.Size = new System.Drawing.Size(90, 48);
            this.dataGridMostrar.TabIndex = 6;
            this.dataGridMostrar.DoubleClick += new System.EventHandler(this.dataGridMostrar_DoubleClick);
            // 
            // btnConfirmarDato
            // 
            this.btnConfirmarDato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnConfirmarDato.FlatAppearance.BorderSize = 0;
            this.btnConfirmarDato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarDato.Location = new System.Drawing.Point(478, 505);
            this.btnConfirmarDato.Name = "btnConfirmarDato";
            this.btnConfirmarDato.Size = new System.Drawing.Size(125, 50);
            this.btnConfirmarDato.TabIndex = 5;
            this.btnConfirmarDato.Text = "Agregar";
            this.btnConfirmarDato.UseVisualStyleBackColor = false;
            this.btnConfirmarDato.Click += new System.EventHandler(this.btnConfirmarDato_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(347, 505);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(125, 50);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panelDerecha
            // 
            this.panelDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(111)))), ((int)(((byte)(125)))));
            this.panelDerecha.Controls.Add(this.panelBotTicket);
            this.panelDerecha.Controls.Add(this.panelTopTicket);
            this.panelDerecha.Controls.Add(this.listBoxTicket);
            this.panelDerecha.Controls.Add(this.btnEliminarLinea);
            this.panelDerecha.Controls.Add(this.lblFactura);
            this.panelDerecha.Controls.Add(this.btnConfirmarOrden);
            this.panelDerecha.Location = new System.Drawing.Point(628, 33);
            this.panelDerecha.Name = "panelDerecha";
            this.panelDerecha.Size = new System.Drawing.Size(619, 564);
            this.panelDerecha.TabIndex = 27;
            // 
            // panelBotTicket
            // 
            this.panelBotTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(96)))), ((int)(((byte)(110)))));
            this.panelBotTicket.Controls.Add(this.lblTotalTicket);
            this.panelBotTicket.Location = new System.Drawing.Point(47, 370);
            this.panelBotTicket.Name = "panelBotTicket";
            this.panelBotTicket.Size = new System.Drawing.Size(524, 34);
            this.panelBotTicket.TabIndex = 12;
            // 
            // lblTotalTicket
            // 
            this.lblTotalTicket.AutoSize = true;
            this.lblTotalTicket.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalTicket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTicket.Location = new System.Drawing.Point(377, 0);
            this.lblTotalTicket.Name = "lblTotalTicket";
            this.lblTotalTicket.Size = new System.Drawing.Size(147, 32);
            this.lblTotalTicket.TabIndex = 1;
            this.lblTotalTicket.Text = "Total: 251 $";
            // 
            // panelTopTicket
            // 
            this.panelTopTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(96)))), ((int)(((byte)(110)))));
            this.panelTopTicket.Controls.Add(this.lblEncabezado);
            this.panelTopTicket.Controls.Add(this.lblSeparador2);
            this.panelTopTicket.Controls.Add(this.lblSeparador1);
            this.panelTopTicket.Controls.Add(this.lblCliente);
            this.panelTopTicket.Controls.Add(this.lblIDTicket);
            this.panelTopTicket.Controls.Add(this.lblLugar);
            this.panelTopTicket.Controls.Add(this.lblFechaTicket);
            this.panelTopTicket.Controls.Add(this.lblNorthwind);
            this.panelTopTicket.Location = new System.Drawing.Point(47, 36);
            this.panelTopTicket.Name = "panelTopTicket";
            this.panelTopTicket.Size = new System.Drawing.Size(524, 164);
            this.panelTopTicket.TabIndex = 11;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezado.Location = new System.Drawing.Point(31, 123);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(467, 20);
            this.lblEncabezado.TabIndex = 7;
            this.lblEncabezado.Text = "ID            Producto                                                       Cant" +
    "          Precio ";
            // 
            // lblSeparador2
            // 
            this.lblSeparador2.AutoSize = true;
            this.lblSeparador2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeparador2.Location = new System.Drawing.Point(31, 28);
            this.lblSeparador2.Name = "lblSeparador2";
            this.lblSeparador2.Size = new System.Drawing.Size(447, 20);
            this.lblSeparador2.TabIndex = 6;
            this.lblSeparador2.Text = "-------------------------------------------------------------------------";
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.AutoSize = true;
            this.lblSeparador1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeparador1.Location = new System.Drawing.Point(31, 143);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(447, 20);
            this.lblSeparador1.TabIndex = 5;
            this.lblSeparador1.Text = "-------------------------------------------------------------------------";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(31, 103);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(62, 20);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente: ";
            // 
            // lblIDTicket
            // 
            this.lblIDTicket.AutoSize = true;
            this.lblIDTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIDTicket.Location = new System.Drawing.Point(31, 83);
            this.lblIDTicket.Name = "lblIDTicket";
            this.lblIDTicket.Size = new System.Drawing.Size(105, 20);
            this.lblIDTicket.TabIndex = 3;
            this.lblIDTicket.Text = "Ticket Nº 3240";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLugar.Location = new System.Drawing.Point(31, 63);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(75, 20);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "Barcelona";
            // 
            // lblFechaTicket
            // 
            this.lblFechaTicket.AutoSize = true;
            this.lblFechaTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaTicket.Location = new System.Drawing.Point(32, 43);
            this.lblFechaTicket.Name = "lblFechaTicket";
            this.lblFechaTicket.Size = new System.Drawing.Size(130, 20);
            this.lblFechaTicket.TabIndex = 1;
            this.lblFechaTicket.Text = "Fecha: 18/05/2023";
            // 
            // lblNorthwind
            // 
            this.lblNorthwind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNorthwind.AutoSize = true;
            this.lblNorthwind.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNorthwind.Location = new System.Drawing.Point(182, 0);
            this.lblNorthwind.Name = "lblNorthwind";
            this.lblNorthwind.Size = new System.Drawing.Size(138, 32);
            this.lblNorthwind.TabIndex = 0;
            this.lblNorthwind.Text = "Northwind";
            // 
            // listBoxTicket
            // 
            this.listBoxTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(96)))), ((int)(((byte)(110)))));
            this.listBoxTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTicket.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTicket.FormattingEnabled = true;
            this.listBoxTicket.ItemHeight = 17;
            this.listBoxTicket.Location = new System.Drawing.Point(47, 200);
            this.listBoxTicket.Name = "listBoxTicket";
            this.listBoxTicket.Size = new System.Drawing.Size(524, 170);
            this.listBoxTicket.TabIndex = 10;
            // 
            // btnEliminarLinea
            // 
            this.btnEliminarLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnEliminarLinea.FlatAppearance.BorderSize = 0;
            this.btnEliminarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLinea.Location = new System.Drawing.Point(104, 442);
            this.btnEliminarLinea.Name = "btnEliminarLinea";
            this.btnEliminarLinea.Size = new System.Drawing.Size(125, 50);
            this.btnEliminarLinea.TabIndex = 9;
            this.btnEliminarLinea.Text = "Eliminar Linea";
            this.btnEliminarLinea.UseVisualStyleBackColor = false;
            this.btnEliminarLinea.Click += new System.EventHandler(this.btnEliminarLinea_Click);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFactura.ForeColor = System.Drawing.Color.White;
            this.lblFactura.Location = new System.Drawing.Point(248, 3);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(143, 30);
            this.lblFactura.TabIndex = 8;
            this.lblFactura.Text = "Nueva Orden";
            // 
            // btnConfirmarOrden
            // 
            this.btnConfirmarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnConfirmarOrden.FlatAppearance.BorderSize = 0;
            this.btnConfirmarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarOrden.Location = new System.Drawing.Point(424, 442);
            this.btnConfirmarOrden.Name = "btnConfirmarOrden";
            this.btnConfirmarOrden.Size = new System.Drawing.Size(125, 50);
            this.btnConfirmarOrden.TabIndex = 4;
            this.btnConfirmarOrden.Text = "Confirmar";
            this.btnConfirmarOrden.UseVisualStyleBackColor = false;
            this.btnConfirmarOrden.Click += new System.EventHandler(this.btnConfirmarOrden_Click);
            // 
            // CrearOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1250, 600);
            this.Controls.Add(this.panelDerecha);
            this.Controls.Add(this.panelIzquierda);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearOrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearOrderView";
            this.Load += new System.EventHandler(this.CrearOrderView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelIzquierda.ResumeLayout(false);
            this.panelIzquierda.PerformLayout();
            this.panelDetalleProducto.ResumeLayout(false);
            this.panelDetalleProducto.PerformLayout();
            this.panelSeleccionProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar)).EndInit();
            this.panelDerecha.ResumeLayout(false);
            this.panelDerecha.PerformLayout();
            this.panelBotTicket.ResumeLayout(false);
            this.panelBotTicket.PerformLayout();
            this.panelTopTicket.ResumeLayout(false);
            this.panelTopTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label lblTitulo;
        private Button btnMinimizar;
        private Button btnCerrar;
        private Panel panelIzquierda;
        private Panel panelDerecha;
        private Button btnConfirmarDato;
        private Button btnAtras;
        private Button btnConfirmarOrden;
        private DataGridView dataGridMostrar;
        private Label lblPaso;
        private Label lblFactura;
        private Button btnEliminarLinea;
        private ListBox listBoxTicket;
        private Panel panelTopTicket;
        private Label lblFechaTicket;
        private Label lblNorthwind;
        private Label lblEncabezado;
        private Label lblSeparador2;
        private Label lblSeparador1;
        private Label lblCliente;
        private Label lblIDTicket;
        private Label lblLugar;
        private Panel panelBotTicket;
        private Label lblTotalTicket;
        private Panel panelSeleccionProductos;
        private DataGridView dataGridViewMostrarProductos;
        private Label lblID;
        private TextBox inputID;
        private Button btnBuscar;
        private ComboBox comboBoxCantidad;
        private Label lblStock;
        private Label lblCantidad;
        private Label lblProducto;
        private Panel panelDetalleProducto;
        private System.Windows.Forms.Timer timerAnimator;
    }
}