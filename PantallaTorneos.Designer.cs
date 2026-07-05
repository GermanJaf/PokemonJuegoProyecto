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
            this.BtnHistorial = new System.Windows.Forms.Button();
            this.BottonVolverPT = new System.Windows.Forms.Button();
            this.buttonTorneo = new System.Windows.Forms.Button();
            this.buttonPractica = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"¡Bienvenido al Coliseo! \r\nElige tu camino: \r\nCompite en el Torneo, o pule tus tá" +
    "cticas en el modo Práctica.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Torneos ganados =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(618, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.BackColor = System.Drawing.SystemColors.Info;
            this.BtnHistorial.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistorial.Location = new System.Drawing.Point(216, 401);
            this.BtnHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Size = new System.Drawing.Size(246, 36);
            this.BtnHistorial.TabIndex = 3;
            this.BtnHistorial.Text = "Ver Historial de torneos";
            this.BtnHistorial.UseVisualStyleBackColor = false;
            this.BtnHistorial.Click += new System.EventHandler(this.BottonPRendimiento_Click);
            // 
            // BottonVolverPT
            // 
            this.BottonVolverPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.BottonVolverPT.Location = new System.Drawing.Point(324, 602);
            this.BottonVolverPT.Margin = new System.Windows.Forms.Padding(2);
            this.BottonVolverPT.Name = "BottonVolverPT";
            this.BottonVolverPT.Size = new System.Drawing.Size(208, 41);
            this.BottonVolverPT.TabIndex = 4;
            this.BottonVolverPT.Text = "Volver";
            this.BottonVolverPT.UseVisualStyleBackColor = true;
            this.BottonVolverPT.Click += new System.EventHandler(this.BottonVolverPT_Click);
            // 
            // buttonTorneo
            // 
            this.buttonTorneo.BackColor = System.Drawing.SystemColors.Info;
            this.buttonTorneo.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTorneo.Location = new System.Drawing.Point(47, 245);
            this.buttonTorneo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTorneo.Name = "buttonTorneo";
            this.buttonTorneo.Size = new System.Drawing.Size(267, 62);
            this.buttonTorneo.TabIndex = 5;
            this.buttonTorneo.Text = "Torneo";
            this.buttonTorneo.UseVisualStyleBackColor = false;
            this.buttonTorneo.Click += new System.EventHandler(this.buttonTorneo_Click);
            // 
            // buttonPractica
            // 
            this.buttonPractica.BackColor = System.Drawing.SystemColors.Info;
            this.buttonPractica.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPractica.Location = new System.Drawing.Point(373, 245);
            this.buttonPractica.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPractica.Name = "buttonPractica";
            this.buttonPractica.Size = new System.Drawing.Size(266, 62);
            this.buttonPractica.TabIndex = 6;
            this.buttonPractica.Text = "Práctica";
            this.buttonPractica.UseVisualStyleBackColor = false;
            this.buttonPractica.Click += new System.EventHandler(this.buttonPractica_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Coliseo de Campeones";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PantallaTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonJuegoProyecto.Properties.Resources.FONDO_ELECCION;
            this.ClientSize = new System.Drawing.Size(680, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPractica);
            this.Controls.Add(this.buttonTorneo);
            this.Controls.Add(this.BottonVolverPT);
            this.Controls.Add(this.BtnHistorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaTorneos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnHistorial;
        private System.Windows.Forms.Button BottonVolverPT;
        private System.Windows.Forms.Button buttonTorneo;
        private System.Windows.Forms.Button buttonPractica;
        private System.Windows.Forms.Label label4;
    }
}