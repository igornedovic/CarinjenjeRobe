
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
            this.btnObrisiAdresu = new System.Windows.Forms.Button();
            this.btnIzmeniAdresu = new System.Windows.Forms.Button();
            this.dgvAdrese = new System.Windows.Forms.DataGridView();
            this.btnSacuvajAdresu = new System.Windows.Forms.Button();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.cbMesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNazivPrimaoca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAdresaPrimaoca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMestoPrimaoca = new System.Windows.Forms.TextBox();
            this.dgvPrimaoci = new System.Windows.Forms.DataGridView();
            this.btnSacuvajPrimaoca = new System.Windows.Forms.Button();
            this.btnObrisiPrimaoca = new System.Windows.Forms.Button();
            this.btnIzmeniPrimaoca = new System.Windows.Forms.Button();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdrese)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaoci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiAdresu);
            this.groupBox1.Controls.Add(this.btnIzmeniAdresu);
            this.groupBox1.Controls.Add(this.dgvAdrese);
            this.groupBox1.Controls.Add(this.btnSacuvajAdresu);
            this.groupBox1.Controls.Add(this.txtBroj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUlica);
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
            // btnObrisiAdresu
            // 
            this.btnObrisiAdresu.Location = new System.Drawing.Point(569, 146);
            this.btnObrisiAdresu.Name = "btnObrisiAdresu";
            this.btnObrisiAdresu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObrisiAdresu.Size = new System.Drawing.Size(87, 42);
            this.btnObrisiAdresu.TabIndex = 23;
            this.btnObrisiAdresu.Text = "Obrisi";
            this.btnObrisiAdresu.UseVisualStyleBackColor = true;
            this.btnObrisiAdresu.Click += new System.EventHandler(this.btnObrisiAdresu_Click);
            // 
            // btnIzmeniAdresu
            // 
            this.btnIzmeniAdresu.Location = new System.Drawing.Point(569, 95);
            this.btnIzmeniAdresu.Name = "btnIzmeniAdresu";
            this.btnIzmeniAdresu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzmeniAdresu.Size = new System.Drawing.Size(87, 45);
            this.btnIzmeniAdresu.TabIndex = 22;
            this.btnIzmeniAdresu.Text = "Izmeni";
            this.btnIzmeniAdresu.UseVisualStyleBackColor = true;
            this.btnIzmeniAdresu.Click += new System.EventHandler(this.btnIzmeniAdresu_Click);
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
            this.dgvAdrese.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAdrese_RowHeaderMouseClick);
            // 
            // btnSacuvajAdresu
            // 
            this.btnSacuvajAdresu.Location = new System.Drawing.Point(569, 22);
            this.btnSacuvajAdresu.Name = "btnSacuvajAdresu";
            this.btnSacuvajAdresu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSacuvajAdresu.Size = new System.Drawing.Size(87, 46);
            this.btnSacuvajAdresu.TabIndex = 20;
            this.btnSacuvajAdresu.Text = "Sacuvaj";
            this.btnSacuvajAdresu.UseVisualStyleBackColor = true;
            this.btnSacuvajAdresu.Click += new System.EventHandler(this.btnSacuvajAdresu_Click);
            // 
            // txtBroj
            // 
            this.txtBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtBroj.Location = new System.Drawing.Point(447, 34);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(93, 22);
            this.txtBroj.TabIndex = 19;
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
            // txtUlica
            // 
            this.txtUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtUlica.Location = new System.Drawing.Point(244, 34);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(145, 22);
            this.txtUlica.TabIndex = 17;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPIB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnObrisiPrimaoca);
            this.groupBox2.Controls.Add(this.btnIzmeniPrimaoca);
            this.groupBox2.Controls.Add(this.btnSacuvajPrimaoca);
            this.groupBox2.Controls.Add(this.dgvPrimaoci);
            this.groupBox2.Controls.Add(this.txtMestoPrimaoca);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbAdresaPrimaoca);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNazivPrimaoca);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primaoci";
            // 
            // txtNazivPrimaoca
            // 
            this.txtNazivPrimaoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtNazivPrimaoca.Location = new System.Drawing.Point(141, 27);
            this.txtNazivPrimaoca.Name = "txtNazivPrimaoca";
            this.txtNazivPrimaoca.Size = new System.Drawing.Size(90, 22);
            this.txtNazivPrimaoca.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Naziv primaoca:";
            // 
            // cbAdresaPrimaoca
            // 
            this.cbAdresaPrimaoca.FormattingEnabled = true;
            this.cbAdresaPrimaoca.Location = new System.Drawing.Point(72, 55);
            this.cbAdresaPrimaoca.Name = "cbAdresaPrimaoca";
            this.cbAdresaPrimaoca.Size = new System.Drawing.Size(79, 24);
            this.cbAdresaPrimaoca.TabIndex = 23;
            this.cbAdresaPrimaoca.SelectedIndexChanged += new System.EventHandler(this.cbAdresaPrimaoca_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(157, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mesto:";
            // 
            // txtMestoPrimaoca
            // 
            this.txtMestoPrimaoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtMestoPrimaoca.Location = new System.Drawing.Point(223, 57);
            this.txtMestoPrimaoca.Name = "txtMestoPrimaoca";
            this.txtMestoPrimaoca.ReadOnly = true;
            this.txtMestoPrimaoca.Size = new System.Drawing.Size(79, 22);
            this.txtMestoPrimaoca.TabIndex = 25;
            // 
            // dgvPrimaoci
            // 
            this.dgvPrimaoci.AllowUserToAddRows = false;
            this.dgvPrimaoci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPrimaoci.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvPrimaoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimaoci.Location = new System.Drawing.Point(8, 78);
            this.dgvPrimaoci.Name = "dgvPrimaoci";
            this.dgvPrimaoci.RowHeadersWidth = 51;
            this.dgvPrimaoci.RowTemplate.Height = 24;
            this.dgvPrimaoci.Size = new System.Drawing.Size(532, 114);
            this.dgvPrimaoci.TabIndex = 26;
            this.dgvPrimaoci.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPrimalac_RowHeaderMouseClick);
            // 
            // btnSacuvajPrimaoca
            // 
            this.btnSacuvajPrimaoca.Location = new System.Drawing.Point(569, 21);
            this.btnSacuvajPrimaoca.Name = "btnSacuvajPrimaoca";
            this.btnSacuvajPrimaoca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSacuvajPrimaoca.Size = new System.Drawing.Size(87, 46);
            this.btnSacuvajPrimaoca.TabIndex = 27;
            this.btnSacuvajPrimaoca.Text = "Sacuvaj";
            this.btnSacuvajPrimaoca.UseVisualStyleBackColor = true;
            this.btnSacuvajPrimaoca.Click += new System.EventHandler(this.btnSacuvajPrimaoca_Click);
            // 
            // btnObrisiPrimaoca
            // 
            this.btnObrisiPrimaoca.Location = new System.Drawing.Point(569, 144);
            this.btnObrisiPrimaoca.Name = "btnObrisiPrimaoca";
            this.btnObrisiPrimaoca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObrisiPrimaoca.Size = new System.Drawing.Size(87, 42);
            this.btnObrisiPrimaoca.TabIndex = 29;
            this.btnObrisiPrimaoca.Text = "Obrisi";
            this.btnObrisiPrimaoca.UseVisualStyleBackColor = true;
            this.btnObrisiPrimaoca.Click += new System.EventHandler(this.btnObrisiPrimaoca_Click);
            // 
            // btnIzmeniPrimaoca
            // 
            this.btnIzmeniPrimaoca.Location = new System.Drawing.Point(569, 93);
            this.btnIzmeniPrimaoca.Name = "btnIzmeniPrimaoca";
            this.btnIzmeniPrimaoca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzmeniPrimaoca.Size = new System.Drawing.Size(87, 45);
            this.btnIzmeniPrimaoca.TabIndex = 28;
            this.btnIzmeniPrimaoca.Text = "Izmeni";
            this.btnIzmeniPrimaoca.UseVisualStyleBackColor = true;
            this.btnIzmeniPrimaoca.Click += new System.EventHandler(this.btnIzmeniPrimaoca_Click);
            // 
            // txtPIB
            // 
            this.txtPIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtPIB.Location = new System.Drawing.Point(312, 27);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(145, 22);
            this.txtPIB.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(256, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "PIB:";
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaoci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbMesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnSacuvajAdresu;
        private System.Windows.Forms.DataGridView dgvAdrese;
        private System.Windows.Forms.Button btnIzmeniAdresu;
        private System.Windows.Forms.Button btnObrisiAdresu;
        private System.Windows.Forms.TextBox txtNazivPrimaoca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAdresaPrimaoca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMestoPrimaoca;
        private System.Windows.Forms.Button btnObrisiPrimaoca;
        private System.Windows.Forms.Button btnIzmeniPrimaoca;
        private System.Windows.Forms.Button btnSacuvajPrimaoca;
        private System.Windows.Forms.DataGridView dgvPrimaoci;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.Label label6;
    }
}
