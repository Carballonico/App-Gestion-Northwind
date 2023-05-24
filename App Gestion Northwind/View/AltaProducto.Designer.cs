namespace App_Gestion_Northwind.View
{
    partial class AltaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaProducto));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.inputID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputProductName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputReorderLevel = new System.Windows.Forms.TextBox();
            this.inputSupplierID = new System.Windows.Forms.TextBox();
            this.inputUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.inputCategoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputUnitPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputUnitsInStock = new System.Windows.Forms.TextBox();
            this.inputDiscontinued = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAltaCustomer = new System.Windows.Forms.Button();
            this.btnBuscarCustomer = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.timerAnimationID = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(507, 29);
            this.panel2.TabIndex = 23;
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
            this.lblTitulo.Size = new System.Drawing.Size(161, 25);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Menu Productos";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(445, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(477, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 554);
            this.panel1.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(111)))), ((int)(((byte)(125)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputProductName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputReorderLevel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.inputSupplierID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputUnitsOnOrder, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.inputCategoryID, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.inputUnitPrice, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.inputQuantityPerUnit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.inputUnitsInStock, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.inputDiscontinued, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090081F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090992F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 548);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Product ID";
            // 
            // inputID
            // 
            this.inputID.Location = new System.Drawing.Point(177, 3);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(165, 23);
            this.inputID.TabIndex = 25;
            this.inputID.TextChanged += new System.EventHandler(this.inputID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // inputProductName
            // 
            this.inputProductName.Location = new System.Drawing.Point(177, 57);
            this.inputProductName.Name = "inputProductName";
            this.inputProductName.Size = new System.Drawing.Size(165, 23);
            this.inputProductName.TabIndex = 0;
            this.inputProductName.TextChanged += new System.EventHandler(this.inputProductName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Discontinued";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier ID";
            // 
            // inputReorderLevel
            // 
            this.inputReorderLevel.Location = new System.Drawing.Point(177, 435);
            this.inputReorderLevel.Name = "inputReorderLevel";
            this.inputReorderLevel.Size = new System.Drawing.Size(165, 23);
            this.inputReorderLevel.TabIndex = 17;
            this.inputReorderLevel.TextChanged += new System.EventHandler(this.inputReorderLevel_TextChanged);
            // 
            // inputSupplierID
            // 
            this.inputSupplierID.Location = new System.Drawing.Point(177, 111);
            this.inputSupplierID.Name = "inputSupplierID";
            this.inputSupplierID.Size = new System.Drawing.Size(165, 23);
            this.inputSupplierID.TabIndex = 2;
            this.inputSupplierID.TextChanged += new System.EventHandler(this.inputSupplierID_TextChanged);
            // 
            // inputUnitsOnOrder
            // 
            this.inputUnitsOnOrder.Location = new System.Drawing.Point(177, 381);
            this.inputUnitsOnOrder.Name = "inputUnitsOnOrder";
            this.inputUnitsOnOrder.Size = new System.Drawing.Size(165, 23);
            this.inputUnitsOnOrder.TabIndex = 16;
            this.inputUnitsOnOrder.TextChanged += new System.EventHandler(this.inputUnitsOnOrder_TextChanged);
            // 
            // inputCategoryID
            // 
            this.inputCategoryID.Location = new System.Drawing.Point(177, 165);
            this.inputCategoryID.Name = "inputCategoryID";
            this.inputCategoryID.Size = new System.Drawing.Size(165, 23);
            this.inputCategoryID.TabIndex = 3;
            this.inputCategoryID.TextChanged += new System.EventHandler(this.inputCategoryID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Reorder Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category ID";
            // 
            // inputUnitPrice
            // 
            this.inputUnitPrice.Location = new System.Drawing.Point(177, 273);
            this.inputUnitPrice.Name = "inputUnitPrice";
            this.inputUnitPrice.Size = new System.Drawing.Size(165, 23);
            this.inputUnitPrice.TabIndex = 14;
            this.inputUnitPrice.TextChanged += new System.EventHandler(this.inputUnitPrice_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Units On Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity Per Unit";
            // 
            // inputQuantityPerUnit
            // 
            this.inputQuantityPerUnit.Location = new System.Drawing.Point(177, 219);
            this.inputQuantityPerUnit.Name = "inputQuantityPerUnit";
            this.inputQuantityPerUnit.Size = new System.Drawing.Size(165, 23);
            this.inputQuantityPerUnit.TabIndex = 13;
            this.inputQuantityPerUnit.TextChanged += new System.EventHandler(this.inputQuantityPerUnit_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Units In Stock";
            // 
            // inputUnitsInStock
            // 
            this.inputUnitsInStock.Location = new System.Drawing.Point(177, 327);
            this.inputUnitsInStock.Name = "inputUnitsInStock";
            this.inputUnitsInStock.Size = new System.Drawing.Size(165, 23);
            this.inputUnitsInStock.TabIndex = 28;
            this.inputUnitsInStock.TextChanged += new System.EventHandler(this.inputUnitsInStock_TextChanged);
            // 
            // inputDiscontinued
            // 
            this.inputDiscontinued.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputDiscontinued.Appearance = System.Windows.Forms.Appearance.Button;
            this.inputDiscontinued.AutoSize = true;
            this.inputDiscontinued.BackColor = System.Drawing.Color.White;
            this.inputDiscontinued.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.inputDiscontinued.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.inputDiscontinued.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputDiscontinued.Location = new System.Drawing.Point(246, 502);
            this.inputDiscontinued.MinimumSize = new System.Drawing.Size(30, 30);
            this.inputDiscontinued.Name = "inputDiscontinued";
            this.inputDiscontinued.Size = new System.Drawing.Size(30, 30);
            this.inputDiscontinued.TabIndex = 29;
            this.inputDiscontinued.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(370, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 553);
            this.panel3.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(111)))), ((int)(((byte)(125)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnModificar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnAltaCustomer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarCustomer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Eliminar, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(131, 548);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(3, 356);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 51);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAltaCustomer
            // 
            this.btnAltaCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnAltaCustomer.FlatAppearance.BorderSize = 0;
            this.btnAltaCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCustomer.Location = new System.Drawing.Point(3, 138);
            this.btnAltaCustomer.Name = "btnAltaCustomer";
            this.btnAltaCustomer.Size = new System.Drawing.Size(125, 51);
            this.btnAltaCustomer.TabIndex = 26;
            this.btnAltaCustomer.Text = "Alta";
            this.btnAltaCustomer.UseVisualStyleBackColor = false;
            this.btnAltaCustomer.Click += new System.EventHandler(this.btnAltaCustomer_Click);
            // 
            // btnBuscarCustomer
            // 
            this.btnBuscarCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnBuscarCustomer.FlatAppearance.BorderSize = 0;
            this.btnBuscarCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCustomer.Location = new System.Drawing.Point(3, 29);
            this.btnBuscarCustomer.Name = "btnBuscarCustomer";
            this.btnBuscarCustomer.Size = new System.Drawing.Size(125, 51);
            this.btnBuscarCustomer.TabIndex = 25;
            this.btnBuscarCustomer.Text = "Buscar";
            this.btnBuscarCustomer.UseVisualStyleBackColor = false;
            this.btnBuscarCustomer.Click += new System.EventHandler(this.btnBuscarCustomer_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(3, 466);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 51);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Location = new System.Drawing.Point(3, 247);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(125, 51);
            this.Eliminar.TabIndex = 23;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            // 
            // timerAnimationID
            // 
            this.timerAnimationID.Interval = 200;
            this.timerAnimationID.Tick += new System.EventHandler(this.timerAnimationID_Tick);
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 583);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaProducto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label lblTitulo;
        private Button btnMinimizar;
        private Button btnCerrar;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private TextBox inputID;
        private Label label1;
        private TextBox inputProductName;
        private Label label9;
        private Label label2;
        private TextBox inputReorderLevel;
        private TextBox inputSupplierID;
        private TextBox inputUnitsOnOrder;
        private TextBox inputCategoryID;
        private Label label8;
        private Label label3;
        private TextBox inputUnitPrice;
        private Label label7;
        private Label label4;
        private TextBox inputQuantityPerUnit;
        private Label label5;
        private Label label6;
        private TextBox inputUnitsInStock;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnModificar;
        private Button btnAltaCustomer;
        private Button btnBuscarCustomer;
        private Button btnCancelar;
        private Button Eliminar;
        private CheckBox inputDiscontinued;
        private System.Windows.Forms.Timer timerAnimationID;
    }
}