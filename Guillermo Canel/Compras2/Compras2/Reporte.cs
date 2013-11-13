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

namespace Compras2
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
            cargar_cliente();
            this.reportViewer1.RefreshReport();
        }

        private void cargar_cliente()
        {
            DBConnect db = new DBConnect("ADSTConnector");
            string query = "select * from tbm_proveedor";
            dataGridView1.DataSource = db.consulta_DataGridView(query);
            //dataGridView1.Visible = true;
            
            dt_comercial_proveedor ds = new dt_comercial_proveedor();
            //Console.WriteLine(dataGridView1.RowCount.ToString());
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //Console.WriteLine(i.ToString());
                ds.Tables[0].Rows.Add(new object[]{
                    dataGridView1[0, i].Value.ToString(),
                    dataGridView1[1, i].Value.ToString(), 
                    dataGridView1[2, i].Value.ToString(),
                    dataGridView1[3, i].Value.ToString()
                    }
                );
            }
            //Console.WriteLine(ds.Tables[0].Rows.Count.ToString());

            //reportViewer1.Reset();
            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            //Console.WriteLine(reportViewer1.LocalReport.ReportEmbeddedResource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Compras2.Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dt_comercial_proveedor", ds.Tables[0]));
            reportViewer1.Refresh();
            //DataTable1BindingSource.DataSource = ds;
            //reportViewer1.Refresh();
        }
    }
}
