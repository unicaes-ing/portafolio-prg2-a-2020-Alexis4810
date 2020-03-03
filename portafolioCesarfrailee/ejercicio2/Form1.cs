using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numeroDec = Convert.ToInt32(txtdecimal.Text);
            txtbinario.Text = Convert.ToString(numeroDec, 2);
            txtoctal.Text = Convert.ToString(numeroDec, 8);
            txthexadecimal.Text = Convert.ToString(numeroDec, 16);

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbinario.Clear();
            txtdecimal.Clear();
            txthexadecimal.Clear();
            txtoctal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
}
