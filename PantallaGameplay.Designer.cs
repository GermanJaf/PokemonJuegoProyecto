namespace PokemonJuegoProyecto
{
    partial class PantallaGameplay
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
            this.labelPokemonUsuario = new System.Windows.Forms.Label();
            this.labelPokemonRival = new System.Windows.Forms.Label();
            this.labelvidaRival = new System.Windows.Forms.Label();
            this.labelvidaUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPokemonUsuario
            // 
            this.labelPokemonUsuario.AutoSize = true;
            this.labelPokemonUsuario.Location = new System.Drawing.Point(115, 230);
            this.labelPokemonUsuario.Name = "labelPokemonUsuario";
            this.labelPokemonUsuario.Size = new System.Drawing.Size(44, 16);
            this.labelPokemonUsuario.TabIndex = 0;
            this.labelPokemonUsuario.Text = "label1";
            this.labelPokemonUsuario.Click += new System.EventHandler(this.labelPokemonUsuario_Click);
            // 
            // labelPokemonRival
            // 
            this.labelPokemonRival.AutoSize = true;
            this.labelPokemonRival.Location = new System.Drawing.Point(115, 87);
            this.labelPokemonRival.Name = "labelPokemonRival";
            this.labelPokemonRival.Size = new System.Drawing.Size(44, 16);
            this.labelPokemonRival.TabIndex = 1;
            this.labelPokemonRival.Text = "label2";
            this.labelPokemonRival.Click += new System.EventHandler(this.labelPokemonRival_Click);
            // 
            // labelvidaRival
            // 
            this.labelvidaRival.AutoSize = true;
            this.labelvidaRival.Location = new System.Drawing.Point(521, 87);
            this.labelvidaRival.Name = "labelvidaRival";
            this.labelvidaRival.Size = new System.Drawing.Size(44, 16);
            this.labelvidaRival.TabIndex = 2;
            this.labelvidaRival.Text = "label1";
            this.labelvidaRival.Click += new System.EventHandler(this.labelvidaRival_Click);
            // 
            // labelvidaUsuario
            // 
            this.labelvidaUsuario.AutoSize = true;
            this.labelvidaUsuario.Location = new System.Drawing.Point(521, 230);
            this.labelvidaUsuario.Name = "labelvidaUsuario";
            this.labelvidaUsuario.Size = new System.Drawing.Size(44, 16);
            this.labelvidaUsuario.TabIndex = 3;
            this.labelvidaUsuario.Text = "label1";
            this.labelvidaUsuario.Click += new System.EventHandler(this.labelvidaUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vida:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 88);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 87);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(734, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 87);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(734, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 87);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PantallaGameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 775);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelvidaUsuario);
            this.Controls.Add(this.labelvidaRival);
            this.Controls.Add(this.labelPokemonRival);
            this.Controls.Add(this.labelPokemonUsuario);
            this.Name = "PantallaGameplay";
            this.Text = "PantallaGameplay";
            this.Load += new System.EventHandler(this.PantallaGameplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPokemonUsuario;
        private System.Windows.Forms.Label labelPokemonRival;
        private System.Windows.Forms.Label labelvidaRival;
        private System.Windows.Forms.Label labelvidaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}