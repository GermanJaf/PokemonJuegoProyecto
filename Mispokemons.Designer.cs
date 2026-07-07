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
            this.ListaPokemon = new System.Windows.Forms.DataGridView();
            this.buttonVolverPI = new System.Windows.Forms.Button();
            this.buttonAgregarPK = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelPtsNivel = new System.Windows.Forms.Label();
            this.bottonSN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaPokemon
            // 
            this.ListaPokemon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPokemon.Location = new System.Drawing.Point(334, 73);
            this.ListaPokemon.Margin = new System.Windows.Forms.Padding(2);
            this.ListaPokemon.Name = "ListaPokemon";
            this.ListaPokemon.RowHeadersWidth = 51;
            this.ListaPokemon.RowTemplate.Height = 24;
            this.ListaPokemon.Size = new System.Drawing.Size(330, 354);
            this.ListaPokemon.TabIndex = 0;
            this.ListaPokemon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaPokemon_CellContentClick);
            // 
            // buttonVolverPI
            // 
            this.buttonVolverPI.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverPI.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverPI.Location = new System.Drawing.Point(31, 418);
            this.buttonVolverPI.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVolverPI.Name = "buttonVolverPI";
            this.buttonVolverPI.Size = new System.Drawing.Size(263, 86);
            this.buttonVolverPI.TabIndex = 1;
            this.buttonVolverPI.Text = "Volver";
            this.buttonVolverPI.UseVisualStyleBackColor = false;
            this.buttonVolverPI.Click += new System.EventHandler(this.buttonVolverPI_Click);
            // 
            // buttonAgregarPK
            // 
            this.buttonAgregarPK.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarPK.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarPK.Location = new System.Drawing.Point(31, 73);
            this.buttonAgregarPK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAgregarPK.Name = "buttonAgregarPK";
            this.buttonAgregarPK.Size = new System.Drawing.Size(263, 42);
            this.buttonAgregarPK.TabIndex = 2;
            this.buttonAgregarPK.Text = "Agregar pokemon";
            this.buttonAgregarPK.UseVisualStyleBackColor = false;
            this.buttonAgregarPK.Click += new System.EventHandler(this.buttonAgregarPK_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(92, 343);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelPtsNivel
            // 
            this.LabelPtsNivel.AutoSize = true;
            this.LabelPtsNivel.BackColor = System.Drawing.Color.Transparent;
            this.LabelPtsNivel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPtsNivel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelPtsNivel.Location = new System.Drawing.Point(414, 22);
            this.LabelPtsNivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPtsNivel.Name = "LabelPtsNivel";
            this.LabelPtsNivel.Size = new System.Drawing.Size(85, 25);
            this.LabelPtsNivel.TabIndex = 4;
            this.LabelPtsNivel.Text = "label1";
            this.LabelPtsNivel.Click += new System.EventHandler(this.LabelPtsNivel_Click);
            // 
            // bottonSN
            // 
            this.bottonSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(75)))), ((int)(((byte)(86)))));
            this.bottonSN.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottonSN.Location = new System.Drawing.Point(334, 431);
            this.bottonSN.Margin = new System.Windows.Forms.Padding(2);
            this.bottonSN.Name = "bottonSN";
            this.bottonSN.Size = new System.Drawing.Size(330, 73);
            this.bottonSN.TabIndex = 5;
            this.bottonSN.Text = "Subir nivel al Pokémon";
            this.bottonSN.UseVisualStyleBackColor = false;
            this.bottonSN.Click += new System.EventHandler(this.bottonSN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "POKÉDEX";
            // 
            // pbPreview
            // 
            this.pbPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbPreview.Location = new System.Drawing.Point(79, 145);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(160, 160);
            this.pbPreview.TabIndex = 9;
            this.pbPreview.TabStop = false;
            this.pbPreview.Click += new System.EventHandler(this.pbPreview_Click);
            // 
            // Mispokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonJuegoProyecto.Properties.Resources.FONDOPOKEDE;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bottonSN);
            this.Controls.Add(this.LabelPtsNivel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAgregarPK);
            this.Controls.Add(this.buttonVolverPI);
            this.Controls.Add(this.ListaPokemon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mispokemons";
            this.Text = "Pokédex";
            this.Load += new System.EventHandler(this.Mispokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaPokemon;
        private System.Windows.Forms.Button buttonVolverPI;
        private System.Windows.Forms.Button buttonAgregarPK;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelPtsNivel;
        private System.Windows.Forms.Button bottonSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPreview;
    }
}