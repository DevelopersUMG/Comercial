using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1
{
    public partial class reporteador : Form
    {
        private DBConnect db = new DBConnect("local");

        public reporteador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            carga_reporte();
        }

        private void carga_reporte()
        {
            string query = "select * from tbm_cliente";
            dataGridView1.DataSource = db.consulta_DataGridView(query);

            ds_comercia_cliente ds = new ds_comercia_cliente();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridView dg = dataGridView1;
                ds.Tables[0].Rows.Add(new object[]{
                    dg[0,i].Value.ToString(),
                     dg[1,i].Value.ToString(),
                      dg[2,i].Value.ToString(),
                       dg[3,i].Value.ToString()
                });
            }

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("cliente",ds.Tables[0]));
            reportViewer1.RefreshReport();
        }
    }

}
