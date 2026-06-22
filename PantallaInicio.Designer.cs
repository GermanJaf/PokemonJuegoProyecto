namespace PokemonJuegoProyecto
{
    partial class PantallaInicio
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
            this.buttonPokedex = new System.Windows.Forms.Button();
            this.buttonTorneo = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonVolverLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(306, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "POKEUADY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F);
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(811, 87);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenido entrenador, le espera un nuevo mundo pokemon. \r\n\r\nQue es lo que tiene " +
    "pensado hacer ahora?\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonPokedex
            // 
            this.buttonPokedex.Font = new System.Drawing.Font("Noto Sans JP", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPokedex.Location = new System.Drawing.Point(270, 237);
            this.buttonPokedex.Name = "buttonPokedex";
            this.buttonPokedex.Size = new System.Drawing.Size(344, 93);
            this.buttonPokedex.TabIndex = 2;
            this.buttonPokedex.Text = "Tu Pokedex";
            this.buttonPokedex.UseVisualStyleBackColor = true;
            this.buttonPokedex.Click += new System.EventHandler(this.buttonPokedex_Click);
            // 
            // buttonTorneo
            // 
            this.buttonTorneo.Font = new System.Drawing.Font("Noto Sans JP", 22.2F, System.Drawing.FontStyle.Bold);
            this.buttonTorneo.Location = new System.Drawing.Point(270, 391);
            this.buttonTorneo.Name = "buttonTorneo";
            this.buttonTorneo.Size = new System.Drawing.Size(344, 102);
            this.buttonTorneo.TabIndex = 3;
            this.buttonTorneo.Text = "Torneos";
            this.buttonTorneo.UseVisualStyleBackColor = true;
            this.buttonTorneo.Click += new System.EventHandler(this.buttonTorneo_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSalir.Location = new System.Drawing.Point(111, 530);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(224, 55);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonVolverLogin
            // 
            this.buttonVolverLogin.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.buttonVolverLogin.Location = new System.Drawing.Point(574, 530);
            this.buttonVolverLogin.Name = "buttonVolverLogin";
            this.buttonVolverLogin.Size = new System.Drawing.Size(224, 55);
            this.buttonVolverLogin.TabIndex = 5;
            this.buttonVolverLogin.Text = "Salir cuenta";
            this.buttonVolverLogin.UseVisualStyleBackColor = true;
            this.buttonVolverLogin.Click += new System.EventHandler(this.buttonVolverLogin_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 680);
            this.Controls.Add(this.buttonVolverLogin);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonTorneo);
            this.Controls.Add(this.buttonPokedex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPokedex;
        private System.Windows.Forms.Button buttonTorneo;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonVolverLogin;
    }
}