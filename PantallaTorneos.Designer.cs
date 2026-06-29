namespace PokemonJuegoProyecto
{
    partial class PantallaTorneos
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
            this.BottonPRendimiento = new System.Windows.Forms.Button();
            this.BottonVolverPT = new System.Windows.Forms.Button();
            this.buttonTorneo = new System.Windows.Forms.Button();
            this.buttonPractica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1155, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a los torneos, en este apartado pondras a prueba tu capacidad de \r\ngan" +
    "ar un torneo pokemon.\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Torneos ganados =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // BottonPRendimiento
            // 
            this.BottonPRendimiento.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.BottonPRendimiento.Location = new System.Drawing.Point(550, 127);
            this.BottonPRendimiento.Name = "BottonPRendimiento";
            this.BottonPRendimiento.Size = new System.Drawing.Size(444, 52);
            this.BottonPRendimiento.TabIndex = 3;
            this.BottonPRendimiento.Text = "Ver Rendimientos Pokemons";
            this.BottonPRendimiento.UseVisualStyleBackColor = true;
            this.BottonPRendimiento.Click += new System.EventHandler(this.BottonPRendimiento_Click);
            // 
            // BottonVolverPT
            // 
            this.BottonVolverPT.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.BottonVolverPT.Location = new System.Drawing.Point(432, 741);
            this.BottonVolverPT.Name = "BottonVolverPT";
            this.BottonVolverPT.Size = new System.Drawing.Size(277, 51);
            this.BottonVolverPT.TabIndex = 4;
            this.BottonVolverPT.Text = "Volver";
            this.BottonVolverPT.UseVisualStyleBackColor = true;
            this.BottonVolverPT.Click += new System.EventHandler(this.BottonVolverPT_Click);
            // 
            // buttonTorneo
            // 
            this.buttonTorneo.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.buttonTorneo.Location = new System.Drawing.Point(369, 273);
            this.buttonTorneo.Name = "buttonTorneo";
            this.buttonTorneo.Size = new System.Drawing.Size(442, 108);
            this.buttonTorneo.TabIndex = 5;
            this.buttonTorneo.Text = "Torneo";
            this.buttonTorneo.UseVisualStyleBackColor = true;
            // 
            // buttonPractica
            // 
            this.buttonPractica.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.buttonPractica.Location = new System.Drawing.Point(369, 464);
            this.buttonPractica.Name = "buttonPractica";
            this.buttonPractica.Size = new System.Drawing.Size(438, 126);
            this.buttonPractica.TabIndex = 6;
            this.buttonPractica.Text = "Practica";
            this.buttonPractica.UseVisualStyleBackColor = true;
            this.buttonPractica.Click += new System.EventHandler(this.buttonPractica_Click);
            // 
            // PantallaTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 833);
            this.Controls.Add(this.buttonPractica);
            this.Controls.Add(this.buttonTorneo);
            this.Controls.Add(this.BottonVolverPT);
            this.Controls.Add(this.BottonPRendimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaTorneos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BottonPRendimiento;
        private System.Windows.Forms.Button BottonVolverPT;
        private System.Windows.Forms.Button buttonTorneo;
        private System.Windows.Forms.Button buttonPractica;
    }
}