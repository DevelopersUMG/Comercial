using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace compras
{
    public partial class mdiprincipal : Form
    {
        public mdiprincipal()
        {
            InitializeComponent();
        }

        private void traToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Compras tran_compras = new fr_Compras();
            tran_compras.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Proveedores prov = new fr_Proveedores();
            prov.ShowDialog();
        }

        private void traToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Compra_Servicio servicio = new Compra_Servicio();
            servicio.ShowDialog();

        }

        private void recpsionDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion_de_producto rep = new Recepcion_de_producto();
            rep.ShowDialog();

        }

      


    }
}
