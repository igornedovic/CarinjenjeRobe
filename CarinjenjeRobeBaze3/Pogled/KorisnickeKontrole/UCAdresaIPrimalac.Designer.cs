
namespace CarinjenjeRobeBaze3.Pogled.KorisnickeKontrole
{
    partial class UCAdresaIPrimalac
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgvAdrese = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdrese)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Controls.Add(this.dgvAdrese);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.lblNaziv);
            this.groupBox1.Controls.Add(this.cbMesto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adrese";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primaoci";
            // 
            // cbMesto
            // 
            this.cbMesto.FormattingEnabled = true;
            this.cbMesto.Location = new System.Drawing.Point(70, 32);
            this.cbMesto.Name = "cbMesto";
            this.cbMesto.Size = new System.Drawing.Size(112, 24);
            this.cbMesto.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mesto:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtNaziv.Location = new System.Drawing.Point(244, 34);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(145, 22);
            this.txtNaziv.TabIndex = 17;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.lblNaziv.Location = new System.Drawing.Point(188, 32);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(50, 20);
            this.lblNaziv.TabIndex = 16;
            this.lblNaziv.Text = "Ulica:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.textBox1.Location = new System.Drawing.Point(447, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 22);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(395, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Broj:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(569, 22);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSacuvaj.Size = new System.Drawing.Size(87, 46);
            this.btnSacuvaj.TabIndex = 20;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // dgvAdrese
            // 
            this.dgvAdrese.AllowUserToAddRows = false;
            this.dgvAdrese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAdrese.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvAdrese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdrese.Location = new System.Drawing.Point(8, 74);
            this.dgvAdrese.Name = "dgvAdrese";
            this.dgvAdrese.RowHeadersWidth = 51;
            this.dgvAdrese.RowTemplate.Height = 24;
            this.dgvAdrese.Size = new System.Drawing.Size(532, 114);
            this.dgvAdrese.TabIndex = 21;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(569, 95);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzmeni.Size = new System.Drawing.Size(87, 45);
            this.btnIzmeni.TabIndex = 22;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(569, 146);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObrisi.Size = new System.Drawing.Size(87, 42);
            this.btnObrisi.TabIndex = 23;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // UCAdresaIPrimalac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCAdresaIPrimalac";
            this.Size = new System.Drawing.Size(699, 449);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdrese)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbMesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgvAdrese;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}
