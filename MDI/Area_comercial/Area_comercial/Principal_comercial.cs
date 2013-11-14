using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Area_comercial
{
    public partial class Principal_comercial : Form
    {
        public Principal_comercial()
        {
            InitializeComponent();
        }

        private void abrir_form(Form f)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Factura());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new form_clientes());
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new form_vendedores());
        }

        private void ordenesDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new fr_Compras());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new fr_Proveedores());
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new frm_cuentras_por_pagar());
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new frm_cuentas_por_cobrar());
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new fr_consultas());
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new fr_bodega());
        }

        private void pagosDeServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new fr_Compra_Servicio());
        }

        private void recepciónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new fr_Recepcion_de_producto());
        }

        private void saldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_form(new Saldos());
        }


    }
}
