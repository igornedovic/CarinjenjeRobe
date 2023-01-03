
namespace CarinjenjeRobeBaze3.Pogled.Forme
{
    partial class FrmCarinik
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCarinarnica = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgvCarinici = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarinici)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblNaziv.Location = new System.Drawing.Point(22, 21);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(114, 20);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Ime i prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtImePrezime.Location = new System.Drawing.Point(160, 21);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(145, 22);
            this.txtImePrezime.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Carinarnica:";
            // 
            // cbCarinarnica
            // 
            this.cbCarinarnica.FormattingEnabled = true;
            this.cbCarinarnica.Location = new System.Drawing.Point(160, 60);
            this.cbCarinarnica.Name = "cbCarinarnica";
            this.cbCarinarnica.Size = new System.Drawing.Size(145, 24);
            this.cbCarinarnica.TabIndex = 14;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(459, 34);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSacuvaj.Size = new System.Drawing.Size(76, 39);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dgvCarinici
            // 
            this.dgvCarinici.AllowUserToAddRows = false;
            this.dgvCarinici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCarinici.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvCarinici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarinici.Location = new System.Drawing.Point(26, 119);
            this.dgvCarinici.Name = "dgvCarinici";
            this.dgvCarinici.RowHeadersWidth = 51;
            this.dgvCarinici.RowTemplate.Height = 24;
            this.dgvCarinici.Size = new System.Drawing.Size(406, 194);
            this.dgvCarinici.TabIndex = 20;
            this.dgvCarinici.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCarinici_RowHeaderMouseClick);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(459, 160);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzmeni.Size = new System.Drawing.Size(76, 39);
            this.btnIzmeni.TabIndex = 21;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(459, 236);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObrisi.Size = new System.Drawing.Size(76, 39);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FrmCarinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 335);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dgvCarinici);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbCarinarnica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.lblNaziv);
            this.Name = "FrmCarinik";
            this.Text = "Carinici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarinici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCarinarnica;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgvCarinici;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}