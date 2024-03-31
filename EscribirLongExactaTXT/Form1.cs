using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscribirLongExactaTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text.Length<5)
            {
                MessageBox.Show("Faltan caracteres en el campo deben ser 5", "FALTAN CARACTERES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTexto.Select();
            } else if (txtTexto.Text.Length > 5)
            {
                MessageBox.Show("Sobran caracteres en el campo deben ser 5", "Sobran CARACTERES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTexto.Select();
            }else if (txtTexto.Text.Length == 5)
            {
                MessageBox.Show("Correcto son 5", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTexto.Select();
            }

        }
    }
}
