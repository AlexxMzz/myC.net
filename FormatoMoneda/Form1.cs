using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatoMoneda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            //Convertimos el valor ingresado a decimal
            decimal dec = Convert.ToDecimal(txtPrecio.Text);

            //Convertir el valor decimal a un formato de moneda
            txtPrecio.Text = dec.ToString("n");

            txtPrecio.Select(txtPrecio.Text.Length, -3);
        }
    }
}
