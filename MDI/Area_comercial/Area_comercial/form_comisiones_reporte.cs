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
    public partial class form_comisiones_reporte : Form
    {
        private DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        int mes = 1;
        int vendedor = 0;

        public form_comisiones_reporte()
        {
            InitializeComponent();
        }

        private void form_comisiones_reporte_Load(object sender, EventArgs e)
        {

            bx_nombre.DataSource = db.consulta_ComboBox("select e.tbEmpleado_idEmple as 'idvendedor',concat(e.tbempleado_nomEmple,' ',e.tbempleado_apellemple) as 'nombre' from tbm_vendedor v, tbEmpleado e where v.idtbempleado=e.tbempleado_idemple");
            bx_nombre.DisplayMember = "nombre";
            bx_nombre.ValueMember = "idvendedor";   
            //this.reportViewer1.RefreshReport();
            vendedor = Convert.ToInt32(bx_nombre.SelectedValue);

            numericUpDown1.Value = 1;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 12;
            mes = Convert.ToInt32(numericUpDown1.Value);  
            
        }
        public void generar_consulta()
        {
            

            string query = "select e.tbEmpleado_nomEmple as 'Nombre', c.mes as 'Mes', c.anio as 'Año', c.monto as 'Monto' from tbm_comision c, tbEmpleado e where c.tbEmpleado_idEmple=e.tbEmpleado_idEmple and e.tbEmpleado_idEmple = "+ vendedor+" and c.mes ="+mes;
            grid_comision.DataSource = db.consulta_DataGridView(query);

            ds_comercial_comisiones ds = new ds_comercial_comisiones();

            for (int i = 0; i < grid_comision.RowCount; i++)
            {
                DataGridView dg = grid_comision;
                ds.Tables[0].Rows.Add(new object[]{
                    dg[0,i].Value.ToString(),
                     dg[1,i].Value.ToString(),
                      dg[2,i].Value.ToString(),
                       dg[3,i].Value.ToString()
                });
            }

            Reportes rep = new Reportes("reporte_comision.rdlc", ds, "consulta_comisiones");
            rep.ShowDialog();

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            generar_consulta();
        }
    }
}
