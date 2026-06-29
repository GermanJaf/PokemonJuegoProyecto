namespace PokemonJuegoProyecto
{
    partial class PantallaConfigTorneo_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaConfigTorneo_));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDFacil = new System.Windows.Forms.CheckBox();
            this.checkBoxDMedio = new System.Windows.Forms.CheckBox();
            this.checkBoxDDificil = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonComenzarTorneo = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans JP", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1346, 320);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // checkBoxDFacil
            // 
            this.checkBoxDFacil.AutoSize = true;
            this.checkBoxDFacil.Location = new System.Drawing.Point(386, 418);
            this.checkBoxDFacil.Name = "checkBoxDFacil";
            this.checkBoxDFacil.Size = new System.Drawing.Size(58, 20);
            this.checkBoxDFacil.TabIndex = 1;
            this.checkBoxDFacil.Text = "Facil";
            this.checkBoxDFacil.UseVisualStyleBackColor = true;
            // 
            // checkBoxDMedio
            // 
            this.checkBoxDMedio.AutoSize = true;
            this.checkBoxDMedio.Location = new System.Drawing.Point(593, 418);
            this.checkBoxDMedio.Name = "checkBoxDMedio";
            this.checkBoxDMedio.Size = new System.Drawing.Size(67, 20);
            this.checkBoxDMedio.TabIndex = 2;
            this.checkBoxDMedio.Text = "Medio";
            this.checkBoxDMedio.UseVisualStyleBackColor = true;
            // 
            // checkBoxDDificil
            // 
            this.checkBoxDDificil.AutoSize = true;
            this.checkBoxDDificil.Location = new System.Drawing.Point(786, 418);
            this.checkBoxDDificil.Name = "checkBoxDDificil";
            this.checkBoxDDificil.Size = new System.Drawing.Size(61, 20);
            this.checkBoxDDificil.TabIndex = 3;
            this.checkBoxDDificil.Text = "Dificil";
            this.checkBoxDDificil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona un nivel de dificultad \r\n(Solo puedes escoger uno)";
            // 
            // buttonComenzarTorneo
            // 
            this.buttonComenzarTorneo.Location = new System.Drawing.Point(454, 515);
            this.buttonComenzarTorneo.Name = "buttonComenzarTorneo";
            this.buttonComenzarTorneo.Size = new System.Drawing.Size(268, 48);
            this.buttonComenzarTorneo.TabIndex = 5;
            this.buttonComenzarTorneo.Text = "COMENZAR";
            this.buttonComenzarTorneo.UseVisualStyleBackColor = true;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(454, 661);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(268, 48);
            this.buttonVolver.TabIndex = 6;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1027, 418);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1024, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selecciona el nivel de los pokemones";
            // 
            // PantallaConfigTorneo_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 810);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonComenzarTorneo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxDDificil);
            this.Controls.Add(this.checkBoxDMedio);
            this.Controls.Add(this.checkBoxDFacil);
            this.Controls.Add(this.label1);
            this.Name = "PantallaConfigTorneo_";
            this.Text = "PantallaConfigTorneo_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDFacil;
        private System.Windows.Forms.CheckBox checkBoxDMedio;
        private System.Windows.Forms.CheckBox checkBoxDDificil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonComenzarTorneo;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}