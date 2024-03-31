using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutocompletadoComboBox
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

        private void CompletarFrutas ()
        {
            cmbFrutas.Items.Add("Manzana");
            cmbFrutas.Items.Add("Pera");
            cmbFrutas.Items.Add("Durazno");
            cmbFrutas.Items.Add("Kiwi");
            cmbFrutas.Items.Add("Papaya");
            cmbFrutas.Items.Add("Pitahaya");

            cmbFrutas.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFrutas.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void cmbFrutas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CompletarFrutas();
        }
    }
}
