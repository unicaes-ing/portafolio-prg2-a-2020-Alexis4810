using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double e1, e2, e3, pro;
            e1 = double.Parse(txtexamen1.Text);
            e2 = double.Parse(txtexamen2.Text);
            e3 = double.Parse(txtexamen3.Text);
            pro = (e1 + e2 + e3) / 3;
            txtpromedio.Text = pro.ToString();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtexamen1.Clear();
            txtexamen2.Clear();
            txtexamen3.Clear();
            txtexamen4.Clear();
            txtpromedio.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
