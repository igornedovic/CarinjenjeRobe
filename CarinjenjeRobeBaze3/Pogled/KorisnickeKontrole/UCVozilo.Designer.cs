
namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    partial class UCVozilo
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
            this.txtBrojTablice = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNacionalnost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojPrikolice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipVozila = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrojTablice
            // 
            this.txtBrojTablice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtBrojTablice.Location = new System.Drawing.Point(149, 21);
            this.txtBrojTablice.Name = "txtBrojTablice";
            this.txtBrojTablice.Size = new System.Drawing.Size(145, 22);
            this.txtBrojTablice.TabIndex = 8;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblNaziv.Location = new System.Drawing.Point(21, 21);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(99, 20);
            this.lblNaziv.TabIndex = 7;
            this.lblNaziv.Text = "Broj tablice:";
            // 
            // txtNacionalnost
            // 
            this.txtNacionalnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtNacionalnost.Location = new System.Drawing.Point(149, 57);
            this.txtNacionalnost.Name = "txtNacionalnost";
            this.txtNacionalnost.Size = new System.Drawing.Size(145, 22);
            this.txtNacionalnost.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nacionalnost:";
            // 
            // txtBrojPrikolice
            // 
            this.txtBrojPrikolice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtBrojPrikolice.Location = new System.Drawing.Point(149, 95);
            this.txtBrojPrikolice.Name = "txtBrojPrikolice";
            this.txtBrojPrikolice.Size = new System.Drawing.Size(145, 22);
            this.txtBrojPrikolice.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Broj prikolice:";
            // 
            // txtTipVozila
            // 
            this.txtTipVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtTipVozila.Location = new System.Drawing.Point(149, 132);
            this.txtTipVozila.Name = "txtTipVozila";
            this.txtTipVozila.Size = new System.Drawing.Size(145, 22);
            this.txtTipVozila.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tip vozila:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(353, 59);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSacuvaj.Size = new System.Drawing.Size(95, 46);
            this.btnSacuvaj.TabIndex = 15;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(523, 59);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzmeni.Size = new System.Drawing.Size(95, 46);
            this.btnIzmeni.TabIndex = 16;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(691, 59);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObrisi.Size = new System.Drawing.Size(95, 46);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVozila.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Location = new System.Drawing.Point(25, 183);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.RowHeadersWidth = 51;
            this.dgvVozila.RowTemplate.Height = 24;
            this.dgvVozila.Size = new System.Drawing.Size(761, 395);
            this.dgvVozila.TabIndex = 18;
            this.dgvVozila.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVozila_RowHeaderMouseClick);
            // 
            // UCVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvVozila);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtTipVozila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojPrikolice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNacionalnost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojTablice);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UCVozilo";
            this.Size = new System.Drawing.Size(809, 599);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojTablice;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNacionalnost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojPrikolice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipVozila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvVozila;
    }
}
