using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compras2
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void transaccionalComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Compras compras = new fr_Compras();
            compras.ShowDialog();

        }

        private void recepcionDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Recepcion_de_producto recepcion = new fr_Recepcion_de_producto();
            recepcion.ShowDialog();

        }

        private void transaccionalServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Compra_Servicio ser = new fr_Compra_Servicio();
            ser.ShowDialog();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Proveedores pro = new fr_Proveedores();
            pro.ShowDialog();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
           
    }
}
