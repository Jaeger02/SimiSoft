using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimiSoft
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach(Form form in Application.OpenForms)
                if(form.GetType() == typeof(frmProductos))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando productos...");

            new frmProductos() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmClientes))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando clientes...");

            new frmClientes() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void mnVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnAdminVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;

            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmVentas))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando ventas...");

            new frmVentas() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }
    }
}
