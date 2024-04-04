using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias usadas para el codigo
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Data;


namespace ImportaExportaEXCEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            //Selecciona un archivo de excel y se establece un filtro para mostrar solo archivos .xlsx
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Archivos de Excel|*.xlsx|Archivos de Excel 97-2003|*.xls" })
            {
                //Si se selecciona un archivo y se da clic en abrir(aceptar) 
                if (ofd.ShowDialog() == DialogResult.OK)

                {
                    //se abrira el archivo en modo lectura
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))

                    {
                        //Se crea un objeto IExcel DR para leer el archivo de excel
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))

                        {
                            //Se carga el contenido del archivo de excel
                            var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                //Configuracion del DataTable
                                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()

                                //True para indicar que la primera fila contiene los encabezados
                                {
                                    UseHeaderRow = true

                                }
                            });

                            //Fuente de datos para el GridView del formulario
                            dataGridView1.DataSource = dataSet.Tables[0];
                        }

                    }

                    //Bloque para establecer los encabezados del GridView - El archivo de Excel debe tener estas cabeceras
                    dataGridView1.Columns[0].HeaderText = "Id";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[2].HeaderText = "CellPhone";
                    dataGridView1.Columns[3].HeaderText = "Address";

                    //Ajustan el tama~o de las columnas del GridView
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoResizeColumns();

                    //Estilo y fuente del GridView
                    dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);
        }

        //Codigo generado para integrar con btnExportar_Click, metodo donde un DataGridView alimenta a un excel 
        private void ExportToExcel(DataGridView dataGridView)

        {
            //Libreria usada *using Excel = Microsoft.Office.Interop.Excel;*
            //Instancia de un excel
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            //Crear un nuevo libro
            Workbook workbook = excelApp.Workbooks.Add();

            //Seleccionar la primera hoja
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            //Obtener el numero de columnas del DataGridView
            int columnCount = dataGridView.ColumnCount;

            //copia los valores del DataGridView al excel
            for (int i = 0; i < columnCount; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            //Obtener el numero de filas del DataGridView
            int rowCount = dataGridView.RowCount;

            //copia los valores del DataGridView al excel
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }

            //mantenerlo en memoria para luego ser salvado
            string tempFile = System.IO.Path.GetTempFileName() + ".xls";

            //Guardar el archivo que esta en memoria
            workbook.SaveAs(tempFile);

        }

    }
}