using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace CREARyESCRIBIRunTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            // usar la libreria using System.IO;
            // Crea un archivo en la raiz del aplicativo \bin\Debug
            TextWriter Escribe = new StreamWriter("Test.txt");

            // Escribe lo que esta dentro del archivo y cierra el Stream
            Escribe.WriteLine("Hola Mundo");
            Escribe.Close();

            // Crea una nueva linea en el txt \bin\Debug
            StreamWriter agregar = File.AppendText("Test.txt");
            agregar.Write("Nueva Linea");
            agregar.Close();


            MessageBox.Show("Creado");



        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //objeto para iniciar la lectura
            TextReader Leer = new StreamReader("Test.txt");

            //comando paraa leer la primera linea de un texto
            //MessageBox.Show(Leer.ReadLine());

            //Comando para leer la totaalidad de un texto
            MessageBox.Show(Leer.ReadToEnd());
            Leer.Close();


        }
    }
}
