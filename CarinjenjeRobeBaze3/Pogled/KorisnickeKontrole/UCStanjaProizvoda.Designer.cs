
namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    partial class UCStanjaProizvoda
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbProizvod = new System.Windows.Forms.ComboBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSkladiste = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dgvStanja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Proizvod:";
            // 
            // cbProizvod
            // 
            this.cbProizvod.FormattingEnabled = true;
            this.cbProizvod.Location = new System.Drawing.Point(107, 25);
            this.cbProizvod.Name = "cbProizvod";
            this.cbProizvod.Size = new System.Drawing.Size(190, 24);
            this.cbProizvod.TabIndex = 14;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblNaziv.Location = new System.Drawing.Point(18, 71);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(137, 20);
            this.lblNaziv.TabIndex = 15;
            this.lblNaziv.Text = "Naziv proizvoda:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtNaziv.Location = new System.Drawing.Point(161, 71);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(145, 22);
            this.txtNaziv.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(405, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Skladiste:";
            // 
            // cbSkladiste
            // 
            this.cbSkladiste.FormattingEnabled = true;
            this.cbSkladiste.Location = new System.Drawing.Point(492, 25);
            this.cbSkladiste.Name = "cbSkladiste";
            this.cbSkladiste.Size = new System.Drawing.Size(190, 24);
            this.cbSkladiste.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(333, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bruto masa:";
            // 
            // txtBruto
            // 
            this.txtBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtBruto.Location = new System.Drawing.Point(436, 71);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.Size = new System.Drawing.Size(66, 22);
            this.txtBruto.TabIndex = 20;
            // 
            // txtNeto
            // 
            this.txtNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtNeto.Location = new System.Drawing.Point(616, 71);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(66, 22);
            this.txtNeto.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(513, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Neto masa:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(71, 117);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSacuvaj.Size = new System.Drawing.Size(95, 46);
            this.btnSacuvaj.TabIndex = 23;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(304, 117);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzmeni.Size = new System.Drawing.Size(95, 46);
            this.btnIzmeni.TabIndex = 24;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(539, 117);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObrisi.Size = new System.Drawing.Size(95, 46);
            this.btnObrisi.TabIndex = 25;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dgvStanja
            // 
            this.dgvStanja.AllowUserToAddRows = false;
            this.dgvStanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStanja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvStanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanja.Location = new System.Drawing.Point(22, 193);
            this.dgvStanja.Name = "dgvStanja";
            this.dgvStanja.RowHeadersWidth = 51;
            this.dgvStanja.RowTemplate.Height = 24;
            this.dgvStanja.Size = new System.Drawing.Size(660, 238);
            this.dgvStanja.TabIndex = 26;
            this.dgvStanja.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStanja_RowHeaderMouseClick);
            // 
            // UCStanjaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvStanja);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBruto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSkladiste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.cbProizvod);
            this.Controls.Add(this.label1);
            this.Name = "UCStanjaProizvoda";
            this.Size = new System.Drawing.Size(699, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProizvod;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSkladiste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvStanja;
    }
}
