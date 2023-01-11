
namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    partial class UCPretragaSazetihDeklaracija
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbParticije = new System.Windows.Forms.GroupBox();
            this.rb2023 = new System.Windows.Forms.RadioButton();
            this.rbSve = new System.Windows.Forms.RadioButton();
            this.rb2022 = new System.Windows.Forms.RadioButton();
            this.rb2021 = new System.Windows.Forms.RadioButton();
            this.rb2020 = new System.Windows.Forms.RadioButton();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvSazete = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.gbParticije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSazete)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParticije
            // 
            this.gbParticije.Controls.Add(this.rb2023);
            this.gbParticije.Controls.Add(this.rbSve);
            this.gbParticije.Controls.Add(this.rb2022);
            this.gbParticije.Controls.Add(this.rb2021);
            this.gbParticije.Controls.Add(this.rb2020);
            this.gbParticije.Location = new System.Drawing.Point(24, 13);
            this.gbParticije.Name = "gbParticije";
            this.gbParticije.Size = new System.Drawing.Size(427, 69);
            this.gbParticije.TabIndex = 2;
            this.gbParticije.TabStop = false;
            this.gbParticije.Text = "Particije";
            // 
            // rb2023
            // 
            this.rb2023.AutoSize = true;
            this.rb2023.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.rb2023.Location = new System.Drawing.Point(348, 29);
            this.rb2023.Name = "rb2023";
            this.rb2023.Size = new System.Drawing.Size(66, 24);
            this.rb2023.TabIndex = 32;
            this.rb2023.TabStop = true;
            this.rb2023.Text = "2023";
            this.rb2023.UseVisualStyleBackColor = true;
            // 
            // rbSve
            // 
            this.rbSve.AutoSize = true;
            this.rbSve.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.rbSve.Location = new System.Drawing.Point(16, 29);
            this.rbSve.Name = "rbSve";
            this.rbSve.Size = new System.Drawing.Size(56, 24);
            this.rbSve.TabIndex = 31;
            this.rbSve.TabStop = true;
            this.rbSve.Text = "Sve";
            this.rbSve.UseVisualStyleBackColor = true;
            // 
            // rb2022
            // 
            this.rb2022.AutoSize = true;
            this.rb2022.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.rb2022.Location = new System.Drawing.Point(259, 29);
            this.rb2022.Name = "rb2022";
            this.rb2022.Size = new System.Drawing.Size(66, 24);
            this.rb2022.TabIndex = 30;
            this.rb2022.TabStop = true;
            this.rb2022.Text = "2022";
            this.rb2022.UseVisualStyleBackColor = true;
            // 
            // rb2021
            // 
            this.rb2021.AutoSize = true;
            this.rb2021.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.rb2021.Location = new System.Drawing.Point(172, 30);
            this.rb2021.Name = "rb2021";
            this.rb2021.Size = new System.Drawing.Size(64, 24);
            this.rb2021.TabIndex = 30;
            this.rb2021.TabStop = true;
            this.rb2021.Text = "2021";
            this.rb2021.UseVisualStyleBackColor = true;
            // 
            // rb2020
            // 
            this.rb2020.AutoSize = true;
            this.rb2020.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.rb2020.Location = new System.Drawing.Point(87, 29);
            this.rb2020.Name = "rb2020";
            this.rb2020.Size = new System.Drawing.Size(66, 24);
            this.rb2020.TabIndex = 29;
            this.rb2020.TabStop = true;
            this.rb2020.Text = "2020";
            this.rb2020.UseVisualStyleBackColor = true;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(576, 32);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPretrazi.Size = new System.Drawing.Size(95, 46);
            this.btnPretrazi.TabIndex = 26;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvSazete
            // 
            this.dgvSazete.AllowUserToAddRows = false;
            this.dgvSazete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSazete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvSazete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSazete.Location = new System.Drawing.Point(24, 114);
            this.dgvSazete.Name = "dgvSazete";
            this.dgvSazete.RowHeadersWidth = 51;
            this.dgvSazete.RowTemplate.Height = 24;
            this.dgvSazete.Size = new System.Drawing.Size(647, 463);
            this.dgvSazete.TabIndex = 28;
            this.dgvSazete.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSazete_RowHeaderMouseClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(695, 207);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDodaj.Size = new System.Drawing.Size(95, 46);
            this.btnDodaj.TabIndex = 29;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(695, 328);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzmeni.Size = new System.Drawing.Size(95, 46);
            this.btnIzmeni.TabIndex = 30;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(695, 452);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObrisi.Size = new System.Drawing.Size(95, 46);
            this.btnObrisi.TabIndex = 31;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // UCPretragaSazetihDeklaracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvSazete);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.gbParticije);
            this.Name = "UCPretragaSazetihDeklaracija";
            this.Size = new System.Drawing.Size(809, 599);
            this.gbParticije.ResumeLayout(false);
            this.gbParticije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSazete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbParticije;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvSazete;
        private System.Windows.Forms.RadioButton rb2020;
        private System.Windows.Forms.RadioButton rb2022;
        private System.Windows.Forms.RadioButton rb2021;
        private System.Windows.Forms.RadioButton rbSve;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.RadioButton rb2023;
    }
}
