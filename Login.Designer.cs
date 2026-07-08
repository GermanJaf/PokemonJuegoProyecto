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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Pokeuady = new System.Windows.Forms.Label();
            this.usuariolabel = new System.Windows.Forms.Label();
            this.usuariologinbox = new System.Windows.Forms.TextBox();
            this.contraseñalabel = new System.Windows.Forms.Label();
            this.contraseñalogintext = new System.Windows.Forms.TextBox();
            this.iniciologinbotton = new System.Windows.Forms.Button();
            this.NuevoUsuarioLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pokeuady
            // 
            this.Pokeuady.AutoSize = true;
            this.Pokeuady.BackColor = System.Drawing.Color.Transparent;
            this.Pokeuady.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pokeuady.Location = new System.Drawing.Point(104, 77);
            this.Pokeuady.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pokeuady.Name = "Pokeuady";
            this.Pokeuady.Size = new System.Drawing.Size(131, 22);
            this.Pokeuady.TabIndex = 0;
            this.Pokeuady.Text = "UADY BATTLE\r\n";
            this.Pokeuady.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Pokeuady.Click += new System.EventHandler(this.label1_Click);
            // 
            // usuariolabel
            // 
            this.usuariolabel.AutoSize = true;
            this.usuariolabel.BackColor = System.Drawing.Color.Transparent;
            this.usuariolabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariolabel.Location = new System.Drawing.Point(21, 111);
            this.usuariolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usuariolabel.Name = "usuariolabel";
            this.usuariolabel.Size = new System.Drawing.Size(77, 19);
            this.usuariolabel.TabIndex = 1;
            this.usuariolabel.Text = "Usuario";
            this.usuariolabel.Click += new System.EventHandler(this.usuario_Click);
            // 
            // usuariologinbox
            // 
            this.usuariologinbox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariologinbox.Location = new System.Drawing.Point(25, 132);
            this.usuariologinbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usuariologinbox.Name = "usuariologinbox";
            this.usuariologinbox.Size = new System.Drawing.Size(234, 22);
            this.usuariologinbox.TabIndex = 2;
            this.usuariologinbox.TextChanged += new System.EventHandler(this.usuariologinbox_TextChanged);
            // 
            // contraseñalabel
            // 
            this.contraseñalabel.AutoSize = true;
            this.contraseñalabel.BackColor = System.Drawing.Color.Transparent;
            this.contraseñalabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñalabel.Location = new System.Drawing.Point(21, 176);
            this.contraseñalabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contraseñalabel.Name = "contraseñalabel";
            this.contraseñalabel.Size = new System.Drawing.Size(109, 19);
            this.contraseñalabel.TabIndex = 3;
            this.contraseñalabel.Text = "Contraseña";
            // 
            // contraseñalogintext
            // 
            this.contraseñalogintext.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñalogintext.Location = new System.Drawing.Point(25, 197);
            this.contraseñalogintext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contraseñalogintext.Name = "contraseñalogintext";
            this.contraseñalogintext.PasswordChar = '*';
            this.contraseñalogintext.Size = new System.Drawing.Size(234, 22);
            this.contraseñalogintext.TabIndex = 4;
            this.contraseñalogintext.TextChanged += new System.EventHandler(this.contraseñalogintext_TextChanged);
            // 
            // iniciologinbotton
            // 
            this.iniciologinbotton.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciologinbotton.Location = new System.Drawing.Point(25, 248);
            this.iniciologinbotton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iniciologinbotton.Name = "iniciologinbotton";
            this.iniciologinbotton.Size = new System.Drawing.Size(131, 29);
            this.iniciologinbotton.TabIndex = 5;
            this.iniciologinbotton.Text = "INICIAR SESION";
            this.iniciologinbotton.UseVisualStyleBackColor = true;
            this.iniciologinbotton.Click += new System.EventHandler(this.iniciologinbotton_Click);
            // 
            // NuevoUsuarioLogin
            // 
            this.NuevoUsuarioLogin.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoUsuarioLogin.Location = new System.Drawing.Point(169, 248);
            this.NuevoUsuarioLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NuevoUsuarioLogin.Name = "NuevoUsuarioLogin";
            this.NuevoUsuarioLogin.Size = new System.Drawing.Size(132, 29);
            this.NuevoUsuarioLogin.TabIndex = 6;
            this.NuevoUsuarioLogin.Text = "CREAR USUARIO \r\n";
            this.NuevoUsuarioLogin.UseVisualStyleBackColor = true;
            this.NuevoUsuarioLogin.Click += new System.EventHandler(this.NuevoUsuarioLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PokemonJuegoProyecto.Properties.Resources.POKELOGO;
            this.pictureBox1.Location = new System.Drawing.Point(12, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonJuegoProyecto.Properties.Resources.INICIOPOKEMON;
            this.ClientSize = new System.Drawing.Size(339, 481);
            this.Controls.Add(this.NuevoUsuarioLogin);
            this.Controls.Add(this.iniciologinbotton);
            this.Controls.Add(this.contraseñalogintext);
            this.Controls.Add(this.contraseñalabel);
            this.Controls.Add(this.usuariologinbox);
            this.Controls.Add(this.usuariolabel);
            this.Controls.Add(this.Pokeuady);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

