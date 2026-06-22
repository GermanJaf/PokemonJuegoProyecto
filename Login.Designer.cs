namespace PokemonJuegoProyecto
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pokeuady = new System.Windows.Forms.Label();
            this.usuariolabel = new System.Windows.Forms.Label();
            this.usuariologinbox = new System.Windows.Forms.TextBox();
            this.contraseñalabel = new System.Windows.Forms.Label();
            this.contraseñalogintext = new System.Windows.Forms.TextBox();
            this.iniciologinbotton = new System.Windows.Forms.Button();
            this.NuevoUsuarioLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pokeuady
            // 
            this.Pokeuady.AutoSize = true;
            this.Pokeuady.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pokeuady.Location = new System.Drawing.Point(80, 49);
            this.Pokeuady.Name = "Pokeuady";
            this.Pokeuady.Size = new System.Drawing.Size(272, 53);
            this.Pokeuady.TabIndex = 0;
            this.Pokeuady.Text = "PokeUADY";
            this.Pokeuady.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pokeuady.Click += new System.EventHandler(this.label1_Click);
            // 
            // usuariolabel
            // 
            this.usuariolabel.AutoSize = true;
            this.usuariolabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariolabel.Location = new System.Drawing.Point(28, 144);
            this.usuariolabel.Name = "usuariolabel";
            this.usuariolabel.Size = new System.Drawing.Size(75, 27);
            this.usuariolabel.TabIndex = 1;
            this.usuariolabel.Text = "Usuario";
            this.usuariolabel.Click += new System.EventHandler(this.usuario_Click);
            // 
            // usuariologinbox
            // 
            this.usuariologinbox.Location = new System.Drawing.Point(33, 174);
            this.usuariologinbox.Name = "usuariologinbox";
            this.usuariologinbox.Size = new System.Drawing.Size(319, 22);
            this.usuariologinbox.TabIndex = 2;
            this.usuariologinbox.TextChanged += new System.EventHandler(this.usuariologinbox_TextChanged);
            // 
            // contraseñalabel
            // 
            this.contraseñalabel.AutoSize = true;
            this.contraseñalabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F);
            this.contraseñalabel.Location = new System.Drawing.Point(28, 226);
            this.contraseñalabel.Name = "contraseñalabel";
            this.contraseñalabel.Size = new System.Drawing.Size(106, 27);
            this.contraseñalabel.TabIndex = 3;
            this.contraseñalabel.Text = "Contraseña";
            // 
            // contraseñalogintext
            // 
            this.contraseñalogintext.Location = new System.Drawing.Point(33, 256);
            this.contraseñalogintext.Name = "contraseñalogintext";
            this.contraseñalogintext.PasswordChar = '*';
            this.contraseñalogintext.Size = new System.Drawing.Size(310, 22);
            this.contraseñalogintext.TabIndex = 4;
            this.contraseñalogintext.TextChanged += new System.EventHandler(this.contraseñalogintext_TextChanged);
            // 
            // iniciologinbotton
            // 
            this.iniciologinbotton.Location = new System.Drawing.Point(114, 326);
            this.iniciologinbotton.Name = "iniciologinbotton";
            this.iniciologinbotton.Size = new System.Drawing.Size(162, 37);
            this.iniciologinbotton.TabIndex = 5;
            this.iniciologinbotton.Text = "INICIAR SESION";
            this.iniciologinbotton.UseVisualStyleBackColor = true;
            this.iniciologinbotton.Click += new System.EventHandler(this.iniciologinbotton_Click);
            // 
            // NuevoUsuarioLogin
            // 
            this.NuevoUsuarioLogin.Location = new System.Drawing.Point(114, 391);
            this.NuevoUsuarioLogin.Name = "NuevoUsuarioLogin";
            this.NuevoUsuarioLogin.Size = new System.Drawing.Size(161, 44);
            this.NuevoUsuarioLogin.TabIndex = 6;
            this.NuevoUsuarioLogin.Text = "CREAR USUARIO NUEVO";
            this.NuevoUsuarioLogin.UseVisualStyleBackColor = true;
            this.NuevoUsuarioLogin.Click += new System.EventHandler(this.NuevoUsuarioLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 583);
            this.Controls.Add(this.NuevoUsuarioLogin);
            this.Controls.Add(this.iniciologinbotton);
            this.Controls.Add(this.contraseñalogintext);
            this.Controls.Add(this.contraseñalabel);
            this.Controls.Add(this.usuariologinbox);
            this.Controls.Add(this.usuariolabel);
            this.Controls.Add(this.Pokeuady);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pokeuady;
        private System.Windows.Forms.Label usuariolabel;
        private System.Windows.Forms.TextBox usuariologinbox;
        private System.Windows.Forms.Label contraseñalabel;
        private System.Windows.Forms.TextBox contraseñalogintext;
        private System.Windows.Forms.Button iniciologinbotton;
        private System.Windows.Forms.Button NuevoUsuarioLogin;
    }
}

