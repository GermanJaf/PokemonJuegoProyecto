namespace PokemonJuegoProyecto
{
    partial class Mispokemons
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
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.buttonVolverPI = new System.Windows.Forms.Button();
            this.buttonAgregarPK = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelPtsNivel = new System.Windows.Forms.Label();
            this.bottonSN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.Location = new System.Drawing.Point(33, 71);
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.RowHeadersWidth = 51;
            this.dgvPokemon.RowTemplate.Height = 24;
            this.dgvPokemon.Size = new System.Drawing.Size(899, 700);
            this.dgvPokemon.TabIndex = 0;
            this.dgvPokemon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPokemon_CellContentClick);
            // 
            // buttonVolverPI
            // 
            this.buttonVolverPI.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.buttonVolverPI.Location = new System.Drawing.Point(1054, 708);
            this.buttonVolverPI.Name = "buttonVolverPI";
            this.buttonVolverPI.Size = new System.Drawing.Size(158, 63);
            this.buttonVolverPI.TabIndex = 1;
            this.buttonVolverPI.Text = "Volver";
            this.buttonVolverPI.UseVisualStyleBackColor = true;
            this.buttonVolverPI.Click += new System.EventHandler(this.buttonVolverPI_Click);
            // 
            // buttonAgregarPK
            // 
            this.buttonAgregarPK.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.buttonAgregarPK.Location = new System.Drawing.Point(1029, 166);
            this.buttonAgregarPK.Name = "buttonAgregarPK";
            this.buttonAgregarPK.Size = new System.Drawing.Size(212, 118);
            this.buttonAgregarPK.TabIndex = 2;
            this.buttonAgregarPK.Text = "Agregar pokemon";
            this.buttonAgregarPK.UseVisualStyleBackColor = true;
            this.buttonAgregarPK.Click += new System.EventHandler(this.buttonAgregarPK_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1029, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelPtsNivel
            // 
            this.LabelPtsNivel.AutoSize = true;
            this.LabelPtsNivel.Font = new System.Drawing.Font("Noto Sans JP", 18F, System.Drawing.FontStyle.Bold);
            this.LabelPtsNivel.Location = new System.Drawing.Point(1080, 356);
            this.LabelPtsNivel.Name = "LabelPtsNivel";
            this.LabelPtsNivel.Size = new System.Drawing.Size(109, 44);
            this.LabelPtsNivel.TabIndex = 4;
            this.LabelPtsNivel.Text = "label1";
            this.LabelPtsNivel.Click += new System.EventHandler(this.LabelPtsNivel_Click);
            // 
            // bottonSN
            // 
            this.bottonSN.Font = new System.Drawing.Font("Noto Sans JP", 16F, System.Drawing.FontStyle.Bold);
            this.bottonSN.Location = new System.Drawing.Point(1054, 415);
            this.bottonSN.Name = "bottonSN";
            this.bottonSN.Size = new System.Drawing.Size(159, 55);
            this.bottonSN.TabIndex = 5;
            this.bottonSN.Text = "Subir nivel";
            this.bottonSN.UseVisualStyleBackColor = true;
            this.bottonSN.Click += new System.EventHandler(this.bottonSN_Click);
            // 
            // Mispokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 817);
            this.Controls.Add(this.bottonSN);
            this.Controls.Add(this.LabelPtsNivel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAgregarPK);
            this.Controls.Add(this.buttonVolverPI);
            this.Controls.Add(this.dgvPokemon);
            this.Name = "Mispokemons";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Mispokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.Button buttonVolverPI;
        private System.Windows.Forms.Button buttonAgregarPK;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelPtsNivel;
        private System.Windows.Forms.Button bottonSN;
    }
}