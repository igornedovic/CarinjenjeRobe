
namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    partial class UCCarinarnica
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTekuci = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnCarinici = new System.Windows.Forms.Button();
            this.dgvCarinarnice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarinarnice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblNaziv.Location = new System.Drawing.Point(19, 29);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(140, 20);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv carinarnice:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtNaziv.Location = new System.Drawing.Point(182, 27);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(203, 22);
            this.txtNaziv.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tekuci racun:";
            // 
            // txtTekuci
            // 
            this.txtTekuci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtTekuci.Location = new System.Drawing.Point(182, 67);
            this.txtTekuci.Name = "txtTekuci";
            this.txtTekuci.Size = new System.Drawing.Size(203, 22);
            this.txtTekuci.TabIndex = 9;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(23, 113);
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
            this.btnIzmeni.Location = new System.Drawing.Point(356, 113);
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
            this.btnObrisi.Location = new System.Drawing.Point(693, 113);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObrisi.Size = new System.Drawing.Size(95, 46);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnCarinici
            // 
            this.btnCarinici.Location = new System.Drawing.Point(530, 29);
            this.btnCarinici.Name = "btnCarinici";
            this.btnCarinici.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCarinici.Size = new System.Drawing.Size(95, 46);
            this.btnCarinici.TabIndex = 18;
            this.btnCarinici.Text = "Carinici";
            this.btnCarinici.UseVisualStyleBackColor = true;
            this.btnCarinici.Click += new System.EventHandler(this.btnCarinici_Click);
            // 
            // dgvCarinarnice
            // 
            this.dgvCarinarnice.AllowUserToAddRows = false;
            this.dgvCarinarnice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCarinarnice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvCarinarnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarinarnice.Location = new System.Drawing.Point(23, 198);
            this.dgvCarinarnice.Name = "dgvCarinarnice";
            this.dgvCarinarnice.RowHeadersWidth = 51;
            this.dgvCarinarnice.RowTemplate.Height = 24;
            this.dgvCarinarnice.Size = new System.Drawing.Size(765, 381);
            this.dgvCarinarnice.TabIndex = 19;
            this.dgvCarinarnice.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCarinarnice_RowHeaderMouseClick);
            // 
            // UCCarinarnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCarinarnice);
            this.Controls.Add(this.btnCarinici);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtTekuci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UCCarinarnica";
            this.Size = new System.Drawing.Size(809, 599);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarinarnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTekuci;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnCarinici;
        private System.Windows.Forms.DataGridView dgvCarinarnice;
    }
}
