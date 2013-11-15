using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace Area_comercial
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        bool editar = false, nuevo = false;
        int id;

        private void limpiar()
        {
            textBox1.Enabled = false;
            textBox1.Text = "";
        }

        private void consultar()
        {
            dataGridView1.DataSource = db.consulta_DataGridView("select idtbm_servicio,nombre_servicio as 'Nombre del servicio' from tbm_servicio");
            dataGridView1.Columns[0].Visible = false;
        }

        private void barra1_click_nuevo_button()
        {
            textBox1.Enabled = true;
            nuevo = true;
            editar = false;
            textBox1.Focus();
        }

        private void barra1_click_guardar_button()
        {
            if (textBox1.Text != "")
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre_servicio", textBox1.Text);
                if (nuevo)
                {
                    db.insertar("tbm_servicio", dict);                    
                }
                else if (editar)
                {
                    db.actualizar("tbm_servicio", dict, "idtbm_servicio="+id);
                }
                limpiar();
                consultar();
            }
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            consultar();
        }

        private void barra1_click_buscar_button()
        {
            consultar();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
        }

        private void barra1_click_editar_button()
        {
            if (textBox1.Text != "" && !textBox1.Enabled)
            {
                editar = true;
                nuevo = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
        }
    }
}
