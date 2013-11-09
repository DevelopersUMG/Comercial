using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventarios
{
    public partial class fr_p : Form
    {
        public fr_p()
        {
            InitializeComponent();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_bodega n = new fr_bodega();
            n.MdiParent = this;
            n.WindowState = FormWindowState.Maximized;
            n.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_consultas n = new fr_consultas();
            n.MdiParent = this;
            n.WindowState = FormWindowState.Maximized;
            n.Show();
        }

        private void fr_p_Load(object sender, EventArgs e)
        {

        }
    }
}
