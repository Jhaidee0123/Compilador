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
            this.console = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCargar = new System.Windows.Forms.Button();
            this.consola = new System.Windows.Forms.Panel();
            this.file = new System.Windows.Forms.Panel();
            this.consola.SuspendLayout();
            this.file.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carga de datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(86, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Desde archivo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(210, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Desde consola";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cargarArchivo
            // 
            this.cargarArchivo.Location = new System.Drawing.Point(112, 81);
            this.cargarArchivo.Name = "cargarArchivo";
            this.cargarArchivo.Size = new System.Drawing.Size(93, 30);
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
            this.textBoxRuta.Location = new System.Drawing.Point(0, 17);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(311, 20);
            this.textBoxRuta.TabIndex = 5;
            // 
            // guardarArchivo
            // 
            this.guardarArchivo.Filter = "Text files (*.txt)|*.txt";
            // 
            // registroCarga
            // 
            this.registroCarga.Location = new System.Drawing.Point(37, 261);
            this.registroCarga.Multiline = true;
            this.registroCarga.Name = "registroCarga";
            this.registroCarga.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.registroCarga.Size = new System.Drawing.Size(311, 106);
            this.registroCarga.TabIndex = 7;
            this.registroCarga.TextChanged += new System.EventHandler(this.registroCarga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registro carga";
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.MenuText;
            this.console.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.console.Location = new System.Drawing.Point(3, 3);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(302, 98);
            this.console.TabIndex = 9;
            this.console.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(112, 107);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(93, 28);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // consola
            // 
            this.consola.Controls.Add(this.btnCargar);
            this.consola.Controls.Add(this.console);
            this.consola.Location = new System.Drawing.Point(40, 88);
            this.consola.Name = "consola";
            this.consola.Size = new System.Drawing.Size(311, 138);
            this.consola.TabIndex = 11;
            // 
            // file
            // 
            this.file.Controls.Add(this.textBoxRuta);
            this.file.Controls.Add(this.cargarArchivo);
            this.file.Location = new System.Drawing.Point(40, 88);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(311, 122);
            this.file.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 438);
            this.Controls.Add(this.file);
            this.Controls.Add(this.consola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registroCarga);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.consola.ResumeLayout(false);
            this.file.ResumeLayout(false);
            this.file.PerformLayout();
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
        private System.Windows.Forms.RichTextBox console;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel consola;
        private System.Windows.Forms.Panel file;
    }
}

