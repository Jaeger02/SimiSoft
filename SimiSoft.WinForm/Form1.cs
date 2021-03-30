using SimiSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimiSoft.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (new Producto
            {
                codigo = txtCodigo.Text,
                descripcion=txtDescripcion.Text,
                unidadMedida=txtUnidadMedida.Text,
                precio=Convert.ToDecimal(txtPrecio.Text),
                stock=Convert.ToInt32(txtStock.Text),
                marca=txtMarca.Text
            }.Add() > 0)
            {
                MessageBox.Show("Registro exitoso", Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                gvProductos.DataSource = new Producto().GetAll();
            }
        }
    }
}
