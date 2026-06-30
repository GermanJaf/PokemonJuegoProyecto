namespace PokemonJuegoProyecto
{
    partial class RegistroUs
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registra tu nuevo usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(135, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "POKEUADY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmar Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(241, 147);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(166, 22);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(241, 178);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(166, 22);
            this.txtContrasena.TabIndex = 6;
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(241, 211);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(166, 22);
            this.txtConfirmarContrasena.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(311, 267);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(96, 34);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // RegistroUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroUs";
            this.Text = "RegistroUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Button btnRegistrar;
    }
}