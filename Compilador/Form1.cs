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

                System.IO.File.Copy(archivo.FileName, direccion[direccion.Length - 1], true);
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
                    Entrada.Tipo = "Archivo";
                    StringBuilder lineaInicial = new StringBuilder();
                    foreach (var linea in texto)
                    {
                        Entrada.AgregarLinea(linea);
                        lineaInicial.Append(contadorLineas + "->" + linea + Environment.NewLine);
                        contadorLineas++;
                    }
                    registroCarga.Text = lineaInicial.ToString();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            consola.Visible = true;
            file.Visible = false;
            registroCarga.Clear();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            file.Visible = true;
            consola.Visible = false;
            registroCarga.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registroCarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string[] texto = console.Text.Split('\n'); //Salto de linea
            int contadorLineas = 1;
            Entrada.Tipo = "Consola";
            StringBuilder lineaInicial = new StringBuilder();
            foreach (var linea in texto)
            {
                Entrada.AgregarLinea(linea);
                lineaInicial.Append(contadorLineas + "->" + linea + Environment.NewLine);
                contadorLineas++;
            }
            registroCarga.Text = lineaInicial.ToString();


        }
    }
}
