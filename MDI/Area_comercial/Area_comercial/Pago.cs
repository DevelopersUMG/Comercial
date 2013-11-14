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
    public partial class Pago : Form
    {
        private double total;
        public bool band = false;
        private bool blHasDot = false;
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        double tasa=1;

        public Pago(double t)
        {
            InitializeComponent();
            this.total = t;
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = db.consulta_ComboBox("select idtbm_moneda,nombre_moneda from tbm_moneda");
            comboBox2.DisplayMember = "nombre_moneda";
            comboBox2.ValueMember = "idtbm_moneda";

            comboBox3.DataSource = db.consulta_ComboBox("select idtbm_tipo_pago,nombre_tipo_pago from tbm_tipo_pago");
            comboBox3.DisplayMember = "nombre_tipo_pago";
            comboBox3.ValueMember = "idtbm_tipo_pago";

            calculos();
            comboBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            band = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool resultados(out int pago, out int moneda, out string referencia, out int plazo, out double abono)
        {
            pago = Convert.ToInt32(comboBox3.SelectedValue);
            moneda = Convert.ToInt32(comboBox2.SelectedValue);
            referencia = textBox5.Text;
            plazo = comboBox1.SelectedIndex+1;
            if (!comboBox1.Enabled) plazo = 0;
            abono = Convert.ToDouble(textBox2.Text);
            return this.band;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            calcular();
            blHasDot = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !blHasDot)
            {
                //Allows only one Dot Char
                blHasDot = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcular();
            }
        }

        private void calcular()
        {
            double t;
            bool b = double.TryParse(textBox2.Text, out t);
            if (b)
            {
                if (total > t)
                {
                    label5.Enabled = comboBox1.Enabled = true;
                    comboBox1.Focus();
                }
                else if (total == t)
                {
                    band = true;
                    button1.Enabled = true;
                    button1.Focus();
                    label5.Enabled = comboBox1.Enabled = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            band = true;
            button1.Enabled = true;
            button1.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {         
            
            if (comboBox2.SelectedIndex != 0) {
                Dictionary<string, string> d = db.consultar_un_registro("select tasa_cambio_monedad as 'tasa' from tbm_moneda where idtbm_moneda=" + comboBox2.SelectedValue);
                tasa = Convert.ToDouble(d["tasa"]);
                total = total / tasa; 
            }
            else total = total * tasa;
            calculos();
            comboBox3.Focus();
        }

        private void calculos()
        {
            textBox4.Text = total.ToString("N2");
            double iva = total * 0.12;
            textBox3.Text = iva.ToString("N2");
            textBox1.Text = (total - iva).ToString("N2");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > 0) { label8.Enabled = textBox5.Enabled = true; textBox2.Focus(); }
            else label8.Enabled = textBox5.Enabled = false;
        }

       
    }
}
