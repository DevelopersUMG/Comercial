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
    public partial class Consulta_Clientes : Form
    {
        private DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        string nombre, nit;
        bool band = false;

        public Consulta_Clientes()
        {
            InitializeComponent();
        }

        private void Consulta_Clientes_Load(object sender, EventArgs e)
        {
            string query2 = "select c.idtbm_cliente as 'ID', c.nombre_cliente as 'Nombre', c.nit_cliente as 'NIT', c.direccion_cliente as 'Direccion', m.nombre as 'Municipio', d.nombre as 'Departamento' from tbm_cliente c, tbm_municipio m, tbm_departamentos d where c.idtbm_municipio = m.idtbm_municipio and m.idtbm_departamentos = d.idtbm_departamentos";
            grid_clientes.DataSource = db.consulta_DataGridView(query2);
            grid_clientes.Columns[0].Visible = false;
        }

        private void grid_clientes_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = grid_clientes.CurrentCell.RowIndex;
            nombre = grid_clientes.Rows[rowIndex].Cells[1].Value.ToString();
            nit = grid_clientes.Rows[rowIndex].Cells[2].Value.ToString();
            band = true;
            this.Close();

        }

        public bool resultado (out string nombre, out string nit)
        {
            nombre = this.nombre;
            nit = this.nit;
            return this.band;
        }
    }
}
