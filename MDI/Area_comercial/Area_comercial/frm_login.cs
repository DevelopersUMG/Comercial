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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            //this.toolTip1.SetToolTip(textBox2, "Usuario con el que desea probar el prototipo");
            //this.toolTip1.SetToolTip(textBox1, "Nombre de la ODBC a utilizar como ESTANDAR en ADST");
            //this.toolTip1.SetToolTip(comboBox1, "Listado de roles que se desean probar (Adaptarlos al area)");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.xrol = comboBox1.Text;
            //Properties.Settings.Default.xusuario = textBox2.Text;
            //Properties.Settings.Default.odbc = textBox1.Text;
            //new Principal_comercial().Show();
            this.Close();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label4.Focus();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label4_Click(sender, e);
            }
        }
    }
}
