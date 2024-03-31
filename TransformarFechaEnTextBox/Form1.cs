using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformarFechaEnTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            // Limitar logitud de caracteres
            txtFecha.MaxLength = 10;
            

            if (txtFecha.Text.Length ==2 || txtFecha.Text.Length ==5)
            {
                //rellena con un signo
                txtFecha.Text = txtFecha.Text + "/";

                //Mantiene el cursor para seguir escribiendo
                txtFecha.Select(txtFecha.Text.Length, 0);

            }


        }
    }
}
