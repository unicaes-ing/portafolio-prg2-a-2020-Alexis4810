using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double inver1, inver2, inver3, porc1, porc2, porc3, total;
            inver1 = double.Parse(txtinver1.Text);
            inver2 = double.Parse(txtinver2.Text);
            inver3 = double.Parse(txtinver3.Text);
            total = inver1 + inver2 + inver3;
            txttotal.Text = string.Format("{0:c2}", total);
            porc1 = (inver1 / total);
            porc2 = (inver2 / total);
            porc3 = (inver3 / total);
            txtporc1.Text = string.Format("{0:p}", porc1);
            txtporc2.Text = string.Format("{0:p}", porc2);
            txtporc3.Text = string.Format("{0:p}", porc3);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtinver1.Clear();
            txtinver2.Clear();
            txtinver3.Clear();
            txtporc1.Clear();
            txtporc2.Clear();
            txtporc3.Clear();
            txttotal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
