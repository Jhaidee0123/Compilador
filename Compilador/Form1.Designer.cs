namespace Compilador
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cargarArchivo = new System.Windows.Forms.Button();
            this.archivo = new System.Windows.Forms.OpenFileDialog();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.guardarArchivo = new System.Windows.Forms.SaveFileDialog();
            this.registroCarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carga de datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(60, 100);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Desde archivo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(374, 100);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Desde consola";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cargarArchivo
            // 
            this.cargarArchivo.Location = new System.Drawing.Point(222, 191);
            this.cargarArchivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cargarArchivo.Name = "cargarArchivo";
            this.cargarArchivo.Size = new System.Drawing.Size(140, 46);
            this.cargarArchivo.TabIndex = 4;
            this.cargarArchivo.Text = "Buscar archivo";
            this.cargarArchivo.UseVisualStyleBackColor = true;
            this.cargarArchivo.Click += new System.EventHandler(this.cargarArchivo_Click);
            // 
            // archivo
            // 
            this.archivo.FileName = "archivo";
            this.archivo.Filter = "Text files (*.txt)|*.txt";
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Location = new System.Drawing.Point(56, 151);
            this.textBoxRuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(464, 26);
            this.textBoxRuta.TabIndex = 5;
            // 
            // guardarArchivo
            // 
            this.guardarArchivo.Filter = "Text files (*.txt)|*.txt";
            // 
            // registroCarga
            // 
            this.registroCarga.Location = new System.Drawing.Point(56, 340);
            this.registroCarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registroCarga.Multiline = true;
            this.registroCarga.Name = "registroCarga";
            this.registroCarga.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.registroCarga.Size = new System.Drawing.Size(464, 161);
            this.registroCarga.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registro carga";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registroCarga);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.cargarArchivo);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button cargarArchivo;
        private System.Windows.Forms.OpenFileDialog archivo;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.SaveFileDialog guardarArchivo;
        private System.Windows.Forms.TextBox registroCarga;
        private System.Windows.Forms.Label label2;
    }
}

