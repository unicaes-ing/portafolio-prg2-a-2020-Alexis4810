using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4
{
    public partial class Form1 : Form
    {
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double cantidad, impuesto, precio, subtotal, total;

            cantidad = Convert.ToDouble(txtcantidad.Text);
            precio = Convert.ToDouble(txtprecio.Text);
            subtotal = cantidad * precio;
            impuesto = subtotal * 0.13;
            total = impuesto + subtotal;
            txtsubtotal.Text = string.Format("{0:c2}", subtotal);
            txtimpuesto.Text = string.Format("{0:c2}", impuesto);
            txttotal.Text = string.Format("{0:c2}", total);

        }

        private void btnnueva_Click(object sender, EventArgs e)
        {
            txtcantidad.Clear();
            txtimpuesto.Clear();
            txtprecio.Clear();
            txtsubtotal.Clear();
            txttotal.Clear();
            cbotitulo.ResetText();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
