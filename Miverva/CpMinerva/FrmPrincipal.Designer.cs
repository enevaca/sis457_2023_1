namespace CpMinerva
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.tabCatalogos = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProductos = new C1.Win.C1Ribbon.RibbonButton();
            this.btnProveedores = new C1.Win.C1Ribbon.RibbonButton();
            this.tabOperaciones = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.tabAdministracion = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.tabAyuda = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnRegistrarCompra = new C1.Win.C1Ribbon.RibbonButton();
            this.btnRegistrarVenta = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonGroup5 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnBusquedaVentas = new C1.Win.C1Ribbon.RibbonButton();
            this.btnArqueoCaja = new C1.Win.C1Ribbon.RibbonButton();
            this.btnEmpleados = new C1.Win.C1Ribbon.RibbonButton();
            this.btnUsuarios = new C1.Win.C1Ribbon.RibbonButton();
            this.btnManualUsuario = new C1.Win.C1Ribbon.RibbonButton();
            this.btnAcercaDe = new C1.Win.C1Ribbon.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(848, 154);
            this.c1Ribbon1.Tabs.Add(this.tabCatalogos);
            this.c1Ribbon1.Tabs.Add(this.tabOperaciones);
            this.c1Ribbon1.Tabs.Add(this.tabAdministracion);
            this.c1Ribbon1.Tabs.Add(this.tabAyuda);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Black;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // tabCatalogos
            // 
            this.tabCatalogos.Groups.Add(this.ribbonGroup1);
            this.tabCatalogos.Name = "tabCatalogos";
            this.tabCatalogos.Text = "Catálogos";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnProductos);
            this.ribbonGroup1.Items.Add(this.btnProveedores);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Administración de Catálogos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CpMinerva.Properties.Resources.principal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.LargeImage")));
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.SmallImage")));
            this.btnProductos.Text = "Productos";
            this.btnProductos.ToolTip = "Gestión de Productos";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.LargeImage")));
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.SmallImage")));
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.ToolTip = "Gestión de Proveedores";
            // 
            // tabOperaciones
            // 
            this.tabOperaciones.Groups.Add(this.ribbonGroup2);
            this.tabOperaciones.Groups.Add(this.ribbonGroup5);
            this.tabOperaciones.Name = "tabOperaciones";
            this.tabOperaciones.Text = "Operaciones";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.btnRegistrarCompra);
            this.ribbonGroup2.Items.Add(this.btnRegistrarVenta);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Compras y Ventas";
            // 
            // tabAdministracion
            // 
            this.tabAdministracion.Groups.Add(this.ribbonGroup3);
            this.tabAdministracion.Name = "tabAdministracion";
            this.tabAdministracion.Text = "Administración";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.btnEmpleados);
            this.ribbonGroup3.Items.Add(this.btnUsuarios);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Administración";
            // 
            // tabAyuda
            // 
            this.tabAyuda.Groups.Add(this.ribbonGroup4);
            this.tabAyuda.Name = "tabAyuda";
            this.tabAyuda.Text = "Ayuda";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.btnManualUsuario);
            this.ribbonGroup4.Items.Add(this.btnAcercaDe);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Ayuda";
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCompra.LargeImage")));
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCompra.SmallImage")));
            this.btnRegistrarCompra.Text = "Registrar Compra";
            this.btnRegistrarCompra.ToolTip = "Registrar Compra";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarVenta.LargeImage")));
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarVenta.SmallImage")));
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.ToolTip = "Registrar Venta";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.btnBusquedaVentas);
            this.ribbonGroup5.Items.Add(this.btnArqueoCaja);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Búsqueda";
            // 
            // btnBusquedaVentas
            // 
            this.btnBusquedaVentas.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBusquedaVentas.LargeImage")));
            this.btnBusquedaVentas.Name = "btnBusquedaVentas";
            this.btnBusquedaVentas.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnBusquedaVentas.SmallImage")));
            this.btnBusquedaVentas.Text = "Ventas";
            this.btnBusquedaVentas.ToolTip = "Búsqueda de Ventas";
            // 
            // btnArqueoCaja
            // 
            this.btnArqueoCaja.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnArqueoCaja.LargeImage")));
            this.btnArqueoCaja.Name = "btnArqueoCaja";
            this.btnArqueoCaja.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnArqueoCaja.SmallImage")));
            this.btnArqueoCaja.Text = "Arqueo de Caja";
            this.btnArqueoCaja.ToolTip = "Arqueo de Caja";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.LargeImage")));
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.SmallImage")));
            this.btnEmpleados.Text = "Empleados";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.LargeImage")));
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.SmallImage")));
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.ToolTip = "Gestión de Usuarios";
            // 
            // btnManualUsuario
            // 
            this.btnManualUsuario.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnManualUsuario.LargeImage")));
            this.btnManualUsuario.Name = "btnManualUsuario";
            this.btnManualUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnManualUsuario.SmallImage")));
            this.btnManualUsuario.Text = "Manual de Usuario";
            this.btnManualUsuario.ToolTip = "Manual de Usuario";
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAcercaDe.LargeImage")));
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAcercaDe.SmallImage")));
            this.btnAcercaDe.Text = "Acerca De";
            this.btnAcercaDe.ToolTip = "Acerca De";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Minerva - Principal :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab tabCatalogos;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private C1.Win.C1Ribbon.RibbonButton btnProductos;
        private C1.Win.C1Ribbon.RibbonButton btnProveedores;
        private C1.Win.C1Ribbon.RibbonTab tabOperaciones;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.C1Ribbon.RibbonButton btnRegistrarCompra;
        private C1.Win.C1Ribbon.RibbonButton btnRegistrarVenta;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.C1Ribbon.RibbonButton btnBusquedaVentas;
        private C1.Win.C1Ribbon.RibbonButton btnArqueoCaja;
        private C1.Win.C1Ribbon.RibbonTab tabAdministracion;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.C1Ribbon.RibbonTab tabAyuda;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.C1Ribbon.RibbonButton btnEmpleados;
        private C1.Win.C1Ribbon.RibbonButton btnUsuarios;
        private C1.Win.C1Ribbon.RibbonButton btnManualUsuario;
        private C1.Win.C1Ribbon.RibbonButton btnAcercaDe;
    }
}