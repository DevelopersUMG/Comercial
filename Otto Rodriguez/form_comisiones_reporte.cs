using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace WindowsFormsApplication1
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
            vendedor = Convert.ToInt32(bx_nombre.ValueMember);

            numericUpDown1.Value = 1;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 12;
            mes = Convert.ToInt32(numericUpDown1.Value);  
            
        }
        public void generar_consulta()
        {
            

            string query = "select idtbEmpleado_idEmple as 'Nombre', mes as 'Mes', anio as 'Año' from tbm_comision where nombre = "+ vendedor+" and Mes ="+mes;
            grid_comision.DataSource = db.consulta_DataGridView(query);

            ds_comercial_comisiones ds = new ds_comercial_comisiones();

            for (int i = 0; i < grid_comision.RowCount; i++)
            {
                DataGridView dg = grid_comision;
                ds.Tables[0].Rows.Add(new object[]{
                    dg[1,i].Value.ToString(),
                     dg[2,i].Value.ToString(),
                      dg[3,i].Value.ToString(),
                       dg[4,i].Value.ToString()
                });
            }

        }
    }
}
