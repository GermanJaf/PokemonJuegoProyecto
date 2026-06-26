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
            this.label1 = new System.Windows.Forms.Label();
            this.ListaGanadasPokemon = new System.Windows.Forms.DataGridView();
            this.buttonVolverPT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaGanadasPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1147, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "En este apartado podras ver el rendimiento de cada pokemon que posee el usuario. " +
    "\r\nOsease, se vera cuantas batallas ha ganado cada pokemon.";
            // 
            // ListaGanadasPokemon
            // 
            this.ListaGanadasPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaGanadasPokemon.Location = new System.Drawing.Point(17, 119);
            this.ListaGanadasPokemon.Name = "ListaGanadasPokemon";
            this.ListaGanadasPokemon.RowHeadersWidth = 51;
            this.ListaGanadasPokemon.RowTemplate.Height = 24;
            this.ListaGanadasPokemon.Size = new System.Drawing.Size(1117, 485);
            this.ListaGanadasPokemon.TabIndex = 1;
            this.ListaGanadasPokemon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaGanadasPokemon_CellContentClick);
            // 
            // buttonVolverPT
            // 
            this.buttonVolverPT.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.buttonVolverPT.Location = new System.Drawing.Point(467, 640);
            this.buttonVolverPT.Name = "buttonVolverPT";
            this.buttonVolverPT.Size = new System.Drawing.Size(201, 58);
            this.buttonVolverPT.TabIndex = 2;
            this.buttonVolverPT.Text = "Volver";
            this.buttonVolverPT.UseVisualStyleBackColor = true;
            this.buttonVolverPT.Click += new System.EventHandler(this.buttonVolverPT_Click);
            // 
            // PantallaRendimientoPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 756);
            this.Controls.Add(this.buttonVolverPT);
            this.Controls.Add(this.ListaGanadasPokemon);
            this.Controls.Add(this.label1);
            this.Name = "PantallaRendimientoPK";
            this.Text = "PantallaRendimientoPK";
            this.Load += new System.EventHandler(this.PantallaRendimientoPK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaGanadasPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ListaGanadasPokemon;
        private System.Windows.Forms.Button buttonVolverPT;
    }
}