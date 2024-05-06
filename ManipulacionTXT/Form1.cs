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

namespace ManipulacionTXT
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

        private void label1_Click(object sender, EventArgs e)
        {
            //ups
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            try
            {
                //programar el open file dialog
                //Esto es una ventana de abrir
                openFileDialog1.Title = "Busca tu archivo por favor";
                openFileDialog1.ShowDialog();

                string texto = openFileDialog1.FileName;

                if (File.Exists(openFileDialog1.FileName))
                {



                    //objeto para iniciar la lectura
                    TextReader Leer = new StreamReader(texto);

                    //Comando para leer la totaalidad de un texto y asignarto al rich text
                    rtxtRich.Text = Leer.ReadToEnd();

                    Leer.Close();
                }

                //en el txtDireccion coloca la ruta del archivo abierto
                txtDireccion.Text = texto;

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al abrir: " + ex.Message);
            }
            finally
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txtN = saveFileDialog1.FileName;

                        StreamWriter textoPorGuardar = File.CreateText(txtN);

                        textoPorGuardar.Write(rtxtRich.Text);
                        //libera memoriaa
                        textoPorGuardar.Flush();
                        //cierra documento
                        textoPorGuardar.Close();

                        txtDireccion.Text = txtN;

                    }
                    else
                    {
                        string txtN = saveFileDialog1.FileName;

                        StreamWriter textoPorGuardar = File.CreateText(txtN);

                        textoPorGuardar.Write(rtxtRich.Text);
                        //libera memoriaa
                        textoPorGuardar.Flush();
                        //cierra documento
                        textoPorGuardar.Close();

                        txtDireccion.Text = txtN;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir: " + ex.Message);
            }
            finally
            {

            }
        }
    }
}
