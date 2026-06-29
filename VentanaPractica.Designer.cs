namespace PokemonJuegoProyecto
{
    partial class VentanaPractica
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonSeleccionU = new System.Windows.Forms.Button();
            this.buttonSeleccionR = new System.Windows.Forms.Button();
            this.buttonInicarPractica = new System.Windows.Forms.Button();
            this.buttonVolverPractica = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1255, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al modo de practica.\r\nEn este modo el usuario puede escoger a un pokem" +
    "on para que se enfrente contra el.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(160, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tu pokemon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(909, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tu rival";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(917, 291);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // buttonSeleccionU
            // 
            this.buttonSeleccionU.Font = new System.Drawing.Font("Noto Sans JP", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionU.Location = new System.Drawing.Point(177, 321);
            this.buttonSeleccionU.Name = "buttonSeleccionU";
            this.buttonSeleccionU.Size = new System.Drawing.Size(181, 43);
            this.buttonSeleccionU.TabIndex = 5;
            this.buttonSeleccionU.Text = "Seleccionar";
            this.buttonSeleccionU.UseVisualStyleBackColor = true;
            this.buttonSeleccionU.Click += new System.EventHandler(this.buttonSeleccionU_Click);
            // 
            // buttonSeleccionR
            // 
            this.buttonSeleccionR.Font = new System.Drawing.Font("Noto Sans JP", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSeleccionR.Location = new System.Drawing.Point(917, 430);
            this.buttonSeleccionR.Name = "buttonSeleccionR";
            this.buttonSeleccionR.Size = new System.Drawing.Size(181, 43);
            this.buttonSeleccionR.TabIndex = 6;
            this.buttonSeleccionR.Text = "Seleccionar";
            this.buttonSeleccionR.UseVisualStyleBackColor = true;
            this.buttonSeleccionR.Click += new System.EventHandler(this.buttonSeleccionR_Click);
            // 
            // buttonInicarPractica
            // 
            this.buttonInicarPractica.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.buttonInicarPractica.Location = new System.Drawing.Point(480, 418);
            this.buttonInicarPractica.Name = "buttonInicarPractica";
            this.buttonInicarPractica.Size = new System.Drawing.Size(320, 92);
            this.buttonInicarPractica.TabIndex = 7;
            this.buttonInicarPractica.Text = "PELEAR";
            this.buttonInicarPractica.UseVisualStyleBackColor = true;
            this.buttonInicarPractica.Click += new System.EventHandler(this.buttonInicarPractica_Click);
            // 
            // buttonVolverPractica
            // 
            this.buttonVolverPractica.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.buttonVolverPractica.Location = new System.Drawing.Point(480, 565);
            this.buttonVolverPractica.Name = "buttonVolverPractica";
            this.buttonVolverPractica.Size = new System.Drawing.Size(320, 92);
            this.buttonVolverPractica.TabIndex = 8;
            this.buttonVolverPractica.Text = "Volver";
            this.buttonVolverPractica.UseVisualStyleBackColor = true;
            this.buttonVolverPractica.Click += new System.EventHandler(this.buttonVolverPractica_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(917, 400);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(210, 24);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(909, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nivel del rival";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // VentanaPractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 790);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonVolverPractica);
            this.Controls.Add(this.buttonInicarPractica);
            this.Controls.Add(this.buttonSeleccionR);
            this.Controls.Add(this.buttonSeleccionU);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaPractica";
            this.Text = "VentanaPractica";
            this.Load += new System.EventHandler(this.VentanaPractica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonSeleccionU;
        private System.Windows.Forms.Button buttonSeleccionR;
        private System.Windows.Forms.Button buttonInicarPractica;
        private System.Windows.Forms.Button buttonVolverPractica;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
    }
}