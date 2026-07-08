namespace PokemonJuegoProyecto
{
    partial class PantallaRendimientoPK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRendimientoPK));
            this.label1 = new System.Windows.Forms.Label();
            this.ListaGanadasPokemon = new System.Windows.Forms.DataGridView();
            this.buttonVolverPT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaGanadasPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analiza el desempeño de tus Pokémon en combate \r\ny verifica cuántas victorias ha " +
    "logrado cada uno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListaGanadasPokemon
            // 
            this.ListaGanadasPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaGanadasPokemon.Location = new System.Drawing.Point(11, 136);
            this.ListaGanadasPokemon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListaGanadasPokemon.Name = "ListaGanadasPokemon";
            this.ListaGanadasPokemon.RowHeadersWidth = 51;
            this.ListaGanadasPokemon.RowTemplate.Height = 24;
            this.ListaGanadasPokemon.Size = new System.Drawing.Size(659, 291);
            this.ListaGanadasPokemon.TabIndex = 1;
            this.ListaGanadasPokemon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaGanadasPokemon_CellContentClick);
            // 
            // buttonVolverPT
            // 
            this.buttonVolverPT.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverPT.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverPT.Location = new System.Drawing.Point(251, 460);
            this.buttonVolverPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVolverPT.Name = "buttonVolverPT";
            this.buttonVolverPT.Size = new System.Drawing.Size(169, 39);
            this.buttonVolverPT.TabIndex = 2;
            this.buttonVolverPT.Text = "Volver";
            this.buttonVolverPT.UseVisualStyleBackColor = false;
            this.buttonVolverPT.Click += new System.EventHandler(this.buttonVolverPT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Panel de RENDIMIENTO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PokemonJuegoProyecto.Properties.Resources.hitmonchan;
            this.pictureBox1.Location = new System.Drawing.Point(24, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PantallaRendimientoPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonJuegoProyecto.Properties.Resources.FONDORENDIMIENTO1;
            this.ClientSize = new System.Drawing.Size(684, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVolverPT);
            this.Controls.Add(this.ListaGanadasPokemon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PantallaRendimientoPK";
            this.Text = "RendimientoPK";
            this.Load += new System.EventHandler(this.PantallaRendimientoPK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaGanadasPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ListaGanadasPokemon;
        private System.Windows.Forms.Button buttonVolverPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}