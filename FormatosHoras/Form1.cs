using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMATOHORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblHMS_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHMS.Text = DateTime.Now.ToString("HH:mm:ss");
            lblHM.Text = DateTime.Now.ToString("HH:mm");
            lblAMPM.Text = DateTime.Now.ToString("h:mm tt");
            lblHMSAMPM.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblHMSM.Text = DateTime.Now.ToString("hh:mm:ss.fff");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
