﻿
namespace SimiSoft
{
    partial class frmMain
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
            this.bManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mnArchivo = new DevExpress.XtraBars.BarSubItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.mnCatalogos = new DevExpress.XtraBars.BarSubItem();
            this.btnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.btnProveedores = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tabMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.mnVentas = new DevExpress.XtraBars.BarButtonItem();
            this.barSmubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.nmVenta = new DevExpress.XtraBars.BarSubItem();
            this.btnAdminVentas = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // bManager
            // 
            this.bManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.bManager.DockControls.Add(this.barDockControlTop);
            this.bManager.DockControls.Add(this.barDockControlBottom);
            this.bManager.DockControls.Add(this.barDockControlLeft);
            this.bManager.DockControls.Add(this.barDockControlRight);
            this.bManager.Form = this;
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.mnArchivo,
            this.btnSalir,
            this.mnCatalogos,
            this.btnProductos,
            this.btnClientes,
            this.btnProveedores,
            this.skinBarSubItem1,
            this.nmVenta,
            this.btnAdminVentas});
            this.bManager.MainMenu = this.bar2;
            this.bManager.MaxItemId = 14;
            this.bManager.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnArchivo),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnCatalogos),
            new DevExpress.XtraBars.LinkPersistInfo(this.nmVenta),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // mnArchivo
            // 
            this.mnArchivo.Caption = "Archivo";
            this.mnArchivo.Id = 3;
            this.mnArchivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.mnArchivo.Name = "mnArchivo";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 4;
            this.btnSalir.Name = "btnSalir";
            // 
            // mnCatalogos
            // 
            this.mnCatalogos.Caption = "Catalogos";
            this.mnCatalogos.Id = 5;
            this.mnCatalogos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProductos),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClientes),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProveedores)});
            this.mnCatalogos.Name = "mnCatalogos";
            // 
            // btnProductos
            // 
            this.btnProductos.Caption = "Productos";
            this.btnProductos.Id = 6;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductos_ItemClick);
            // 
            // btnClientes
            // 
            this.btnClientes.Caption = "Clientes";
            this.btnClientes.Id = 7;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClientes_ItemClick);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Caption = "Proveedores";
            this.btnProveedores.Id = 8;
            this.btnProveedores.Name = "btnProveedores";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Apariencia";
            this.skinBarSubItem1.Id = 9;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bManager;
            this.barDockControlTop.Size = new System.Drawing.Size(753, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 383);
            this.barDockControlBottom.Manager = this.bManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(753, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.bManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 358);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(753, 25);
            this.barDockControlRight.Manager = this.bManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 358);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Salir";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // tabMdiManager
            // 
            this.tabMdiManager.MdiParent = this;
            // 
            // mnVentas
            // 
            this.mnVentas.Caption = "Ventas";
            this.mnVentas.Id = 10;
            this.mnVentas.Name = "mnVentas";
            this.mnVentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnVentas_ItemClick);
            // 
            // barSmubItem2
            // 
            this.barSmubItem2.Caption = "Ventas";
            this.barSmubItem2.Id = 11;
            this.barSmubItem2.Name = "barSmubItem2";
            // 
            // nmVenta
            // 
            this.nmVenta.Caption = "Ventas";
            this.nmVenta.Id = 12;
            this.nmVenta.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdminVentas)});
            this.nmVenta.Name = "nmVenta";
            // 
            // btnAdminVentas
            // 
            this.btnAdminVentas.Caption = "Administrar";
            this.btnAdminVentas.Id = 13;
            this.btnAdminVentas.Name = "btnAdminVentas";
            this.btnAdminVentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdminVentas_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 404);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimiSoft-2021";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mnArchivo;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarSubItem mnCatalogos;
        private DevExpress.XtraBars.BarButtonItem btnProductos;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.BarButtonItem btnProveedores;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMdiManager;
        private DevExpress.XtraBars.BarSubItem nmVenta;
        private DevExpress.XtraBars.BarButtonItem btnAdminVentas;
        private DevExpress.XtraBars.BarButtonItem mnVentas;
        private DevExpress.XtraBars.BarSubItem barSmubItem2;
    }
}

