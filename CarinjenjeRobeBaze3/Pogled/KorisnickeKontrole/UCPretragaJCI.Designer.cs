﻿
namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    partial class UCPretragaJCI
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
            this.lblNazivPrimaoca = new System.Windows.Forms.Label();
            this.txtNazivPrimaoca = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvJCI = new System.Windows.Forms.DataGridView();
            this.dgvJCIDetalji = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJCIDetalji)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazivPrimaoca
            // 
            this.lblNazivPrimaoca.AutoSize = true;
            this.lblNazivPrimaoca.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblNazivPrimaoca.Location = new System.Drawing.Point(22, 21);
            this.lblNazivPrimaoca.Name = "lblNazivPrimaoca";
            this.lblNazivPrimaoca.Size = new System.Drawing.Size(129, 20);
            this.lblNazivPrimaoca.TabIndex = 14;
            this.lblNazivPrimaoca.Text = "Naziv primaoca:";
            // 
            // txtNazivPrimaoca
            // 
            this.txtNazivPrimaoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtNazivPrimaoca.Location = new System.Drawing.Point(168, 21);
            this.txtNazivPrimaoca.Multiline = true;
            this.txtNazivPrimaoca.Name = "txtNazivPrimaoca";
            this.txtNazivPrimaoca.Size = new System.Drawing.Size(196, 22);
            this.txtNazivPrimaoca.TabIndex = 18;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(462, 9);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPretrazi.Size = new System.Drawing.Size(95, 46);
            this.btnPretrazi.TabIndex = 27;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvJCI
            // 
            this.dgvJCI.AllowUserToAddRows = false;
            this.dgvJCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvJCI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvJCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJCI.Location = new System.Drawing.Point(26, 71);
            this.dgvJCI.Name = "dgvJCI";
            this.dgvJCI.RowHeadersWidth = 51;
            this.dgvJCI.RowTemplate.Height = 24;
            this.dgvJCI.Size = new System.Drawing.Size(181, 261);
            this.dgvJCI.TabIndex = 29;
            this.dgvJCI.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJCI_RowHeaderMouseClick);
            // 
            // dgvJCIDetalji
            // 
            this.dgvJCIDetalji.AllowUserToAddRows = false;
            this.dgvJCIDetalji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvJCIDetalji.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvJCIDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJCIDetalji.Location = new System.Drawing.Point(231, 71);
            this.dgvJCIDetalji.Name = "dgvJCIDetalji";
            this.dgvJCIDetalji.RowHeadersWidth = 51;
            this.dgvJCIDetalji.RowTemplate.Height = 24;
            this.dgvJCIDetalji.Size = new System.Drawing.Size(444, 261);
            this.dgvJCIDetalji.TabIndex = 30;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(65, 367);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDodaj.Size = new System.Drawing.Size(95, 46);
            this.btnDodaj.TabIndex = 31;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(305, 367);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzmeni.Size = new System.Drawing.Size(95, 46);
            this.btnIzmeni.TabIndex = 32;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(538, 367);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObrisi.Size = new System.Drawing.Size(95, 46);
            this.btnObrisi.TabIndex = 33;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // UCPretragaJCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvJCIDetalji);
            this.Controls.Add(this.dgvJCI);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtNazivPrimaoca);
            this.Controls.Add(this.lblNazivPrimaoca);
            this.Name = "UCPretragaJCI";
            this.Size = new System.Drawing.Size(699, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJCIDetalji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivPrimaoca;
        private System.Windows.Forms.TextBox txtNazivPrimaoca;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvJCI;
        private System.Windows.Forms.DataGridView dgvJCIDetalji;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}
