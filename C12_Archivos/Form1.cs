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

namespace C12_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDirectorioActual_Click(object sender, EventArgs e)
        {
            //mostramos en el LABEL el PATH el directorio actual
            labelPath.Text = Directory.GetCurrentDirectory();// +"\\";
        }

        private void buttonEscritorio_Click(object sender, EventArgs e)
        {
            //mostramos en el LABEL el PATH del escritorio de Windows
            labelDesktop.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            labelDesktopRelativo.Text = $"{Path.DirectorySeparatorChar}" + Environment.SpecialFolder.Desktop;

            labelCombinado.Text = Path.Combine("stores", "201"); //"stores\201"
        }

        private void buttonCrearDirectorio_Click(object sender, EventArgs e)
        {
            string path = "";
            labelMensaje.Text = "";
            labelMensaje.ForeColor = Color.Black;
            if (textBoxDirectorio.Text != "") {
                //creamos un DIRECTORIO nuevo con el nombre ingresado en el textbox
                path = Path.Combine($".{Path.DirectorySeparatorChar}", textBoxDirectorio.Text); //    .\<NOMBRE_DIRECTORIO>
                Directory.CreateDirectory(path);

                labelMensaje.Text = "Se creo el directorio";
                labelMensaje.ForeColor = Color.Green;
                textBoxDirectorio.Text = "";
            }
            else
            {
                labelMensaje.Text = "Debe ingresar un nombre!";
                labelMensaje.ForeColor = Color.Red;
            }


            //JSON: JavaScript Object Notation

            //CSV: Content Separated Values
        }

        private void buttonCrearArchivo_Click(object sender, EventArgs e)
        {
            //Creamos un archivo con nombre, extension y contenido de acuerdo a los textbox en la carpeta \stores\201
            string nombre = textBoxNombreArchivo.Text + "." + textBoxExtension.Text;

            string path = Path.Combine($".{Path.DirectorySeparatorChar}stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}", nombre);
            /*
             .\stores\201\<NOMBRE.EXTENSION>
             */
            
            File.WriteAllText(path, textBoxContenido.Text);
        }

        private void buttonDirectorios_Click(object sender, EventArgs e)
        {
            textBoxMultilineaDirectorio.Text = "";
            //nos paramos en la carpeta STORES
            string path = Directory.GetCurrentDirectory()+"\\stores\\";
            
            IEnumerable<String> listadoDirectorios;
            if (radioButtonTXT.Checked) {
                //recuperammos todos los archivos TXT de todos los subdirectorios
                listadoDirectorios = Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories);
            }
            else {
                //recuperammos todos los archivos JSON de todos los subdirectorios
                listadoDirectorios = Directory.EnumerateFiles(path, "*.json", SearchOption.AllDirectories);
            }
            
            //mostramos un listado de los archivos encontrados
            foreach (String file in listadoDirectorios) {
                textBoxMultilineaDirectorio.Text += file + Environment.NewLine;
            }
        }
    }
}
