using Compilador.Clases;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxRuta.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cargarArchivo_Click(object sender, EventArgs e)
        {
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                //Aqui va el código para abrir y leer el archivo
                textBoxRuta.Text = archivo.FileName;
                string[] direccion = archivo.FileName.Split('\\');

                File.Copy(archivo.FileName, direccion[direccion.Length - 1], true);
                MessageBox.Show("Archivo creado correctamente");

                using (StreamReader reader = new StreamReader(archivo.FileName))
                {
                    string[] texto = reader.ReadToEnd().Split('\n'); //Salto de linea

                    StringBuilder cadenaConcatenada = new StringBuilder();
                    foreach (var lineaArchivo in texto)
                    {
                        cadenaConcatenada.Append(lineaArchivo);
                    }

                    texto = cadenaConcatenada.ToString().Split('\r'); //Retornar carro
                    int contadorLineas = 1;
                    Entrada entrada = Entrada.obtenerInstancia();
                    StringBuilder lineaInicial = new StringBuilder();
                    foreach (var linea in texto)
                    {
                        Linea nuevaLinea = new Linea(contadorLineas, linea);
                        entrada.agregarLinea(nuevaLinea);
                        lineaInicial.Append(contadorLineas + "->" + nuevaLinea.Contenido + Environment.NewLine);
                        contadorLineas++;
                    }

                    registroCarga.Text = lineaInicial.ToString();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRuta.Visible = false;
            cargarArchivo.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRuta.Visible = true;
            cargarArchivo.Visible = true;
        }
    }
}
