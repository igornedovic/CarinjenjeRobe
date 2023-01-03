
namespace CarinjenjeRobeBaze3
{
    partial class FrmGlavna
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
            this.pnlMeni = new System.Windows.Forms.Panel();
            this.btnCarinarnice = new System.Windows.Forms.Button();
            this.btnStanje = new System.Windows.Forms.Button();
            this.btnProizvodi = new System.Windows.Forms.Button();
            this.pnlGlavni = new System.Windows.Forms.Panel();
            this.pnlMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMeni
            // 
            this.pnlMeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.pnlMeni.Controls.Add(this.btnCarinarnice);
            this.pnlMeni.Controls.Add(this.btnStanje);
            this.pnlMeni.Controls.Add(this.btnProizvodi);
            this.pnlMeni.Location = new System.Drawing.Point(0, 0);
            this.pnlMeni.Name = "pnlMeni";
            this.pnlMeni.Size = new System.Drawing.Size(200, 449);
            this.pnlMeni.TabIndex = 0;
            // 
            // btnCarinarnice
            // 
            this.btnCarinarnice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnCarinarnice.FlatAppearance.BorderSize = 0;
            this.btnCarinarnice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarinarnice.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.btnCarinarnice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCarinarnice.Location = new System.Drawing.Point(3, 70);
            this.btnCarinarnice.Name = "btnCarinarnice";
            this.btnCarinarnice.Size = new System.Drawing.Size(194, 38);
            this.btnCarinarnice.TabIndex = 9;
            this.btnCarinarnice.Text = "Carinarnice";
            this.btnCarinarnice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarinarnice.UseVisualStyleBackColor = false;
            this.btnCarinarnice.Click += new System.EventHandler(this.btnCarinarnice_Click);
            // 
            // btnStanje
            // 
            this.btnStanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnStanje.FlatAppearance.BorderSize = 0;
            this.btnStanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStanje.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.btnStanje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStanje.Location = new System.Drawing.Point(3, 37);
            this.btnStanje.Name = "btnStanje";
            this.btnStanje.Size = new System.Drawing.Size(197, 38);
            this.btnStanje.TabIndex = 8;
            this.btnStanje.Text = "Stanja proizvoda";
            this.btnStanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStanje.UseVisualStyleBackColor = false;
            this.btnStanje.Click += new System.EventHandler(this.btnStanje_Click);
            // 
            // btnProizvodi
            // 
            this.btnProizvodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnProizvodi.FlatAppearance.BorderSize = 0;
            this.btnProizvodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProizvodi.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.btnProizvodi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProizvodi.Location = new System.Drawing.Point(3, 3);
            this.btnProizvodi.Name = "btnProizvodi";
            this.btnProizvodi.Size = new System.Drawing.Size(194, 38);
            this.btnProizvodi.TabIndex = 7;
            this.btnProizvodi.Text = "Proizvodi";
            this.btnProizvodi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProizvodi.UseVisualStyleBackColor = false;
            this.btnProizvodi.Click += new System.EventHandler(this.btnProizvodi_Click);
            // 
            // pnlGlavni
            // 
            this.pnlGlavni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGlavni.Location = new System.Drawing.Point(203, 0);
            this.pnlGlavni.Name = "pnlGlavni";
            this.pnlGlavni.Size = new System.Drawing.Size(699, 449);
            this.pnlGlavni.TabIndex = 1;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.pnlGlavni);
            this.Controls.Add(this.pnlMeni);
            this.Name = "FrmGlavna";
            this.Text = "Glavna forma";
            this.pnlMeni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMeni;
        private System.Windows.Forms.Panel pnlGlavni;
        private System.Windows.Forms.Button btnStanje;
        private System.Windows.Forms.Button btnProizvodi;
        private System.Windows.Forms.Button btnCarinarnice;
    }
}

